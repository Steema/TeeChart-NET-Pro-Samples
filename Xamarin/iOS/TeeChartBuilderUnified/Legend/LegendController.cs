using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using System.Drawing;
using Steema.TeeChart;

namespace TeeChartBuilder
{
	public class LegendController : UITableViewController
	{
		public TChart chart;
		public ChartViewController chartController;
		
		public LegendController(TChart chart,ChartViewController chartController, UITableViewStyle style) : base(style)
		{	
			this.chart=chart;
			this.chartController = chartController;
		}
		
		public override void ViewDidLoad ()
		{
			NavigationItem.Title = "Legend";
			
			TableView.DataSource = new LegendDataSource(this);
			TableView.Delegate = new LegendDelegate(this);

			UIBarButtonItem button= new UIBarButtonItem();
			button.Title = "Done";
			this.NavigationItem.SetRightBarButtonItem(button,true);
	
            button.Clicked += delegate(object sender, EventArgs e) {			
				this.NavigationController.PopToViewController(chartController,true);
            };
			
			base.ViewDidLoad ();
		}
	}
}
