using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace TeeChartBuilder
{
	public class ColorPalettesDataSource : UITableViewSource
	{
		public List<ItemInfo> Items {get;private set;}
		private string _cellId;
		
		public ColorPalettesDataSource()
		{
			_cellId = "cellid";
			Items = new List<ItemInfo>()
			{			
				new ItemInfo(0,"TeeChart",""),
				new ItemInfo(1,"Excel",""),
				new ItemInfo(2,"Victorian",""),
				new ItemInfo(3,"Pastels",""),
				new ItemInfo(4,"Solid",""),
				new ItemInfo(5,"Classic",""),
				new ItemInfo(6,"Web",""),
				new ItemInfo(7,"Modern",""),
				new ItemInfo(8,"Rainbow",""),
				new ItemInfo(9,"Win. XP",""),
				new ItemInfo(10,"Mac OS",""),
				new ItemInfo(11,"Windows Vista",""),
				new ItemInfo(12,"Grayscale",""),
				new ItemInfo(13,"Opera",""),
				new ItemInfo(14,"Warm",""),
				new ItemInfo(15,"Cool",""),
				new ItemInfo(16,"OnBlack","")
			};
		}
		
		public override string TitleForHeader (UITableView tableView, nint section)
		{
			return "Color Palettes";
		}

		public override nint RowsInSection (UITableView tableview, nint section)
        {
			return Items.Count;
		}
		
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(_cellId); 
			
			if ( cell == null )
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, _cellId);
			}
			
			cell.TextLabel.Text = Items[indexPath.Row].Text;
			    
			return cell; 
		}
	}
}