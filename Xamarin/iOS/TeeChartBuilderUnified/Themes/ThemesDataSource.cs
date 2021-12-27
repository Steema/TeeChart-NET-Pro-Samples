using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace TeeChartBuilder
{
	public class ThemesDataSource : UITableViewSource
	{
		public List<ItemInfo> Items {get;private set;}
		private string _cellId;
		
		public ThemesDataSource()
		{
			_cellId = "cellid";
			Items = new List<ItemInfo>()
			{			
				new ItemInfo(0,"BlackIsBackTheme",""),
				new ItemInfo(1,"OperaTheme",""),
				new ItemInfo(2,"TeeChartTheme",""),
				new ItemInfo(3,"ExcelTheme",""),
				new ItemInfo(4,"ClassicTheme",""),
				new ItemInfo(5,"XPTheme",""),
				new ItemInfo(6,"WebTheme",""),
				new ItemInfo(7,"BusinessTheme",""),
				new ItemInfo(8,"BlueSkyTheme",""),
				new ItemInfo(9,"GrayscaleTheme",""),
				new ItemInfo(10,"RandomTheme","")
			};
		}
		
		public override string TitleForHeader (UITableView tableView, nint section)
        {
			return "Themes";
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
