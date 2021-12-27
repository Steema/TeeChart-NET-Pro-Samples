using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace TeeChartBuilder
{
	public class TypesTableCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("TypesTableCell");
		
		public TypesTableCell () : base (UITableViewCellStyle.Value1, Key)
		{
		}
	}
}

