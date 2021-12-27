using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;
using System.Security;
using System.Security.Permissions; 

public partial class Datasets_runtimedata : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {

    if (WebChart1.Chart.Series.Count>0)
      WebChart1.Chart[0].CheckDataSource();

    //string ConnString = SqlDataSource1.ConnectionString; 
    string sQuery = "select * from Employee";

    //SqlConnection myConnection = new SqlConnection(ConnString); 
    string myConnString = @"Driver={Microsoft Access Driver (*.mdb)};Dbq=C:\Program Files\Steema Software\TeeChart for .NET 2009 BETA\Sample data\TeeChart.mdb;Uid=Admin;Pwd=;";
    System.Data.Odbc.OdbcConnection myConnection = new System.Data.Odbc.OdbcConnection(myConnString);

    //SqlCommand myCommand = new SqlCommand(sQuery, myConnection); 
    System.Data.Odbc.OdbcCommand myCommand = new System.Data.Odbc.OdbcCommand(sQuery, myConnection);
    myConnection.Open();

    //SqlDataReader myReader = myCommand.ExecuteReader(); 
    System.Data.Odbc.OdbcDataReader myReader = myCommand.ExecuteReader();

    int XColumn = myReader.GetOrdinal("ID");
    int YColumn = myReader.GetOrdinal("SALARY");
    int LabelColumn = myReader.GetOrdinal("LASTNAME");

    WebChart1.Chart[0].Clear();

    while (myReader.Read())
    {
      WebChart1.Chart[0].Add(Convert.ToInt32(myReader[XColumn]), Convert.ToDouble(myReader[YColumn]), Convert.ToString(myReader[LabelColumn]));
    }

    myReader.Close();
    myConnection.Close(); 

  }
}
