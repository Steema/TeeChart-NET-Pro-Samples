using System;
using System.Drawing;
using Steema.TeeChart;
using Mono.Data.Sqlite;
using System.Collections.Generic;
using UIKit;
using Foundation;

namespace ChartAndSQLite
{
	public partial class ChartAndSQLiteViewController : UIViewController
	{
		// Creatint the Chart
		public TChart chart1 = new TChart();
		// Creating the series type
		public Steema.TeeChart.Styles.Bar bar;

		// Creating the Table view list
		public UITableView table;
		public List<ItemInfo> tableItems;// {get;private set;}

		public ChartAndSQLiteViewController() : base ("ChartAndSQLiteViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Adding the UITableView and items to the View
			table = new UITableView(new RectangleF(0,0,320,190));
			tableItems = new List<ItemInfo>();

			table.DataSource = new TableSource(this);
			table.Delegate = new TableDelegate(this);

			View.AddSubview(table);

			// Specifing a Chart dimension
			System.Drawing.RectangleF rect = new System.Drawing.RectangleF(0,190,320,270);
			chart1.Frame = rect;

			// Setting automatic Zoom and Scroll to manual
			chart1.Aspect.ZoomScrollStyle=Steema.TeeChart.Drawing.Aspect.ZoomScrollStyles.Manual;

			// Adding series to the chart
			bar = new Steema.TeeChart.Styles.Bar();

			// Some settings for the bar Series type
			bar.BarStyle = Steema.TeeChart.Styles.BarStyles.Arrow;
			bar.BarWidthPercent = 200;
			bar.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;
			bar.ColorEach = true;
			chart1.Series.Add(bar);

			// Some settings for the Chart
			chart1.Aspect.View3D = false;
			chart1.Legend.Visible = false;
			chart1.Axes.Bottom.Title.Text = "Customer Invoices";
			chart1.Axes.Left.AxisPen.Width = 1;
			chart1.Axes.Left.Increment = 40;
			chart1.Axes.Bottom.AxisPen.Width = 1;
			chart1.Header.Text = "TeeChart NET for iOS";
			chart1.Header.Font.Color = Color.Black;
			chart1.Panel.MarginTop = 0;
			chart1.Walls.Back.Visible = false;

			View.AddSubview(chart1);
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}

	// Class to define the Items
	public class ItemInfo
	{
		public int CustID { get; set; }
		public string Name { get; set; }
		
		public ItemInfo(int custId,string name)
		{
			CustID = custId;
			Name = name;
		}
		
		public override string ToString ()
		{
			return string.Format("[ItemInfo: Value={0}, Text={1}]", CustID, Name);
		}
	}

	// DataSource for the TableView
	public class TableSource : UITableViewDataSource {

		private ChartAndSQLiteViewController _controller;
		string cellIdentifier = "TableCell";

		public TableSource (ChartAndSQLiteViewController controller)
		{
			_controller = controller;
			_controller.tableItems = LoadCustomerList();
		}
		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return _controller.tableItems.Count;
		}

		private List<ItemInfo> LoadCustomerList()
		{
			var conn = new SqliteConnection("Data Source=TChartTest.sqlite");
			var list = new List<ItemInfo>();
			
			using (var cmd = conn.CreateCommand())
			{
				conn.Open();
				cmd.CommandText ="select CustId,Name from Customers";
				
				using(var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Int64 id = (Int64)reader["CustId"];
						list.Add(new ItemInfo((int)id , (string)reader["Name"]));
					}
				}			
			}
			return list;
		}

		// Deffining specific font types for TableView
		static UIFont smallFont = UIFont.FromName ("Helvetica-LightOblique", 10);
		static UIFont mediumFont = UIFont.FromName ("Helvetica", 13);

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier); 
			
			if ( cell == null )
			{
				cell = new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);
			}
			
			cell.IndentationWidth=0;
			cell.IndentationLevel=1;
			
			cell.TextLabel.Text = _controller.tableItems[indexPath.Row].Name;
			cell.TextLabel.Font = mediumFont;
			
			cell.DetailTextLabel.Font = smallFont;
			cell.DetailTextLabel.Text = "Customer Id : " + _controller.tableItems[indexPath.Row].CustID;
			
			return cell; 
		}
	}

	// Delegate for the TableView
	public class TableDelegate : UITableViewDelegate
	{		
		private ChartAndSQLiteViewController _controller;
		
		public TableDelegate(ChartAndSQLiteViewController controller)
		{
			_controller = controller;		
		}
		
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{		
			LoadCustomerInvoices(_controller.tableItems[indexPath.Row].CustID);
			// tableView.DeselectRow (indexPath, true); // normal iOS behaviour is to remove the blue highlight
		}

		private void LoadCustomerInvoices(int CustID)
		{
			var conn = new SqliteConnection("Data Source=TChartTest.sqlite");			
			using (var cmd = conn.CreateCommand())
			{
				_controller.bar.Clear();
				
				conn.Open();
				cmd.CommandText ="select InvoiceNum,Quantity from CustomerInvoices where CustId="+CustID;
				
				using(var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Double qt = (Double)reader["Quantity"];
						_controller.bar.Add(qt,(string)reader["InvoiceNum"].ToString());
					}
				}
			}
		}
	}	
}