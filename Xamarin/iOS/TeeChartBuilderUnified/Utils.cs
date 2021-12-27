using System;
using Steema.TeeChart.Styles;

namespace TeeChartBuilder
{
	public class Utils
	{
		public static Steema.TeeChart.Styles.Series[] seriesStyles = {
			new Steema.TeeChart.Styles.Line (),
			new Steema.TeeChart.Styles.Points (),
			new Steema.TeeChart.Styles.Area (),
			new Steema.TeeChart.Styles.FastLine (),
			new Steema.TeeChart.Styles.HorizLine (),
			new Steema.TeeChart.Styles.Bar (),
			new Steema.TeeChart.Styles.HorizBar (),
			new Steema.TeeChart.Styles.Pie (),
			new Steema.TeeChart.Styles.Shape (),
			new Steema.TeeChart.Styles.Arrow (),
			new Steema.TeeChart.Styles.Bubble (),
			new Steema.TeeChart.Styles.Gantt (),
			new Steema.TeeChart.Styles.Candle (),
			new Steema.TeeChart.Styles.Donut (),
			new Steema.TeeChart.Styles.Volume (),
			new Steema.TeeChart.Styles.Bar3D (),
			new Steema.TeeChart.Styles.Points3D (),
			new Steema.TeeChart.Styles.Polar (),
			new Steema.TeeChart.Styles.PolarBar (),
			new Steema.TeeChart.Styles.Radar (),
			new Steema.TeeChart.Styles.Clock (),
			new Steema.TeeChart.Styles.WindRose (),
			new Steema.TeeChart.Styles.Pyramid (),
			new Steema.TeeChart.Styles.Surface (),
			new Steema.TeeChart.Styles.LinePoint (),
			new Steema.TeeChart.Styles.BarJoin (),
			new Steema.TeeChart.Styles.ColorGrid (),
			new Steema.TeeChart.Styles.Waterfall (),
			new Steema.TeeChart.Styles.Histogram (),
			new Steema.TeeChart.Styles.Error (),
			new Steema.TeeChart.Styles.ErrorBar (),
			new Steema.TeeChart.Styles.Contour (),
			new Steema.TeeChart.Styles.Smith (),
			new Steema.TeeChart.Styles.Bezier (),
			new Steema.TeeChart.Styles.Calendar (),
			new Steema.TeeChart.Styles.HighLow (),
			new Steema.TeeChart.Styles.TriSurface (),
			new Steema.TeeChart.Styles.Funnel (),
			new Steema.TeeChart.Styles.Box (),
			new Steema.TeeChart.Styles.HorizBox (),
			new Steema.TeeChart.Styles.HorizArea (),
			new Steema.TeeChart.Styles.Tower (),
			new Steema.TeeChart.Styles.PointFigure (),
			new Steema.TeeChart.Styles.Gauges (),
			new Steema.TeeChart.Styles.Vector3D (),
			new Steema.TeeChart.Styles.HorizHistogram (),
			new Steema.TeeChart.Styles.Map (),
			new Steema.TeeChart.Styles.ImageBar (),
			new Steema.TeeChart.Styles.Kagi (),
			new Steema.TeeChart.Styles.Renko (),
			new Steema.TeeChart.Styles.IsoSurface (),
			new Steema.TeeChart.Styles.Darvas (),
			new Steema.TeeChart.Styles.VolumePipe (),
			new Steema.TeeChart.Styles.ImagePoint (),
			new Steema.TeeChart.Styles.CircularGauge (),
			new Steema.TeeChart.Styles.LinearGauge (),
			new Steema.TeeChart.Styles.VerticalLinearGauge (),
			new Steema.TeeChart.Styles.NumericGauge (),
			new Steema.TeeChart.Styles.OrgSeries (),
			new Steema.TeeChart.Styles.TagCloud (),
			new Steema.TeeChart.Styles.PolarGrid (),
			new Steema.TeeChart.Styles.Ternary (),
			new Steema.TeeChart.Styles.KnobGauge (),
			new Steema.TeeChart.Styles.World ()
		};
			
	    public Utils ()
	    {
	    } 

		public static Steema.TeeChart.Styles.Series getSeriesStyle(int index)
	    {
			return Utils.seriesStyles [index];
	    }

	    public void GrabContext()
	    {
			/*
			// Grab The Context
			UIGraphics.BeginImageContext ( this.View.Frame.Size);
			var ctx = UIGraphics.GetCurrentContext ();

			// Render in the context
			this.View.Layer.RenderInContext(ctx);

			// Lets grab a UIImage of the current graphics context
			UIImage i = UIGraphics.GetImageFromCurrentImageContext();

			// Set this to your desktop, ie change the martinbowling part
			string png = "/Users/steema/Desktop/chartxx.png";
			// Get the Image as a PNG
			NSData imgData = i.AsPNG();
			NSError err = null;
			if (imgData.Save(png, false, out err))
			{
				// Console.WriteLine("saved as " + png);
			} 
			else 
			{
				// Console.WriteLine("NOT saved as" + png + 
				//                " because" + err.LocalizedDescription);
			}

			UIGraphics.EndImageContext ();			
			*/								
	    }    
	}
}

