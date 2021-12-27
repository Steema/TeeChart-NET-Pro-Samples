using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace TeeChartBuilder
{
	public class DataControllerCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("DataControllerCell");

		public DataControllerCell () : base (UITableViewCellStyle.Value1, Key)
		{
			TextLabel.Text = "TextLabel";
		}
	}
}

