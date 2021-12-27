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
using System.IO;
using System.Data.OleDb;
using System.Security.Permissions;
using Steema.TeeChart;

namespace WebDemo.Interactive_Charting.TeeMapWeb
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public partial class WebForm1 : System.Web.UI.Page
	{

		protected Steema.TeeChart.Tools.SeriesHotspot seriesHotspot1;
		protected Steema.TeeChart.Chart tChart1;
		protected Steema.TeeChart.Styles.Map map1;
		protected Steema.TeeChart.Styles.Points points1;
		private TeeSHP teeSHP;
		
		private string path;
		private Random rnd = new Random();
		private DataTable Table1;
		private string TextBox1;
		private string TextBox2;
		protected Steema.TeeChart.Data.TextSource textSource1;
		private string MapType;
		public  System.Text.StringBuilder stb1;
		protected Steema.TeeChart.Tools.ZoomTool zoomTool1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{			
			string winmap=Request.QueryString["winmap"];
			if ((winmap!=null))
			{
				comboBox1.SelectedIndex=Convert.ToInt32(Request.QueryString["winmap"]);
			}
			
			comboBox1_SelectedIndexChanged(null, null);
			((Steema.TeeChart.Tools.ZoomTool)WebChart1.Chart.Tools[0]).CustomVariables="&winmap="+comboBox1.SelectedIndex.ToString();

      map1.ColorEach = true;

      //check whether zoom request is being sent
      CheckZoom(WebChart1);
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);

			tChart1=WebChart1.Chart; 
			map1 = new Steema.TeeChart.Styles.Map(tChart1);
			points1 = new Steema.TeeChart.Styles.Points(tChart1);
			points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			points1.Pointer.HorizSize = 2;
			points1.Pointer.VertSize = 2;			

			seriesHotspot1 = new Steema.TeeChart.Tools.SeriesHotspot(tChart1);
			seriesHotspot1.MapAction  = Steema.TeeChart.Styles.MapAction.Mark;
			seriesHotspot1.Style = Steema.TeeChart.Styles.MarksStyles.Label;
			
			path = Request.PhysicalApplicationPath + @"Interacting with Charts\Mapping\";

			
			if(File.Exists(path+@"Maps\World.shp")) 
			{
				comboBox1.Items.Add(@"Maps\World");
				if(File.Exists(path+@"Maps\USAStates.shp")) 
					comboBox1.Items.Add(@"Maps\USAStates");

				comboBox1.SelectedIndex = 0;
			}
			
			textSource1.Series = points1;
			textSource1.Fields.Add(0, "text");
			textSource1.Fields.Add(1, "X");
			textSource1.Fields.Add(2, "Y");
			textSource1.DecimalSeparator = ',';
			textSource1.Separator = ';';

			
			teeSHP = new TeeSHP(path);

			tChart1.Aspect.View3D = false;
			tChart1.Axes.Left.SetMinMax(-90,90);
			tChart1.Axes.Left.Labels.ValueFormat = "0º";
			tChart1.Axes.Bottom.SetMinMax(-180,180);
			tChart1.Axes.Bottom.Labels.ValueFormat = "0º";
			tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
			points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None;
			points1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.None;

		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.textSource1 = new Steema.TeeChart.Data.TextSource();
			this.zoomTool1 = new Steema.TeeChart.Tools.ZoomTool();
			// 
			// textSource1
			// 
			this.textSource1.DecimalSeparator = ',';
			this.textSource1.Series = null;
			// 
			// zoomTool1
			// 
			this.zoomTool1.CustomVariables = "";
			this.zoomTool1.ZoomCanvasIndex = 499;
			this.zoomTool1.ZoomPenColor = System.Drawing.Color.Red;

		}
		#endregion


		private void SendInfo() 
		{
			TextBox1 = textBox1.Text;
			TextBox2 = textBox2.Text;
			MapType = comboBox1.SelectedItem.Text;
		}

		private void CheckZoom(Steema.TeeChart.Web.WebChart wChart)
		{
			ArrayList zoomedState=(ArrayList)Session[wChart.ID+"Zoomed"];
			zoomedState=((Steema.TeeChart.Tools.ZoomTool)wChart.Chart.Tools[0]).SetCurrentZoom(Request,
				zoomedState);
			if (zoomedState==null)
				Session.Remove(wChart.ID+"Zoomed");
			else
				Session.Add(wChart.ID+"Zoomed",zoomedState);
		}


		private void LoadChart() 
		{	
			TryLoadTable();
			teeSHP.LoadMap(map1, MapType, Table1, TextBox1, TextBox2, null);
			

			if(MapType==@"Maps\USAStates") 
			{
				tChart1.Axes.Left.SetMinMax(24,50);
				tChart1.Axes.Bottom.SetMinMax(-125,-67);
				points1.Clear();
				textSource1.LoadFromFile(path+@"Maps/USACities.txt");
			}
			else 
			{
				tChart1.Axes.Left.SetMinMax(-90,90);
				tChart1.Axes.Bottom.SetMinMax(-180,180);
				points1.Clear();
				textSource1.LoadFromFile(path+@"Maps/WorldCities.txt");
			}

			map1.UseColorRange=false;
			map1.UsePalette = true;
			map1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong;
		}

		private void TryLoadTable() 
		{
			DataSet masterDataSet = new DataSet();
			string dataPath = path+@"Maps\Coordinates.mdb";
			string tableName = MapType;
			tableName = tableName.Remove(0,5);

			OpenConnWithJet40(ref masterDataSet, dataPath, tableName);

			Table1 = masterDataSet.Tables[tableName];

		}

		[OleDbPermissionAttribute(SecurityAction.Demand) /*, Provider="Microsoft.Jet.OLEDB.4.0")*/] 
		private void OpenConnWithJet40(ref DataSet MasterDataSet, string DataPath, string TableName) 
		{         
			OleDbConnection testConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +             
				@"Data Source=" + DataPath +";");          
			testConn.Open();         
			string strCom = "SELECT * FROM " + TableName;          
			OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom,testConn);         
			myCommand.Fill(MasterDataSet,TableName);         
			testConn.Close(); 
		}

		protected void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(comboBox1.SelectedIndex) 
			{
				case 0:
					textBox1.Text="CNTRY_NAME"; 
					textBox2.Text="POP_CNTRY";
					tChart1.Header.Text = "The World";
					map1.Title = "Countries";
					points1.Title = "Cities";
					break;
				case 1:
					textBox1.Text="STATE"; 
					textBox2.Text="";
					tChart1.Header.Text = "The United States of America";
					map1.Title = "States";
					points1.Title = "Cities";
					break;
			}

			SendInfo();
			if(File.Exists(path+@"Maps\World.shp")) 
			{
				LoadChart();
			}		
		}


	}
}
