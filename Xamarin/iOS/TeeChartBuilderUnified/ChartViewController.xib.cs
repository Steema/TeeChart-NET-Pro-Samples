using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using AddressBook;
using CoreTelephony;
using ObjCRuntime;
using MessageUI;
using CoreGraphics;
using Steema.TeeChart;
using System.Drawing;
using TeeChartBuilder.SeriesData;

namespace TeeChartBuilder
{
	public partial class ChartViewController : UIViewController
	{
		public TChart chart= new Steema.TeeChart.TChart();
        SettingsController controller;
		DataControllerController datacontroller;

		#region Constructors

		// The IntPtr and initWithCoder constructors are required for items that need 
		// to be able to be created from a xib rather than from managed code

		public ChartViewController (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public ChartViewController (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public ChartViewController () : base("ChartViewController", null)
		{
			Initialize ();
		}

		void Initialize ()
		{		
			UIDevice.CurrentDevice.BatteryMonitoringEnabled=true;
			float bLevel = UIDevice.CurrentDevice.BatteryLevel;			
			
			Steema.TeeChart.Styles.NumericGauge series1 = new Steema.TeeChart.Styles.NumericGauge();
			series1.Value = bLevel*100;
			chart.Series.Add(series1);
			series1.Markers[2].AllowEdit=true;
			series1.Markers[2].Text= "Battery Level";
			series1.Markers[1].AllowEdit=true;
			series1.Markers[1].Text= "Percentage";

			// Apply theme if desired
			Steema.TeeChart.Themes.AndrosTheme theme = new Steema.TeeChart.Themes.AndrosTheme(chart.Chart);
			theme.Apply();
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(chart.Chart,Steema.TeeChart.Themes.Theme.OnBlackPalette);		
			chart.Aspect.ClipPoints=true;

			chart.Panning.Allow = Steema.TeeChart.ScrollModes.Horizontal;
			chart.Panning.Active = true;
			chart.Zoom.Active = true;
							
			UIBarButtonItem btn1 = new UIBarButtonItem();
			btn1.Style = UIBarButtonItemStyle.Bordered;
			btn1.Title = "Data";
			btn1.Clicked += delegate(object sender, EventArgs e) {
				datacontroller = new SeriesData.DataControllerController(chart,this,chart.Series[0] is Steema.TeeChart.Styles.Custom3D);			  
				NavigationController.PushViewController(datacontroller,true);
			};

			UIBarButtonItem btnSpace = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace);

			UIBarButtonItem btn2 = new UIBarButtonItem(UIBarButtonSystemItem.Action);
			btn2.Style = UIBarButtonItemStyle.Bordered;
			btn2.Title = "";
			btn2.Clicked += delegate(object sender, EventArgs e) 
			{
				var actionSheet = new UIActionSheet ("Options", null, "Cancel", "Camera roll", "Send by mail", "Print"){
					Style = UIActionSheetStyle.Default
				};
				actionSheet.Clicked += delegate (object sender1, UIButtonEventArgs args){
					switch (args.ButtonIndex)
					{
					case 0:
						SaveToCameraRoll();
						break;
					case 1:
						SendByMail();
						break;
					case 2: 
						CallPrint();
						break;
					}
				};
				actionSheet.ShowInView (View);
			};

			BottomBar =	new UIToolbar(new CoreGraphics.CGRect (0,this.View.Frame.Height-22,
				this.View.Frame.Width,44))
			{
				Translucent = false,
				Items = new UIBarButtonItem[]
				{
					btn1,
					btnSpace,
					btn2
				}
			};

			this.View.AddSubview(chart);
			this.View.AddSubview(BottomBar);
			chart.ClipsToBounds = true;

			UIDevice.CurrentDevice.BatteryMonitoringEnabled=false;
		}
		
		#endregion

		public UIToolbar BottomBar;

		private void SaveToCameraRoll()
		{
			UIGraphics.BeginImageContext(chart.Frame.Size); 
			var ctx = UIGraphics.GetCurrentContext();
			if (ctx != null)
			{
				chart.Layer.RenderInContext(ctx);
				UIImage img = UIGraphics.GetImageFromCurrentImageContext();
				UIGraphics.EndImageContext();

				// Save to Photos
				img.SaveToPhotosAlbum(
					(sender, args)=>{
					Console.WriteLine("image saved to Photos");
					}
				);
			}
			else
			{
				Console.WriteLine("ctx null - doesn't seem to happen");
			}
		}

		MFMailComposeViewController _mail;

		private void SendByMail()
		{
			UIGraphics.BeginImageContext(chart.Frame.Size); 
			var ctx = UIGraphics.GetCurrentContext();
			if (ctx != null)
			{
				chart.Layer.RenderInContext(ctx);
				UIImage img = UIGraphics.GetImageFromCurrentImageContext();
				UIGraphics.EndImageContext();

				if (MFMailComposeViewController.CanSendMail) {
					_mail = new MFMailComposeViewController ();
				
					_mail.AddAttachmentData (img.AsPNG (), "image/png", "image.png");
					_mail.SetSubject ("Chart from TeeChart Builder for iPhone");

					_mail.SetMessageBody ("This is the Chart sent through TeeChart app.", false);
					_mail.Finished += HandleMailFinished;

					this.PresentModalViewController (_mail, true);

				} else {
				    // handle not being able to send mail
				}
			}
		}

		void HandleMailFinished (object sender, MFComposeResultEventArgs e)
		{
			if (e.Result == MFMailComposeResult.Sent) {
				UIAlertView alert = new UIAlertView ("Mail Alert", "Mail Sent",
				                                     null, "Yippie", null);
				alert.Show ();

				// you should handle other values that could be returned 
				// in e.Result and also in e.Error 
			}
            e.Controller.DismissViewController(true, () => { });
		}

		private void CallPrint() 
		{
			var printInfo = UIPrintInfo.PrintInfo;
			printInfo.OutputType = UIPrintInfoOutputType.General;
			printInfo.JobName = "Chart";

			var textFormatter = new UISimpleTextPrintFormatter ("Once upon a time...") {
				StartPage = 0,
				ContentInsets = new UIEdgeInsets (72, 72, 72, 72),
				MaximumContentWidth = 6 * 72,
			};

			var printer = UIPrintInteractionController.SharedPrintController;
			printer.PrintInfo = printInfo;
			printer.PrintFormatter = textFormatter;
			printer.ShowsPageRange = true;
			printer.Present (true, (handler, completed, err) => {
				if (!completed && err != null){
					Console.WriteLine ("error");
				}
			});
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UIBarButtonItem button= new UIBarButtonItem();
			button.Title = "Settings";
			this.Title="Chart";
		
            button.Clicked += delegate(object sender, EventArgs e) {			
	            controller = new SettingsController(chart,this,UITableViewStyle.Grouped);			  
	            NavigationController.PushViewController(controller,true);
            };
			
  	        this.NavigationItem.SetRightBarButtonItem(button,true);	
		}

		public override void ViewDidAppear (bool animated)
		{
			UIDevice.CurrentDevice.BeginGeneratingDeviceOrientationNotifications();
		}

		public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations ()
		{
			return base.GetSupportedInterfaceOrientations ();
		}

		private void DeviceRotated(NSNotification notification)
		{
			CheckPositions();
		}

		private void CheckPositions()
		{
			// Refresh Chart rotating the device
			chart.RemoveFromSuperview ();
			View.AddSubview (chart);			
			chart.DoInvalidate ();		
		}

		public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
		{
			CheckPositions ();
		}
	}
}