using System;
using System.Drawing;
using Foundation;
using UIKit;
using System.Collections.Generic;
using Steema.TeeChart;

namespace TeeChartBuilder.SeriesData
{
	public class DataControllerSource : UITableViewSource
	{
		public List<SeriesData> seriesData;
		public TChart c;

		public DataControllerSource (TChart chart)
		{
			this.c = chart;

			seriesData = new List<SeriesData> ();
			// Load SeriesData with Values of the Chart
			for (int i=0;i<c.Series[0].Count;i++)
			{
				if (!(c.Series[0] is Steema.TeeChart.Styles.Custom3D)) 
				{
					seriesData.Add( new SeriesData(false, (int)c.Series[0].XValues[i], c.Series[0].YValues[i],0.0,c.Series[0].Labels[i]));
				}
			else
				{
					seriesData.Add( new SeriesData(true,(int)c.Series[0].XValues[i], c.Series[0].YValues[i],(c.Series[0] as Steema.TeeChart.Styles.Custom3D).ZValues[i],c.Series[0].Labels[i]));
				}
			}
		}

		public override nint NumberOfSections (UITableView tableView)
        {
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return seriesData.Count;
		}

		public override string TitleForHeader (UITableView tableView, nint section)
        {
			return "Label and Value";
		}

		public override string TitleForFooter (UITableView tableView, nint section)
        {
			return "";
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (DataControllerCell.Key) as DataControllerCell;
			if (cell == null)
				cell = new DataControllerCell ();

			cell.DetailTextLabel.Text = seriesData [indexPath.Row].YValue.ToString("0.00"); // "DetailsTextLabel";
			cell.TextLabel.Text = seriesData [indexPath.Row].Label.ToString ();

			return cell;
		}

		public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
			switch (editingStyle) {
			case UITableViewCellEditingStyle.Delete:

				// remove the item from the underlying data source
				seriesData.RemoveAt (indexPath.Row);
				// delete the row from the table
				tableView.DeleteRows (new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
				this.c.Series [0].Delete (indexPath.Row);

				break;
			default:
				break;
			}
		}

		public override bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
		{
			return true; // return false if you wish to disable editing for a specific indexPath or for all rows
		}

		public override bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
		{
			return true; // return false if you don't allow re-ordering
		}

		public override UITableViewCellEditingStyle EditingStyleForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return UITableViewCellEditingStyle.Delete; // this example doesn't support Insert
		}
	}
}