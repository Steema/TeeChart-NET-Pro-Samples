using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Datasets_designtime : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    WebChart1.Chart[0].CheckDataSource();
  }
}
