using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using Steema.TeeChart;
using System.Drawing;

namespace TeeChartBuilder
{
	public partial class RootViewController : UIViewController
	{
		#region Constructors
		UIButton button;
		UIButton buttonStatistical;
		UIButton buttonAbout;

		// The IntPtr and initWithCoder constructors are required for items that need 
		// to be able to be created from a xib rather than from managed code
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.BackgroundColor=UIColor.Black;

			this.NavigationController.NavigationBar.BarTintColor = UIColor.Black;
			this.NavigationController.NavigationBar.TintColor = UIColor.Gray;
			this.NavigationController.NavigationBar.Translucent = false;
			this.NavigationController.NavigationBar.Opaque = true;

			this.NavigationItem.RightBarButtonItem=null;
 
			button = new UIButton(new RectangleF(20, 260, 280, 48));

		 	button.SetTitle("Chart Styles", UIControlState.Normal);
			button.BackgroundColor= UIColor.DarkGray;
			button.SetTitleColor(UIColor.White, UIControlState.Normal);
			this.View.AddSubview(button);
			
     	    button.TouchDown += delegate(object sender, EventArgs e) {
				NavigationController.NavigationBar.Hidden = false;
				TypesTableController scontroller = new TypesTableController(false); 		  
				NavigationController.PushViewController(scontroller,true);
			};

			buttonStatistical = new UIButton(new RectangleF(20, 310, 280, 48));
		 	buttonStatistical.SetTitle("Create new Chart", UIControlState.Normal);
			buttonStatistical.SetTitleColor(UIColor.White, UIControlState.Normal);
			buttonStatistical.BackgroundColor= UIColor.DarkGray;
			this.View.AddSubview(buttonStatistical);
			
     	    buttonStatistical.TouchDown += delegate(object sender, EventArgs e) {
				NavigationController.NavigationBar.Hidden = false;
				TypesTableController newccontroller = new TypesTableController(true);		  
				NavigationController.PushViewController(newccontroller,true);
            };

			buttonAbout = new UIButton(new RectangleF(20, 360, 280, 48));
		 	buttonAbout.SetTitle("About", UIControlState.Normal);
			buttonAbout.SetTitleColor(UIColor.White, UIControlState.Normal);
			buttonAbout.BackgroundColor= UIColor.Clear;
			this.View.AddSubview(buttonAbout);
			
     	    buttonAbout.TouchDown += delegate(object sender, EventArgs e) {
              AboutViewController controller = new AboutViewController();			  
              NavigationController.PushViewController(controller,true);
            };
			
			var image2Rect = new RectangleF(0f, 30f, 234f, 225f);
			using (var myImage = new UIImageView(image2Rect))
			{  
			    myImage.Image = UIImage.FromFile("images/Chart1.png");
			    myImage.Opaque = false;
				
			    this.View.AddSubview(myImage);
			}

			var imageRect = new RectangleF(190f, 20f, 111f, 80f);
			using (var myImage = new UIImageView(imageRect))
			{  
			    myImage.Image = UIImage.FromFile("images/TeeChartBuilder.png");
			    myImage.Opaque = false;
				
			    this.View.AddSubview(myImage);
			}
		}

		public RootViewController (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public RootViewController (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public RootViewController () : base("RootViewController", null)
		{
			Initialize ();
		}

		void Initialize ()
		{
		}
		#endregion
	}
}