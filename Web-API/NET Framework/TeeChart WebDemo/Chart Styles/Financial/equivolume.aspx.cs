using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Steema.TeeChart;

namespace WebDemo.Chart_Styles.Financial
{
	/// <summary>
	/// Summary description for CandleChart.
	/// </summary>
	public partial class CandleChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.EquiVolume equiVolume1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.Add(equiVolume1 = new Steema.TeeChart.Styles.EquiVolume());
      equiVolume1.XValues.DateTime = true;
      ch1.Legend.Visible = false;
      ch1.Axes.Bottom.Labels.Angle = 90;
      ch1.Axes.Bottom.Increment = 1;
      ch1.Axes.Bottom.Labels.GridIgnoresLabelSize = false;
      ch1.Axes.Bottom.Grid.Visible = false;

      equiVolume1.PointGap = 5;
      equiVolume1.Pointer.Pen.Color = Color.Black;
      equiVolume1.VolumePointer.Pen.Color = Color.Black;

      loadData();

      // Apply palette
      //Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);
    }

    private void loadData()
    {
      //here, for the demo, loading directly from a data array
      for (int i = 0; (i < (int)(ohlcData.Length / 6)); i++)
      {
        equiVolume1.Add(Utils.DateTime(ohlcData[i, 5]),ohlcData[i, 0], ohlcData[i, 1], ohlcData[i, 2], ohlcData[i, 3], ohlcData[i, 4]);
      }
    }

    #region Web Form Designer generated code
    override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
    #endregion

    //Volume,Open,High,Low,Close,DblDate example test data
    static public double[,] ohlcData = new double[54, 6]  {{1175948,7.27,7.27,6.87,7.01,42850},
                                                            {441599,7.05,7.24,7.04,7.11,42851},
                                                            {519489,7.1,7.22,6.95,7.17,42852},
                                                            {219598,7.02,7.25,6.9,6.92,42853},
                                                            {205618,6.65,6.8,6.54,6.7,42857},
                                                            {1502280,6.53,6.6,5.75,5.77,42858},
                                                            {1022003,5.87,5.88,5.49,5.57,42859},
                                                            {1211047,5.51,5.61,5.165,5.21,42860},
                                                            {534698,5.13,5.43,5.08,5.36,42863},
                                                            {621285,5.55,5.55,5.3,5.43,42864},
                                                            {527834,5.47,5.58,5.38,5.46,42865},
                                                            {398630,5.51,5.6701,5.5,5.66,42866},
                                                            {527599,5.69,5.7,5.52,5.59,42867},
                                                            {475590,5.47,5.479,5.29,5.35,42870},
                                                            {399841,5.36,5.37,5.08,5.1,42871},
                                                            {310952,5.08,5.23,4.91,4.94,42872},
                                                            {526454,4.8,5.2,4.7,5.11,42873},
                                                            {188928,5.1,5.28,5.056,5.23,42874},
                                                            {212320,5.26,5.3,5.11,5.24,42877},
                                                            {152023,5.37,5.5,5.25,5.3,42878},
                                                            {182011,5.29,5.46,4.95,4.98,42879},
                                                            {280431,5.06,5.23,5.01,5.22,42880},
                                                            {317526,5.14,5.2,5.05,5.11,42881},
                                                            {285356,5.08,5.2,4.72,4.72,42884},
                                                            {402128,4.67,5.37,4.63,5.36,42885},
                                                            {192657,5.4,5.44,5.23,5.38,42886},
                                                            {330549,5.4,5.75,5.4,5.73,42887},
                                                            {530229,5.76,6.15,5.76,6.02,42888},
                                                            {219108,6.13,6.14,5.62,5.76,42891},
                                                            {178801,5.73,6,5.7,6,42892},
                                                            {161609,6.05,6.13,5.95,6.07,42893},
                                                            {118309,6.01,6.02,5.71,5.91,42894},
                                                            {77727,5.98,5.98,5.73,5.87,42895},
                                                            {152851,5.82,5.82,5.5,5.52,42898},
                                                            {172693,5.55,6.04,5.42,5.99,42899},
                                                            {193770,5.98,5.98,5.64,5.81,42900},
                                                            {104973,5.84,5.84,5.48,5.7,42901},
                                                            {136524,5.82,6.02,5.7608,5.83,42902},
                                                            {253392,5.84,6.12,5.84,6,42905},
                                                            {108773,5.95,6.05,5.84,5.86,42906},
                                                            {492713,5.99,6.41,5.8,6.28,42907},
                                                            {2081637,7.38,8.14,7.3799,8.13,42908},
                                                            {709761,8.08,9,8,8.95,42909},
                                                            {401728,8.73,8.9,8.22,8.22,42912},
                                                            {412103,7.71,8.25,7.54,7.96,42913},
                                                            {358068,8.15,8.54,7.87,8.49,42914},
                                                            {268409,8.64,8.8,8.23,8.69,42915},
                                                            {215531,8.58,8.64,8.41,8.5,42916},
                                                            {268751,8.51,8.6,7.938,8.12,42919},
                                                            {122720,8.19,8.38,7.95,8.28,42920},
                                                            {232505,8.12,8.13,7.64,7.66,42921},
                                                            {119191,7.84,8.13,7.7285,7.98,42922},
                                                            {256311,8.1,8.15,7.84,8.08,42923},
                                                            {327345,8.42,8.78,8.2,8.32,42926}};
  }
}
