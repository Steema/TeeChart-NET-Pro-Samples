using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chart_Styles_Gauges_LinearGauge : System.Web.UI.Page
{
  protected global::Steema.TeeChart.Web.WebChart WebChart1;
  
  protected void Page_Load(object sender, EventArgs e)
	{
		WebChart1.Chart[0].FillSampleValues();
	}
}