using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using System.Drawing;

namespace TeeChartBuilder
{
	public class LegendDataSource : UITableViewDataSource
	{
		private List<LegendItem> _items;
		private string _cellId;
		private string _section2CellId;
		private LegendController _parentController;		 
		
		public LegendDataSource(LegendController parent)
		{
			_cellId = "section1Cell";
			_section2CellId = "section2Cell";
			
			_parentController = parent;
			_items = new List<LegendItem>();
			
			//InitBasic();
			InitAdvanced();
		}
		
		private void InitBasic()
		{
			// Some basic rows
			LegendItem item1 = new LegendItem("Default","",UITableViewCellStyle.Default,UITableViewCellAccessory.None);
			LegendItem item2 = new LegendItem("Subtitle","Here is more description",UITableViewCellStyle.Subtitle,UITableViewCellAccessory.None);
			LegendItem item3 = new LegendItem("Value 1 - no accessory","Here is more description",UITableViewCellStyle.Value1,UITableViewCellAccessory.None);
			LegendItem item4 = new LegendItem("Value 2 - no accessory","Here is more description",UITableViewCellStyle.Value2,UITableViewCellAccessory.None);
			
			LegendItem item5 = new LegendItem("Checkmark","",UITableViewCellStyle.Default,UITableViewCellAccessory.Checkmark);
			LegendItem item6 = new LegendItem("DetailDisclosureButton","",UITableViewCellStyle.Default,UITableViewCellAccessory.DetailDisclosureButton);
			LegendItem item7 = new LegendItem("DisclosureIndicator","",UITableViewCellStyle.Default,UITableViewCellAccessory.DisclosureIndicator);
			
			_items.Add(item1);
			_items.Add(item2);
			_items.Add(item3);
			_items.Add(item4);
			_items.Add(item5);
			_items.Add(item6);
			_items.Add(item7);	
		}
		
		private void InitAdvanced()
		{		
			//
			// Two images + custom control
			//
			LegendItem item3 = new LegendItem("Transparency","",UITableViewCellStyle.Default,UITableViewCellAccessory.None);
			
			UISlider slider = new UISlider();
			slider.MaxValue = 100f;
			slider.Value = 50f;
			slider.MinValue = 0f;
			slider.Frame = new RectangleF(140,9,150,23);
			
			slider.Value=_parentController.chart.Chart.Legend.Transparency;
			slider.ValueChanged+=delegate{
				_parentController.chart.Chart.Legend.Transparency = (int)slider.Value;
			};
			item3.ContentView = slider;
			
			// A switcher legend visible
			LegendItem item4 = new LegendItem("Visible","",UITableViewCellStyle.Default,UITableViewCellAccessory.None);
			UISwitch switcher = new UISwitch();		
			item4.AccessoryView = switcher;
			switcher.On=_parentController.chart.Chart.Legend.Visible;
			switcher.ValueChanged+=delegate{
				_parentController.chart.Chart.Legend.Visible = switcher.On;
			};
			
			// A switcher legend transparent
			LegendItem item5 = new LegendItem("Transparent","",UITableViewCellStyle.Default,UITableViewCellAccessory.None);
			UISwitch switcher2 = new UISwitch();		
			item5.AccessoryView = switcher2;
			switcher2.On=_parentController.chart.Chart.Legend.Transparent;
			switcher2.ValueChanged+=delegate{
				_parentController.chart.Chart.Legend.Transparent = switcher2.On;
			};
			
			// A switcher legend symbols visible
			LegendItem item6 = new LegendItem("Symbols","",UITableViewCellStyle.Default,UITableViewCellAccessory.None);
			UISwitch switcher3 = new UISwitch();		
			item6.AccessoryView = switcher3;
			switcher3.On=_parentController.chart.Chart.Legend.Symbol.Visible;
			switcher3.ValueChanged+=delegate{
				_parentController.chart.Chart.Legend.Symbol.Visible = switcher3.On;
			};
			
			// A switcher legend shadow visible
			LegendItem item7 = new LegendItem("Shadow","",UITableViewCellStyle.Default,UITableViewCellAccessory.None);
			UISwitch switcher4 = new UISwitch();		
			item7.AccessoryView = switcher4;
			switcher4.On=_parentController.chart.Chart.Legend.Shadow.Visible;
			switcher4.ValueChanged+=delegate{
				_parentController.chart.Chart.Legend.Shadow.Visible = switcher4.On;
			};
			
			// A switcher legend pen visible
			LegendItem item8 = new LegendItem("Pen Border","",UITableViewCellStyle.Default,UITableViewCellAccessory.None);
			UISwitch switcher5 = new UISwitch();		
			item8.AccessoryView = switcher5;
			switcher5.On=_parentController.chart.Chart.Legend.Pen.Visible;
			switcher5.ValueChanged+=delegate{
				_parentController.chart.Chart.Legend.Pen.Visible = switcher5.On;
			};

			_items.Add(item3);
			_items.Add(item4);
			_items.Add(item5);
			_items.Add(item6);
			_items.Add(item7);
			_items.Add(item8);
		}
		
	public override string TitleForHeader(UITableView tableView, nint section)
		{
			if (section == 0)
			return "Legend Settings";
			else
			    return "Legend settings";
		}
		
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			if (section == 0)
				return 6;
			else
			    return 4;
		}

        public override nint NumberOfSections(UITableView tableView)
        {
			return 1;
		}
		
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			// Strange things happen if we use the same cellids for both sections - some reuse is attempted by Cocoa.
			string cellId = _cellId;
			var row = indexPath.Row;
			
			if (indexPath.Section == 1)
			{
				row += 7;
				cellId = _section2CellId;
			}
			
			var info = _items[row];
			
			UITableViewCell cell = tableView.DequeueReusableCell(cellId); 
			
			if (cell == null )
			{
				cell = new UITableViewCell(info.Style,cellId);
			}
			
			cell.TextLabel.Text = info.Text;
			cell.Accessory = info.Accessory;
				
			if (!string.IsNullOrEmpty(info.DetailText))
				cell.DetailTextLabel.Text = info.DetailText;
			
			if (info.Image != null)
			{
				cell.ImageView.Frame = new RectangleF(0,0,150,100);
				cell.ImageView.HighlightedImage = info.Image;
				cell.ImageView.Image = info.Image;		
			}
			
			if (info.ContentView != null)
			{
				cell.ContentView.Add(info.ContentView);
			}
			
			// Alternative method is to use AccessoryForRow in the UITableViewDelegate
			if (info.AccessoryView != null)
			{
				cell.AccessoryView = info.AccessoryView;	
			}
			
			return cell;
		}
	}
	
	/// <summary>
	/// Encapsulates a UITableViewCell's different styles
	/// </summary>
	public class LegendItem
	{
		public string DetailText {get;set;}
		public string Text { get; set; }
		public UITableViewCellStyle Style { get; set; }
		public UITableViewCellAccessory Accessory { get; set; }
		
		//
		public UIImage Image { get; set; }
		public UIView ContentView { get;set;}
		public UIView AccessoryView { get;set;}
		
		public LegendItem(string text,string detailtext,UITableViewCellStyle style,UITableViewCellAccessory accessory)
		{
			Text = text;
			DetailText = detailtext;
			Style = style;
			Accessory = accessory;
		}
	}
}