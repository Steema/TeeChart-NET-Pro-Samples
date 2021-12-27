using System;
using System.Drawing;
using Foundation;
using UIKit;
using Steema.TeeChart;
using MonoTouch.Dialog;

namespace TeeChartBuilder.SeriesData
{
	public class DataControllerController : UITableViewController
	{
		public TChart chart;
		public ChartViewController chartController;
		public bool is3dSeries;

		public DataControllerController (TChart chart, ChartViewController chartController, bool is3D) : base (UITableViewStyle.Grouped)
		{
			this.chart =  chart;
			this.chartController = chartController;
			this.is3dSeries = is3D;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
		}

		DataControllerSource dataController;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Register the TableView's data source
			dataController = new DataControllerSource (chart);
			TableView.Source = dataController;
			TableView.Delegate = new DataDelegate(this);

			NavigationItem.SetRightBarButtonItem (new UIBarButtonItem (UIBarButtonSystemItem.Add), false);
			NavigationItem.RightBarButtonItem.Clicked += (sender, e) => { InsertData(is3dSeries); };
		}

		private void ReloadData()
		{
			int xval = dataController.c.Series [0].Count;

			try
			{
				xval = int.Parse (xvalue.Value);
			}
			catch {
				xval = dataController.c.Series [0].Count;
			}

			double yval = 0.0;
			try
			{
				yval = Double.Parse (yvalue.Value);
			}
			catch {
				yval = 0.0;
			}

			if (dataController.c.Series [0] is Steema.TeeChart.Styles.Custom3D) {
				dataController.seriesData.Add (new SeriesData (dataController.c.Series [0] is Steema.TeeChart.Styles.Custom3D,
			                                              xval, 
			                                              yval,
			                                              Double.Parse (zvalue.Value),
			                                              xlabel.Value));
				(dataController.c.Series [0] as Steema.TeeChart.Styles.Custom3D).Add (xval,  yval, Double.Parse (zvalue.Value), xlabel.Value);
			} else {
				dataController.seriesData.Add (new SeriesData (false,
				                                              xval, 
				                                              yval,
				                                              0.0,
				                                              xlabel.Value));

				dataController.c.Series [0].Add (xval,  yval, xlabel.Value);
			}
			TableView.Source = dataController;
			TableView.ReloadData();
		}

		private void UpdateData(int row_sel)
		{
			int xval = dataController.c.Series [0].Count;

			try
			{
				xval = int.Parse (xvalue.Value);
			}
			catch {
				xval = dataController.c.Series [0].Count;
			}

			double yval = 0.0;
			try
			{
				yval = Double.Parse (yvalue.Value);
			}
			catch {
				yval = 0.0;
			}

			if (dataController.c.Series [0] is Steema.TeeChart.Styles.Custom3D) {
				dataController.seriesData [row_sel].XValue = xval;
				dataController.seriesData [row_sel].YValue = yval;
				dataController.seriesData [row_sel].ZValue = Double.Parse (zvalue.Value);
				dataController.seriesData [row_sel].Label = xlabel.Value;

				(dataController.c.Series [0] as Steema.TeeChart.Styles.Custom3D).XValues[row_sel] = xval;
				(dataController.c.Series [0] as Steema.TeeChart.Styles.Custom3D).YValues[row_sel]=  yval;
				(dataController.c.Series [0] as Steema.TeeChart.Styles.Custom3D).ZValues[row_sel]= Double.Parse (zvalue.Value);
				(dataController.c.Series [0] as Steema.TeeChart.Styles.Custom3D).Labels[row_sel]= xlabel.Value;
			} else {
				dataController.seriesData [row_sel].XValue = xval;
				dataController.seriesData [row_sel].YValue = yval;
				dataController.seriesData [row_sel].Label = xlabel.Value;

				dataController.c.Series [0].XValues [row_sel] = xval;
				dataController.c.Series [0].YValues [row_sel] = yval;
				dataController.c.Series [0].Labels [row_sel] = xlabel.Value;
			}
			TableView.Source = dataController;
			dataController.c.DoInvalidate ();
			TableView.ReloadData();
		}

		EntryElement xvalue, yvalue, zvalue, xlabel;
		public void InsertData(bool series3D=false, bool update=false, int row_sel=0)
		{
			string capt = "Add data";
			string bcapt = "Add";
			string xv = "";
			string yv = "";
			string zv = "1";
			string lv = "";

			if (update) {
				capt = "Update data";
				bcapt = "Update";
				xv = dataController.c.Series [0].XValues [row_sel].ToString();
				yv = dataController.c.Series [0].YValues [row_sel].ToString();
				if (series3D)
					zv = (dataController.c.Series [0] as Steema.TeeChart.Styles.Custom3D).ZValues [row_sel].ToString();
				lv = dataController.c.Series [0].Labels [row_sel].ToString();
			}

			if (series3D) {
                DialogViewController a = new DialogViewController(new RootElement(capt) {
					new Section ("Fill data"){
						(xvalue = new EntryElement ("X Value", "Enter the X (optional)", xv)),
						(yvalue = new EntryElement ("Y Value", "Enter the Y Value", yv)),
						(zvalue = new EntryElement ("Z Value", "Enter the Z Value", zv)),
						(xlabel = new EntryElement ("Label", "Enter the label (opcional)", lv))
					},
					new Section () {
						new StringElement (bcapt, delegate{
							Console.WriteLine ("Entered {0} in value ", xvalue.Value); 
							Console.WriteLine ("Entered {0} in value ", yvalue.Value); 
							Console.WriteLine ("Entered {0} in value ", zvalue.Value); 
							Console.WriteLine ("Entered {0} in label ", xlabel.Value); 
							NavigationController.PopToViewController(this,true);
							if (update)
								UpdateData(row_sel);
							else
								ReloadData();
						})  
					}
				}, true);
				NavigationController.PushViewController (a,true);
			} else {
				DialogViewController a = new DialogViewController (new RootElement (capt) {
					new Section ("Fill data"){
					(xvalue = new EntryElement ("X Value", "Enter the X (optional)", xv)),
					(yvalue = new EntryElement ("Y Value", "Enter the Y Value", yv)),
					(xlabel = new EntryElement ("Label", "Enter the label (opcional)", lv))
				},
					new Section () {
						new StringElement (bcapt, delegate{
						Console.WriteLine ("Entered {0} in value ", xvalue.Value); 
						Console.WriteLine ("Entered {0} in value ", yvalue.Value); 
						Console.WriteLine ("Entered {0} in label ", xlabel.Value); 
						NavigationController.PopToViewController(this,true);
						if (update)
							UpdateData(row_sel);
						else
							ReloadData();
					})  
				}
				}, true);
				NavigationController.PushViewController (a,true);
			}
		}
	}	
}