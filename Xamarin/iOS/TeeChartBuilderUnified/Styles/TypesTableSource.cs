using System;
using System.Drawing;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace TeeChartBuilder
{
	public class TypesTableSource : UITableViewSource
	{
		public List<ItemInfo> Items {get;private set;}
		private string _cellId;

		public TypesTableSource ()
		{
			_cellId = "cellid";
			
			Items = new List<ItemInfo>()
			{
				new ItemInfo(0,"Line","SeriesIcons/line.png"),
				new ItemInfo(1,"Points","SeriesIcons/Points.png"),
				new ItemInfo(2,"Area","SeriesIcons/area.png"),
				new ItemInfo(3,"FastLine","SeriesIcons/fastline.png"),
				new ItemInfo(4,"HorizLine","SeriesIcons/horizline.png"),
				new ItemInfo(5,"Bar","SeriesIcons/bar.png"),
				new ItemInfo(6,"HorizBar","SeriesIcons/horizbar.png"),
				new ItemInfo(7,"Pie","SeriesIcons/pie.png"),
				new ItemInfo(8,"Shape","SeriesIcons/shape.png"),
				new ItemInfo(9,"Arrow","SeriesIcons/arrow.png"),
				new ItemInfo(10,"Bubble","SeriesIcons/bubbles.png"),
				new ItemInfo(11,"Gantt","SeriesIcons/gantt.png"),
				new ItemInfo(12,"Candle","SeriesIcons/candle.png"),
				new ItemInfo(13,"Donut","SeriesIcons/donut.png"),
				new ItemInfo(14,"Volume","SeriesIcons/volume.png"),
				new ItemInfo(15,"Bar3D","SeriesIcons/bar3D.png"),
				new ItemInfo(16,"Points3D","SeriesIcons/Points.png"),
				new ItemInfo(17,"Polar","SeriesIcons/polar.png"),
				new ItemInfo(18,"PolarBar","SeriesIcons/polarbar.png"),
				new ItemInfo(19,"Radar","SeriesIcons/radar.png"),
				new ItemInfo(20,"Clock","SeriesIcons/clock.png"),
				new ItemInfo(21,"WindRose","SeriesIcons/windrose.png"),
				new ItemInfo(22,"Pyramid","SeriesIcons/pyramid.png"),
				new ItemInfo(23,"Surface","SeriesIcons/Surface.png"),
				new ItemInfo(24,"LinePoint","SeriesIcons/linepoint.png"),
				new ItemInfo(25,"BarJoin","SeriesIcons/barjoin.png"),
				new ItemInfo(26,"ColorGrid","SeriesIcons/colorgrid.png"),
				new ItemInfo(27,"Waterfall","SeriesIcons/waterfall.png"),
				new ItemInfo(28,"Histogram","SeriesIcons/histogram.png"),
				new ItemInfo(29,"Error","SeriesIcons/error.png"),
				new ItemInfo(30,"ErrorBar","SeriesIcons/errorbar.png"),
				new ItemInfo(31,"Contour","SeriesIcons/contour.png"),
				new ItemInfo(32,"Smith","SeriesIcons/smith.png"),
				new ItemInfo(33,"Bezier","SeriesIcons/bezier.png"),
				new ItemInfo(34,"Calendar","SeriesIcons/calendar.png"),
				new ItemInfo(35,"HighLow","SeriesIcons/highlow.png"),
				new ItemInfo(36,"TriSurface","SeriesIcons/Surface.png"),
				new ItemInfo(37,"Funnel","SeriesIcons/funnel.png"),
				new ItemInfo(38,"Box","SeriesIcons/box.png"),
				new ItemInfo(39,"HorizBox","SeriesIcons/horizbox.png"),
				new ItemInfo(40,"HorizArea","SeriesIcons/horizarea.png"),
				new ItemInfo(41,"Tower","SeriesIcons/tower.png"),
				new ItemInfo(42,"PointFigure","SeriesIcons/pointnfigure.png"),
				new ItemInfo(43,"Gauges","SeriesIcons/circulargauge.png"),
				new ItemInfo(44,"Vector3D","SeriesIcons/vector3D.png"),
				new ItemInfo(45,"HorizHistogram","SeriesIcons/horizhistogram.png"),
				new ItemInfo(46,"Map","SeriesIcons/map.png"),
				new ItemInfo(47,"ImageBar","SeriesIcons/bar.png"),
				new ItemInfo(48,"Kagi","SeriesIcons/kagi.png"),
				new ItemInfo(49,"Renko","SeriesIcons/renko.png"),
				new ItemInfo(50,"IsoSurface","SeriesIcons/isosurface.png"),
				new ItemInfo(51,"Darvas","SeriesIcons/darvas.png"),
				new ItemInfo(52,"VolumePipe","SeriesIcons/volumepipe.png"),
				new ItemInfo(53,"ImagePoint","SeriesIcons/Points.png"),
				new ItemInfo(54,"CircularGauge","SeriesIcons/circulargauge.png"),
				new ItemInfo(55,"LinearGauge","SeriesIcons/lineargauge.png"),
				new ItemInfo(56,"VerticalLinearGauge","SeriesIcons/vertgauge.png"),
				new ItemInfo(57,"NumericGauge","SeriesIcons/numericgauge.png"),
				new ItemInfo(58,"OrgSeries","SeriesIcons/org.png"),
				new ItemInfo(59,"TagCloud","SeriesIcons/tagcloud.png"),
				new ItemInfo(60,"PolarGrid","SeriesIcons/PolarGrid.png"),
				new ItemInfo(61,"Ternary","SeriesIcons/ternary.png"),
				new ItemInfo(62,"KnobGauge","SeriesIcons/knobgauge.png"),
				new ItemInfo(63,"World","")				
			};
		}
		
		public override nint NumberOfSections (UITableView tableView)
        {
			return 1;
		}
		
		public override nint RowsInSection (UITableView tableview, nint section)
        {
			return Items.Count;
		}
		
		public override string TitleForHeader (UITableView tableView, nint section)
        {
			return "Select the Series Style";
		}
		
		public override string TitleForFooter (UITableView tableView, nint section)
        {
			return Items.Count.ToString() + " Styles";
		}
		
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(_cellId); 
			
			if ( cell == null )
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, _cellId);
			}
			
			cell.IndentationWidth=10;
			cell.IndentationLevel=1;
			
			cell.TextLabel.Text = Items[indexPath.Row].Text;	
			cell.ImageView.Image = UIImage.FromFile(Items[indexPath.Row].ImagePath);
			return cell; 
		}
	}

	public class Settings
	{
		public static int SelectedIndex = 0;	
	}
	
	/// <summary>
	/// A class for holding a table item text and an associated value.
	/// </summary>
	public class ItemInfo
	{
		public int Value { get; set; }
		public string Text { get; set; }
		public string ImagePath { get; set; }
		
		public ItemInfo(int val,string text, string imagePath)
		{
			Value = val;
			Text = text;
			ImagePath = imagePath;
		}
		
		public override string ToString ()
		{
			return string.Format("[ItemInfo: Value={0}, Text={1}]", Value, Text);
		}
	}
}

