using System;

namespace TeeChartBuilder.SeriesData
{
	public class SeriesData
	{
		public SeriesData (bool series3D=false, int x=0, double y=0.0, double z=0, string l="")
		{
			this.XValue = x;
			this.YValue = y;
			if (series3D)
				this.ZValue = z;
			this.Label = l;
		}

		public int XValue { get; set; }
		public double YValue { get; set; }
		public double ZValue { get; set; }
		public string Label { get; set; }
	}
}

