namespace DashBoard
{
  partial class ReportForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
			Steema.TeeGrid.Data.DB.VirtualDBData virtualDBData1 = new Steema.TeeGrid.Data.DB.VirtualDBData();
			Steema.TeeGrid.WinForm.Painter.GdiPlusPainter gdiPlusPainter1 = new Steema.TeeGrid.WinForm.Painter.GdiPlusPainter();
			Steema.TeeGrid.RowGroup.GridScrolling gridScrolling1 = new Steema.TeeGrid.RowGroup.GridScrolling();
			this.techProductsLtdDataSet1 = new DashBoard.TechProductsLtdDataSet();
			this.bindingSourceSbyC = new System.Windows.Forms.BindingSource(this.components);
			this.___SalesByCountry_2015TableAdapter = new DashBoard.TechProductsLtdDataSetTableAdapters.@__SalesByCountry_2015TableAdapter();
			this.sumOfInvoiceValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countrynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.continentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceSbyCo = new System.Windows.Forms.BindingSource(this.components);
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.SteemaDash = new System.Windows.Forms.Label();
			this.SalesPer = new System.Windows.Forms.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.Export = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.LBBetween = new System.Windows.Forms.Label();
			this.LBTotalSalesCountryBT = new System.Windows.Forms.Label();
			this.LBTotalSalesCountryBTValue = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.LBTotalSalesCountryValue = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.LBTotalItemsSold = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.LBTotalSales = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.bindingSourceSbyYCo = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.bindingSource_Orders = new System.Windows.Forms.BindingSource(this.components);
			this.___SalesByYearContinentTableAdapter = new DashBoard.TechProductsLtdDataSetTableAdapters.@__SalesByYearContinentTableAdapter();
			this.___SalesByContinentTableAdapter = new DashBoard.TechProductsLtdDataSetTableAdapters.@__SalesByContinentTableAdapter();
			this.___SalesByCountryTableAdapter = new DashBoard.TechProductsLtdDataSetTableAdapters.@__SalesByCountryTableAdapter();
			this.lookup_CountryTableAdapter = new DashBoard.TechProductsLtdDataSetTableAdapters.Lookup_CountryTableAdapter();
			this.fact_OrdersTableAdapter = new DashBoard.TechProductsLtdDataSetTableAdapters.Fact_OrdersTableAdapter();
			this.bindingSourceContinents = new System.Windows.Forms.BindingSource(this.components);
			this.lookup_ContinentTableAdapter = new DashBoard.TechProductsLtdDataSetTableAdapters.Lookup_ContinentTableAdapter();
			this.DonutTimer = new System.Windows.Forms.Timer(this.components);
			this.tChart1 = new Steema.TeeChart.TChart();
			this.area1 = new Steema.TeeChart.Styles.Area();
			this.vertCursorTool = new Steema.TeeChart.Tools.CursorTool();
			this.horizCursorTool = new Steema.TeeChart.Tools.CursorTool();
			this.annVert = new Steema.TeeChart.Tools.Annotation();
			this.annHoriz = new Steema.TeeChart.Tools.Annotation();
			this.tChart2 = new Steema.TeeChart.TChart();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.bar2 = new Steema.TeeChart.Styles.Bar();
			this.marksTip1 = new Steema.TeeChart.Tools.MarksTip();
			this.tChart3 = new Steema.TeeChart.TChart();
			this.donut1 = new Steema.TeeChart.Styles.Donut();
			this.marksTip2 = new Steema.TeeChart.Tools.MarksTip();
			this.tChart4 = new Steema.TeeChart.TChart();
			this.world1 = new Steema.TeeChart.Styles.World();
			this.TeeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
			((System.ComponentModel.ISupportInitialize)(this.techProductsLtdDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSbyC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSbyCo)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSbyYCo)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_Orders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceContinents)).BeginInit();
			this.SuspendLayout();
			// 
			// techProductsLtdDataSet1
			// 
			this.techProductsLtdDataSet1.DataSetName = "TechProductsLtdDataSet";
			this.techProductsLtdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingSourceSbyC
			// 
			this.bindingSourceSbyC.DataMember = "$_SalesByCountry_2015";
			this.bindingSourceSbyC.DataSource = this.techProductsLtdDataSet1;
			// 
			// ___SalesByCountry_2015TableAdapter
			// 
			this.___SalesByCountry_2015TableAdapter.ClearBeforeFill = true;
			// 
			// sumOfInvoiceValueDataGridViewTextBoxColumn
			// 
			this.sumOfInvoiceValueDataGridViewTextBoxColumn.DataPropertyName = "SumOfInvoice_Value";
			this.sumOfInvoiceValueDataGridViewTextBoxColumn.HeaderText = "SumOfInvoice_Value";
			this.sumOfInvoiceValueDataGridViewTextBoxColumn.Name = "sumOfInvoiceValueDataGridViewTextBoxColumn";
			// 
			// countrynameDataGridViewTextBoxColumn
			// 
			this.countrynameDataGridViewTextBoxColumn.DataPropertyName = "Country_name";
			this.countrynameDataGridViewTextBoxColumn.HeaderText = "Country_name";
			this.countrynameDataGridViewTextBoxColumn.Name = "countrynameDataGridViewTextBoxColumn";
			// 
			// continentnameDataGridViewTextBoxColumn
			// 
			this.continentnameDataGridViewTextBoxColumn.DataPropertyName = "continent_name";
			this.continentnameDataGridViewTextBoxColumn.HeaderText = "continent_name";
			this.continentnameDataGridViewTextBoxColumn.Name = "continentnameDataGridViewTextBoxColumn";
			// 
			// bindingSourceSbyCo
			// 
			this.bindingSourceSbyCo.DataMember = "$_SalesByContinent";
			this.bindingSourceSbyCo.DataSource = this.techProductsLtdDataSet1;
			this.bindingSourceSbyCo.Filter = "";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.flowLayoutPanel1.Controls.Add(this.SteemaDash);
			this.flowLayoutPanel1.Controls.Add(this.SalesPer);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1336, 50);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// SteemaDash
			// 
			this.SteemaDash.AutoSize = true;
			this.SteemaDash.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SteemaDash.ForeColor = System.Drawing.Color.DimGray;
			this.SteemaDash.Location = new System.Drawing.Point(3, 0);
			this.SteemaDash.Name = "SteemaDash";
			this.SteemaDash.Size = new System.Drawing.Size(355, 29);
			this.SteemaDash.TabIndex = 27;
			this.SteemaDash.Text = "Steema DashBoard Components";
			// 
			// SalesPer
			// 
			this.SalesPer.AutoSize = true;
			this.SalesPer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SalesPer.ForeColor = System.Drawing.Color.DimGray;
			this.SalesPer.Location = new System.Drawing.Point(3, 29);
			this.SalesPer.Name = "SalesPer";
			this.SalesPer.Size = new System.Drawing.Size(222, 19);
			this.SalesPer.TabIndex = 31;
			this.SalesPer.Text = "Sales Performance by Country";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel3.BackgroundImage")));
			this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.flowLayoutPanel3.Controls.Add(this.Export);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 695);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(1336, 50);
			this.flowLayoutPanel3.TabIndex = 3;
			this.flowLayoutPanel3.WrapContents = false;
			// 
			// Export
			// 
			this.Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.Export.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Export.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.Export.Location = new System.Drawing.Point(1186, 3);
			this.Export.Name = "Export";
			this.Export.Size = new System.Drawing.Size(147, 47);
			this.Export.TabIndex = 0;
			this.Export.Text = "Export to web";
			this.Export.UseVisualStyleBackColor = false;
			this.Export.Click += new System.EventHandler(this.Export_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1336, 114);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.panel4.Controls.Add(this.LBBetween);
			this.panel4.Controls.Add(this.LBTotalSalesCountryBT);
			this.panel4.Controls.Add(this.LBTotalSalesCountryBTValue);
			this.panel4.Controls.Add(this.pictureBox5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(1005, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(328, 108);
			this.panel4.TabIndex = 3;
			// 
			// LBBetween
			// 
			this.LBBetween.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LBBetween.AutoSize = true;
			this.LBBetween.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBBetween.Location = new System.Drawing.Point(113, 85);
			this.LBBetween.Name = "LBBetween";
			this.LBBetween.Size = new System.Drawing.Size(212, 23);
			this.LBBetween.TabIndex = 7;
			this.LBBetween.Text = "between 0000 and 9999";
			this.LBBetween.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// LBTotalSalesCountryBT
			// 
			this.LBTotalSalesCountryBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LBTotalSalesCountryBT.AutoSize = true;
			this.LBTotalSalesCountryBT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBTotalSalesCountryBT.Location = new System.Drawing.Point(160, 36);
			this.LBTotalSalesCountryBT.Name = "LBTotalSalesCountryBT";
			this.LBTotalSalesCountryBT.Size = new System.Drawing.Size(77, 23);
			this.LBTotalSalesCountryBT.TabIndex = 6;
			this.LBTotalSalesCountryBT.Text = "Sales In";
			this.LBTotalSalesCountryBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LBTotalSalesCountryBTValue
			// 
			this.LBTotalSalesCountryBTValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LBTotalSalesCountryBTValue.AutoSize = true;
			this.LBTotalSalesCountryBTValue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBTotalSalesCountryBTValue.Location = new System.Drawing.Point(159, 11);
			this.LBTotalSalesCountryBTValue.Name = "LBTotalSalesCountryBTValue";
			this.LBTotalSalesCountryBTValue.Size = new System.Drawing.Size(51, 25);
			this.LBTotalSalesCountryBTValue.TabIndex = 4;
			this.LBTotalSalesCountryBTValue.Text = "0.00";
			this.LBTotalSalesCountryBTValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(71, 108);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox5.TabIndex = 1;
			this.pictureBox5.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.LBTotalSalesCountryValue);
			this.panel3.Controls.Add(this.pictureBox4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(671, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(328, 108);
			this.panel3.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(156, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Total Sales In";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LBTotalSalesCountryValue
			// 
			this.LBTotalSalesCountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LBTotalSalesCountryValue.AutoSize = true;
			this.LBTotalSalesCountryValue.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBTotalSalesCountryValue.Location = new System.Drawing.Point(155, 21);
			this.LBTotalSalesCountryValue.Name = "LBTotalSalesCountryValue";
			this.LBTotalSalesCountryValue.Size = new System.Drawing.Size(51, 25);
			this.LBTotalSalesCountryValue.TabIndex = 3;
			this.LBTotalSalesCountryValue.Text = "0.00";
			this.LBTotalSalesCountryValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(71, 108);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.LBTotalItemsSold);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(337, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(328, 108);
			this.panel2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(161, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Total Items Sold";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// LBTotalItemsSold
			// 
			this.LBTotalItemsSold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LBTotalItemsSold.AutoSize = true;
			this.LBTotalItemsSold.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBTotalItemsSold.Location = new System.Drawing.Point(160, 21);
			this.LBTotalItemsSold.Name = "LBTotalItemsSold";
			this.LBTotalItemsSold.Size = new System.Drawing.Size(51, 25);
			this.LBTotalItemsSold.TabIndex = 3;
			this.LBTotalItemsSold.Text = "0.00";
			this.LBTotalItemsSold.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(71, 108);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.LBTotalSales);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 108);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(159, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Total Sales";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// LBTotalSales
			// 
			this.LBTotalSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LBTotalSales.AutoSize = true;
			this.LBTotalSales.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBTotalSales.Location = new System.Drawing.Point(158, 21);
			this.LBTotalSales.Name = "LBTotalSales";
			this.LBTotalSales.Size = new System.Drawing.Size(51, 25);
			this.LBTotalSales.TabIndex = 2;
			this.LBTotalSales.Text = "0.00";
			this.LBTotalSales.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(71, 108);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 164);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.42138F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.57862F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1336, 531);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33778F));
			this.tableLayoutPanel3.Controls.Add(this.tChart1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tChart2, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.tChart3, 2, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1330, 192);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// bindingSourceSbyYCo
			// 
			this.bindingSourceSbyYCo.DataMember = "$_SalesByYearContinent";
			this.bindingSourceSbyYCo.DataSource = this.techProductsLtdDataSet1;
			this.bindingSourceSbyYCo.Filter = "";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
			this.tableLayoutPanel4.Controls.Add(this.panel6, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.panel7, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 201);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1330, 327);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Controls.Add(this.tChart4);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(601, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(726, 321);
			this.panel6.TabIndex = 14;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.White;
			this.panel7.Controls.Add(this.TeeGrid1);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(3, 3);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(592, 321);
			this.panel7.TabIndex = 15;
			// 
			// bindingSource_Orders
			// 
			this.bindingSource_Orders.AllowNew = true;
			this.bindingSource_Orders.DataMember = "Fact_Orders";
			this.bindingSource_Orders.DataSource = this.techProductsLtdDataSet1;
			// 
			// ___SalesByYearContinentTableAdapter
			// 
			this.___SalesByYearContinentTableAdapter.ClearBeforeFill = true;
			// 
			// ___SalesByContinentTableAdapter
			// 
			this.___SalesByContinentTableAdapter.ClearBeforeFill = true;
			// 
			// ___SalesByCountryTableAdapter
			// 
			this.___SalesByCountryTableAdapter.ClearBeforeFill = true;
			// 
			// lookup_CountryTableAdapter
			// 
			this.lookup_CountryTableAdapter.ClearBeforeFill = true;
			// 
			// fact_OrdersTableAdapter
			// 
			this.fact_OrdersTableAdapter.ClearBeforeFill = true;
			// 
			// bindingSourceContinents
			// 
			this.bindingSourceContinents.DataMember = "Lookup_Continent";
			this.bindingSourceContinents.DataSource = this.techProductsLtdDataSet1;
			// 
			// lookup_ContinentTableAdapter
			// 
			this.lookup_ContinentTableAdapter.ClearBeforeFill = true;
			// 
			// DonutTimer
			// 
			this.DonutTimer.Enabled = true;
			this.DonutTimer.Interval = 1000;
			// 
			// tChart1
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// 
			// 
			this.tChart1.Header.Alignment = System.Drawing.StringAlignment.Near;
			// 
			// 
			// 
			this.tChart1.Header.Font.Name = "Tahoma";
			this.tChart1.Header.Font.Size = 11;
			this.tChart1.Header.Font.SizeFloat = 11F;
			this.tChart1.Header.Lines = new string[] {
        "Sales by Country"};
			this.tChart1.Header.TextAlign = System.Drawing.StringAlignment.Center;
			// 
			// 
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(3, 3);
			this.tChart1.Name = "tChart1";
			// 
			// 
			// 
			this.tChart1.Panel.MarginLeft = 5D;
			this.tChart1.Series.Add(this.area1);
			this.tChart1.Size = new System.Drawing.Size(437, 186);
			this.tChart1.TabIndex = 0;
			this.tChart1.Tools.Add(this.vertCursorTool);
			this.tChart1.Tools.Add(this.horizCursorTool);
			this.tChart1.Tools.Add(this.annVert);
			this.tChart1.Tools.Add(this.annHoriz);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			this.tChart1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseDoubleClick);
			// 
			// area1
			// 
			// 
			// 
			// 
			this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
			// 
			// 
			// 
			this.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
			// 
			// 
			// 
			this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
			this.area1.AreaLines.Visible = false;
			// 
			// 
			// 
			this.area1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
			this.area1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
			this.area1.ColorEach = false;
			// 
			// 
			// 
			this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
			this.area1.LinePen.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.area1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.area1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.area1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.area1.Marks.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.area1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			// 
			// 
			// 
			this.area1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
			// 
			// 
			// 
			this.area1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
			this.area1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
			this.area1.Marks.TailParams.Margin = 0F;
			this.area1.Marks.TailParams.PointerHeight = 5D;
			this.area1.Marks.TailParams.PointerWidth = 8D;
			this.area1.OriginalCursor = null;
			// 
			// 
			// 
			this.area1.Pointer.SizeDouble = 0D;
			this.area1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
			this.area1.Title = "area1";
			this.area1.UseExtendedNumRange = false;
			// 
			// 
			// 
			this.area1.XValues.DataMember = "X";
			this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.area1.YValues.DataMember = "Y";
			// 
			// vertCursorTool
			// 
			this.vertCursorTool.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
			// 
			// horizCursorTool
			// 
			this.horizCursorTool.Style = Steema.TeeChart.Tools.CursorToolStyles.Horizontal;
			// 
			// annVert
			// 
			this.annVert.Active = false;
			this.annVert.AutoSize = true;
			// 
			// 
			// 
			this.annVert.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.annVert.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
			this.annVert.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.annVert.Callout.Brush.Color = System.Drawing.Color.Black;
			this.annVert.Callout.Distance = 0;
			this.annVert.Callout.Draw3D = false;
			this.annVert.Callout.SizeDouble = 0D;
			this.annVert.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
			this.annVert.Callout.XPosition = 0;
			this.annVert.Callout.YPosition = 0;
			this.annVert.Callout.ZPosition = 0;
			this.annVert.Cursor = System.Windows.Forms.Cursors.Default;
			// 
			// annHoriz
			// 
			this.annHoriz.Active = false;
			this.annHoriz.AutoSize = true;
			// 
			// 
			// 
			this.annHoriz.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.annHoriz.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
			this.annHoriz.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.annHoriz.Callout.Brush.Color = System.Drawing.Color.Black;
			this.annHoriz.Callout.Distance = 0;
			this.annHoriz.Callout.Draw3D = false;
			this.annHoriz.Callout.SizeDouble = 0D;
			this.annHoriz.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
			this.annHoriz.Callout.XPosition = 0;
			this.annHoriz.Callout.YPosition = 0;
			this.annHoriz.Callout.ZPosition = 0;
			this.annHoriz.Cursor = System.Windows.Forms.Cursors.Default;
			// 
			// tChart2
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart2.Axes.Top.Labels.Style = Steema.TeeChart.AxisLabelStyle.Text;
			this.tChart2.BackColor = System.Drawing.Color.Transparent;
			this.tChart2.Cursor = System.Windows.Forms.Cursors.Default;
			this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// 
			// 
			this.tChart2.Header.Alignment = System.Drawing.StringAlignment.Near;
			// 
			// 
			// 
			this.tChart2.Header.Font.Name = "Tahoma";
			this.tChart2.Header.Font.Size = 11;
			this.tChart2.Header.Font.SizeFloat = 11F;
			this.tChart2.Header.Lines = new string[] {
        "Total Continent Sales"};
			this.tChart2.Header.TextAlign = System.Drawing.StringAlignment.Center;
			// 
			// 
			// 
			this.tChart2.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
			// 
			// 
			// 
			this.tChart2.Legend.Font.Name = "Tahoma";
			this.tChart2.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series;
			// 
			// 
			// 
			this.tChart2.Legend.Symbol.Squared = true;
			this.tChart2.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.Plain;
			this.tChart2.Location = new System.Drawing.Point(446, 3);
			this.tChart2.Name = "tChart2";
			// 
			// 
			// 
			this.tChart2.Panel.MarginLeft = 5D;
			this.tChart2.Series.Add(this.bar1);
			this.tChart2.Series.Add(this.bar2);
			this.tChart2.Size = new System.Drawing.Size(437, 186);
			this.tChart2.TabIndex = 1;
			this.tChart2.Tools.Add(this.marksTip1);
			this.tChart2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tChart2_MouseDoubleClick);
			// 
			// bar1
			// 
			this.bar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
			this.bar1.BarWidthPercent = 85;
			// 
			// 
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
			this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
			this.bar1.ColorEach = false;
			this.bar1.DataSource = this.bindingSourceSbyCo;
			this.bar1.LabelMember = "continent_name";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.bar1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bar1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bar1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.bar1.Marks.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.bar1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			// 
			// 
			// 
			this.bar1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
			this.bar1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.LabelValue;
			// 
			// 
			// 
			this.bar1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
			this.bar1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
			this.bar1.Marks.TailParams.Margin = 0F;
			this.bar1.Marks.TailParams.PointerHeight = 5D;
			this.bar1.Marks.TailParams.PointerWidth = 8D;
			this.bar1.Marks.Visible = false;
			this.bar1.OriginalCursor = System.Windows.Forms.Cursors.Default;
			// 
			// 
			// 
			this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
			this.bar1.Pen.Visible = false;
			this.bar1.Title = "All";
			this.bar1.UseExtendedNumRange = false;
			// 
			// 
			// 
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.bar1.YValues.DataMember = "SumOfInvoice_Value";
			// 
			// bar2
			// 
			this.bar2.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
			// 
			// 
			// 
			this.bar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
			this.bar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
			this.bar2.ColorEach = false;
			this.bar2.DataSource = this.bindingSourceSbyYCo;
			this.bar2.LabelMember = "continent_name";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.bar2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bar2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bar2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.bar2.Marks.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.bar2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			// 
			// 
			// 
			this.bar2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
			// 
			// 
			// 
			this.bar2.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
			this.bar2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
			this.bar2.Marks.TailParams.Margin = 0F;
			this.bar2.Marks.TailParams.PointerHeight = 5D;
			this.bar2.Marks.TailParams.PointerWidth = 8D;
			this.bar2.Marks.Visible = false;
			this.bar2.OriginalCursor = null;
			// 
			// 
			// 
			this.bar2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(62)))));
			this.bar2.Pen.Visible = false;
			this.bar2.Title = "Year Selected";
			this.bar2.UseExtendedNumRange = false;
			// 
			// 
			// 
			this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.bar2.YValues.DataMember = "SumOfInvoice_Value";
			// 
			// marksTip1
			// 
			this.marksTip1.MouseAction = Steema.TeeChart.Tools.MarksTipMouseAction.Click;
			this.marksTip1.Style = Steema.TeeChart.Styles.MarksStyles.LabelValue;
			// 
			// tChart3
			// 
			// 
			// 
			// 
			this.tChart3.Aspect.Orthogonal = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart3.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart3.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart3.BackColor = System.Drawing.Color.Transparent;
			this.tChart3.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// 
			// 
			this.tChart3.Header.Alignment = System.Drawing.StringAlignment.Near;
			// 
			// 
			// 
			this.tChart3.Header.Font.Name = "Tahoma";
			this.tChart3.Header.Font.Size = 11;
			this.tChart3.Header.Font.SizeFloat = 11F;
			this.tChart3.Header.Lines = new string[] {
        "Countries by Continent"};
			this.tChart3.Header.TextAlign = System.Drawing.StringAlignment.Center;
			// 
			// 
			// 
			this.tChart3.Legend.Visible = false;
			this.tChart3.Location = new System.Drawing.Point(889, 3);
			this.tChart3.Name = "tChart3";
			// 
			// 
			// 
			this.tChart3.Panel.MarginBottom = 2D;
			this.tChart3.Panel.MarginLeft = 1D;
			this.tChart3.Panel.MarginRight = 1D;
			this.tChart3.Panel.MarginTop = 2D;
			this.tChart3.Series.Add(this.donut1);
			this.tChart3.Size = new System.Drawing.Size(438, 186);
			this.tChart3.TabIndex = 2;
			this.tChart3.Tools.Add(this.marksTip2);
			this.tChart3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tChart3_MouseDoubleClick);
			// 
			// donut1
			// 
			// 
			// 
			// 
			this.donut1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(144)))));
			this.donut1.Circled = true;
			this.donut1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
			this.donut1.DataSource = this.bindingSourceSbyC;
			// 
			// 
			// 
			this.donut1.Frame.Circled = true;
			this.donut1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
			// 
			// 
			// 
			// 
			// 
			// 
			this.donut1.Frame.OuterBand.Gradient.UseMiddle = false;
			this.donut1.LabelMember = "Country_name";
			// 
			// 
			// 
			// 
			// 
			// 
			this.donut1.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.donut1.Marks.ArrowLength = 10;
			// 
			// 
			// 
			// 
			// 
			// 
			this.donut1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.donut1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.donut1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.donut1.Marks.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.donut1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			// 
			// 
			// 
			this.donut1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(124)))), ((int)(((byte)(174)))));
			// 
			// 
			// 
			this.donut1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
			this.donut1.Marks.TailParams.CustomPoint = true;
			this.donut1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos3")));
			this.donut1.Marks.TailParams.Margin = 2F;
			this.donut1.Marks.TailParams.PointerHeight = 5D;
			this.donut1.Marks.TailParams.PointerWidth = 8D;
			// 
			// 
			// 
			this.donut1.MarksPie.InsideSlice = false;
			this.donut1.MarksPie.LegSize = 0;
			this.donut1.MarksPie.Rotated = false;
			this.donut1.MarksPie.RotateStyle = Steema.TeeChart.Styles.Pie.MarksRotateStyle.Radial;
			this.donut1.MarksPie.VertCenter = false;
			this.donut1.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
			this.donut1.OriginalCursor = null;
			// 
			// 
			// 
			this.donut1.OtherSlice.Color = System.Drawing.Color.Empty;
			this.donut1.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
			this.donut1.OtherSlice.Text = "";
			this.donut1.OtherSlice.Value = 0D;
			this.donut1.Title = "donut1";
			this.donut1.UniqueCustomRadius = true;
			this.donut1.UseExtendedNumRange = false;
			// 
			// 
			// 
			this.donut1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.donut1.YValues.DataMember = "SumOfInvoice_Value";
			// 
			// marksTip2
			// 
			this.marksTip2.MouseAction = Steema.TeeChart.Tools.MarksTipMouseAction.Click;
			this.marksTip2.Style = Steema.TeeChart.Styles.MarksStyles.LabelValue;
			// 
			// tChart4
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart4.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart4.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart4.Axes.Visible = false;
			this.tChart4.BackColor = System.Drawing.Color.Transparent;
			this.tChart4.Cursor = System.Windows.Forms.Cursors.Default;
			this.tChart4.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// 
			// 
			this.tChart4.Header.Alignment = System.Drawing.StringAlignment.Near;
			// 
			// 
			// 
			this.tChart4.Header.Font.Name = "Tahoma";
			this.tChart4.Header.Font.Size = 11;
			this.tChart4.Header.Font.SizeFloat = 11F;
			this.tChart4.Header.Lines = new string[] {
        "Sales by Continent"};
			this.tChart4.Header.TextAlign = System.Drawing.StringAlignment.Center;
			// 
			// 
			// 
			this.tChart4.Legend.Visible = false;
			this.tChart4.Location = new System.Drawing.Point(0, 0);
			this.tChart4.Name = "tChart4";
			this.tChart4.Series.Add(this.world1);
			this.tChart4.Size = new System.Drawing.Size(726, 321);
			this.tChart4.TabIndex = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart4.Walls.Left.Visible = false;
			this.tChart4.Walls.Visible = false;
			// 
			// 
			// 
			this.tChart4.Zoom.MinPixels = 18;
			this.tChart4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tChart4_MouseDoubleClick);
			// 
			// world1
			// 
			// 
			// 
			// 
			this.world1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(181)))), ((int)(((byte)(223)))));
			this.world1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
			this.world1.ColorEach = false;
			this.world1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
			this.world1.Map = Steema.TeeChart.Styles.WorldMapType.World;
			// 
			// 
			// 
			this.world1.MapMarks.AutoSize = true;
			this.world1.MapMarks.Centroid = true;
			this.world1.MapMarks.TextStyle = Steema.TeeChart.Styles.MapMarksText.Label;
			this.world1.MapMarks.UpperCase = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.world1.Marks.Brush.Visible = false;
			this.world1.Marks.Clip = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.world1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.world1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Label;
			// 
			// 
			// 
			this.world1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
			this.world1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos4")));
			this.world1.Marks.TailParams.Margin = 0F;
			this.world1.Marks.TailParams.PointerHeight = 8D;
			this.world1.Marks.TailParams.PointerWidth = 8D;
			this.world1.Marks.Visible = true;
			this.world1.OriginalCursor = System.Windows.Forms.Cursors.Default;
			this.world1.PaletteMin = 0D;
			this.world1.PaletteStep = 0D;
			this.world1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
			// 
			// 
			// 
			this.world1.Pen.Visible = false;
			// 
			// 
			// 
			this.world1.Pointer.SizeDouble = 0.1D;
			this.world1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Axis;
			this.world1.PointSize = 0.1D;
			this.world1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(146)))), ((int)(((byte)(210)))));
			this.world1.Title = "worldMap1";
			this.world1.UseExtendedNumRange = false;
			// 
			// 
			// 
			this.world1.ZValues.DataMember = "Z";
			// 
			// TeeGrid1
			// 
			this.TeeGrid1.BackColor = System.Drawing.Color.White;
			virtualDBData1.ValidBlobBase64 = "";
			this.TeeGrid1.Data = virtualDBData1;
			this.TeeGrid1.DataSource = this.bindingSource_Orders;
			this.TeeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TeeGrid1.Location = new System.Drawing.Point(0, 0);
			this.TeeGrid1.Name = "TeeGrid1";
			this.TeeGrid1.Painter = gdiPlusPainter1;
			gridScrolling1.Horizontal = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			gridScrolling1.Mode = Steema.TeeGrid.RowGroup.ScrollingMode.Touch;
			gridScrolling1.Vertical = Steema.TeeGrid.RowGroup.ScrollDirection.Normal;
			this.TeeGrid1.Scrolling = gridScrolling1;
			this.TeeGrid1.Size = new System.Drawing.Size(592, 321);
			this.TeeGrid1.SortableColumns = true;
			this.TeeGrid1.TabIndex = 13;
			// 
			// ReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1336, 745);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.flowLayoutPanel3);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ReportForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ReportForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.techProductsLtdDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSbyC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSbyCo)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSbyYCo)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_Orders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceContinents)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion
    private TechProductsLtdDataSet techProductsLtdDataSet1;
    private System.Windows.Forms.BindingSource bindingSourceSbyC;
    private TechProductsLtdDataSetTableAdapters.__SalesByCountry_2015TableAdapter ___SalesByCountry_2015TableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn sumOfInvoiceValueDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn countrynameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn continentnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource bindingSourceSbyCo;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private Steema.TeeGrid.WinForm.TGrid TeeGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label LBTotalSales;
		private System.Windows.Forms.Label LBTotalSalesCountryBTValue;
		private System.Windows.Forms.Label LBTotalSalesCountryValue;
		private System.Windows.Forms.Label LBTotalItemsSold;
		private System.Windows.Forms.Label LBBetween;
		private System.Windows.Forms.Label LBTotalSalesCountryBT;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label SteemaDash;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.BindingSource bindingSourceSbyYCo;
		private TechProductsLtdDataSetTableAdapters.__SalesByYearContinentTableAdapter ___SalesByYearContinentTableAdapter;
		private TechProductsLtdDataSetTableAdapters.__SalesByContinentTableAdapter ___SalesByContinentTableAdapter;
		private System.Windows.Forms.Label SalesPer;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.TChart tChart2;
		private Steema.TeeChart.TChart tChart3;
		private Steema.TeeChart.TChart tChart4;
		private Steema.TeeChart.Styles.Area area1;
		private Steema.TeeChart.Styles.Donut donut1;
		private TechProductsLtdDataSetTableAdapters.__SalesByCountryTableAdapter ___SalesByCountryTableAdapter;
		private TechProductsLtdDataSetTableAdapters.Lookup_CountryTableAdapter lookup_CountryTableAdapter;
		private Steema.TeeChart.Tools.MarksTip marksTip1;
		private Steema.TeeChart.Tools.MarksTip marksTip2;
		private Steema.TeeChart.Styles.Bar bar1;
		private System.Windows.Forms.BindingSource bindingSource_Orders;
		private TechProductsLtdDataSetTableAdapters.Fact_OrdersTableAdapter fact_OrdersTableAdapter;
		private System.Windows.Forms.Button Export;
		private Steema.TeeChart.Styles.Bar bar2;
		private System.Windows.Forms.BindingSource bindingSourceContinents;
		private TechProductsLtdDataSetTableAdapters.Lookup_ContinentTableAdapter lookup_ContinentTableAdapter;
		private Steema.TeeChart.Styles.World world1;
		private System.Windows.Forms.Timer DonutTimer;
		private Steema.TeeChart.Tools.CursorTool vertCursorTool;
		private Steema.TeeChart.Tools.CursorTool horizCursorTool;
		private Steema.TeeChart.Tools.Annotation annVert;
		private Steema.TeeChart.Tools.Annotation annHoriz;
	}
}
