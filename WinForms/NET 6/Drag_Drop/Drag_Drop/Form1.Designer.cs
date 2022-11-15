namespace Drag_Drop
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cbZoom = new System.Windows.Forms.CheckBox();
      this.cbBlackDots = new System.Windows.Forms.CheckBox();
      this.bReset = new System.Windows.Forms.Button();
      this.cbSelector = new System.Windows.Forms.CheckBox();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.cbXval = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
      this.splitContainer1.Panel1.Controls.Add(this.bReset);
      this.splitContainer1.Panel1.Controls.Add(this.cbSelector);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tChart1);
      this.splitContainer1.Size = new System.Drawing.Size(1081, 520);
      this.splitContainer1.SplitterDistance = 201;
      this.splitContainer1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cbXval);
      this.groupBox1.Controls.Add(this.cbZoom);
      this.groupBox1.Controls.Add(this.cbBlackDots);
      this.groupBox1.Location = new System.Drawing.Point(12, 142);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(169, 296);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "evget";
      // 
      // cbZoom
      // 
      this.cbZoom.AutoSize = true;
      this.cbZoom.Location = new System.Drawing.Point(21, 74);
      this.cbZoom.Name = "cbZoom";
      this.cbZoom.Size = new System.Drawing.Size(103, 19);
      this.cbZoom.TabIndex = 1;
      this.cbZoom.Text = "Zoom enabled";
      this.cbZoom.UseVisualStyleBackColor = true;
      this.cbZoom.CheckedChanged += new System.EventHandler(this.cbZoom_CheckedChanged);
      // 
      // cbBlackDots
      // 
      this.cbBlackDots.AutoSize = true;
      this.cbBlackDots.Checked = true;
      this.cbBlackDots.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbBlackDots.Location = new System.Drawing.Point(21, 33);
      this.cbBlackDots.Name = "cbBlackDots";
      this.cbBlackDots.Size = new System.Drawing.Size(81, 19);
      this.cbBlackDots.TabIndex = 0;
      this.cbBlackDots.Text = "Black Dots";
      this.cbBlackDots.UseVisualStyleBackColor = true;
      this.cbBlackDots.CheckedChanged += new System.EventHandler(this.cbBlackDots_CheckedChanged);
      // 
      // bReset
      // 
      this.bReset.Location = new System.Drawing.Point(20, 91);
      this.bReset.Name = "bReset";
      this.bReset.Size = new System.Drawing.Size(75, 23);
      this.bReset.TabIndex = 1;
      this.bReset.Text = "Reset";
      this.bReset.UseVisualStyleBackColor = true;
      this.bReset.Click += new System.EventHandler(this.bReset_Click);
      // 
      // cbSelector
      // 
      this.cbSelector.AutoSize = true;
      this.cbSelector.Checked = true;
      this.cbSelector.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbSelector.Location = new System.Drawing.Point(21, 35);
      this.cbSelector.Name = "cbSelector";
      this.cbSelector.Size = new System.Drawing.Size(93, 19);
      this.cbSelector.TabIndex = 0;
      this.cbSelector.Text = "Selector Tool";
      this.cbSelector.UseVisualStyleBackColor = true;
      this.cbSelector.CheckedChanged += new System.EventHandler(this.cbSelector_CheckedChanged);
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
      this.tChart1.Axes.Bottom.AxisPen.Width = 2;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Grid.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Axis = this.tChart1.Axes.Bottom;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Axes.Bottom.Labels.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Labels.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      this.tChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.MinorTicks.Length = 2;
      this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Ticks.Length = 4;
      this.tChart1.Axes.Bottom.Ticks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.TicksInner.Length = 0;
      this.tChart1.Axes.Bottom.TicksInner.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
      this.tChart1.Axes.Bottom.Title.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Title.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Bottom.Title.Font.Size = 11;
      this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
      this.tChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Bottom.UseMaxPixelPos = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.AxisPen.Visible = false;
      this.tChart1.Axes.Depth.AxisPen.Width = 2;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Axis = this.tChart1.Axes.Depth;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Axes.Depth.Labels.Brush.Solid = true;
      this.tChart1.Axes.Depth.Labels.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
      this.tChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Depth.Labels.Font.Size = 9;
      this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
      this.tChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.MinorTicks.Length = 2;
      this.tChart1.Axes.Depth.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Ticks.Length = 4;
      this.tChart1.Axes.Depth.Ticks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.TicksInner.Length = 0;
      this.tChart1.Axes.Depth.TicksInner.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
      this.tChart1.Axes.Depth.Title.Brush.Solid = true;
      this.tChart1.Axes.Depth.Title.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Depth.Title.Font.Brush.Solid = true;
      this.tChart1.Axes.Depth.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Depth.Title.Font.Size = 11;
      this.tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
      this.tChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Depth.UseMaxPixelPos = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.AxisPen.Visible = false;
      this.tChart1.Axes.DepthTop.AxisPen.Width = 2;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Axis = this.tChart1.Axes.DepthTop;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Axes.DepthTop.Labels.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Labels.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.DepthTop.Labels.Font.Size = 9;
      this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
      this.tChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.MinorTicks.Length = 2;
      this.tChart1.Axes.DepthTop.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Ticks.Length = 4;
      this.tChart1.Axes.DepthTop.Ticks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.TicksInner.Length = 0;
      this.tChart1.Axes.DepthTop.TicksInner.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
      this.tChart1.Axes.DepthTop.Title.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Title.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.DepthTop.Title.Font.Size = 11;
      this.tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
      this.tChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
      this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
      this.tChart1.Axes.DepthTop.UseMaxPixelPos = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      this.tChart1.Axes.Left.AxisPen.Width = 2;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Axis = this.tChart1.Axes.Left;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Axes.Left.Labels.Brush.Solid = true;
      this.tChart1.Axes.Left.Labels.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Labels.Font.Brush.Solid = true;
      this.tChart1.Axes.Left.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Left.Labels.Font.Size = 9;
      this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
      this.tChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Left.MinorTicks.Length = 2;
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Ticks.Length = 4;
      this.tChart1.Axes.Left.Ticks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.TicksInner.Length = 0;
      this.tChart1.Axes.Left.TicksInner.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
      this.tChart1.Axes.Left.Title.Brush.Solid = true;
      this.tChart1.Axes.Left.Title.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Left.Title.Font.Brush.Solid = true;
      this.tChart1.Axes.Left.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Left.Title.Font.Size = 11;
      this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
      this.tChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Left.UseMaxPixelPos = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.AxisPen.Visible = false;
      this.tChart1.Axes.Right.AxisPen.Width = 2;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Axis = this.tChart1.Axes.Right;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Axes.Right.Labels.Brush.Solid = true;
      this.tChart1.Axes.Right.Labels.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Right.Labels.Font.Brush.Solid = true;
      this.tChart1.Axes.Right.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Right.Labels.Font.Size = 9;
      this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
      this.tChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Right.MinorTicks.Length = 2;
      this.tChart1.Axes.Right.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Ticks.Length = 4;
      this.tChart1.Axes.Right.Ticks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Right.TicksInner.Length = 0;
      this.tChart1.Axes.Right.TicksInner.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
      this.tChart1.Axes.Right.Title.Brush.Solid = true;
      this.tChart1.Axes.Right.Title.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Right.Title.Font.Brush.Solid = true;
      this.tChart1.Axes.Right.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Right.Title.Font.Size = 11;
      this.tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
      this.tChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Right.UseMaxPixelPos = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.AxisPen.Width = 2;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Axis = this.tChart1.Axes.Top;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Axes.Top.Labels.Brush.Solid = true;
      this.tChart1.Axes.Top.Labels.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Top.Labels.Font.Brush.Solid = true;
      this.tChart1.Axes.Top.Labels.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Top.Labels.Font.Size = 9;
      this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.tChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Top.MinorTicks.Length = 2;
      this.tChart1.Axes.Top.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Ticks.Length = 4;
      this.tChart1.Axes.Top.Ticks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Top.TicksInner.Length = 0;
      this.tChart1.Axes.Top.TicksInner.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
      this.tChart1.Axes.Top.Title.Brush.Solid = true;
      this.tChart1.Axes.Top.Title.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Top.Title.Font.Brush.Solid = true;
      this.tChart1.Axes.Top.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Top.Title.Font.Size = 11;
      this.tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
      this.tChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
      this.tChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
      this.tChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
      this.tChart1.Axes.Top.UseMaxPixelPos = true;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
      this.tChart1.Footer.Brush.Solid = true;
      this.tChart1.Footer.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Footer.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
      this.tChart1.Footer.Font.Brush.Solid = true;
      this.tChart1.Footer.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Footer.Font.Shadow.Brush.Solid = true;
      this.tChart1.Footer.Font.Shadow.Brush.Visible = true;
      this.tChart1.Footer.Font.Size = 8;
      this.tChart1.Footer.Font.SizeFloat = 8F;
      this.tChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Footer.ImageBevel.Brush.Solid = true;
      this.tChart1.Footer.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Footer.Shadow.Brush.Solid = true;
      this.tChart1.Footer.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.tChart1.Header.Brush.Solid = true;
      this.tChart1.Header.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Header.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Header.Font.Brush.Solid = true;
      this.tChart1.Header.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Header.Font.Shadow.Brush.Solid = true;
      this.tChart1.Header.Font.Shadow.Brush.Visible = true;
      this.tChart1.Header.Font.Size = 12;
      this.tChart1.Header.Font.SizeFloat = 12F;
      this.tChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Header.ImageBevel.Brush.Solid = true;
      this.tChart1.Header.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.tChart1.Header.Shadow.Brush.Solid = true;
      this.tChart1.Header.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Legend.Brush.Solid = true;
      this.tChart1.Legend.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Legend.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Legend.Font.Brush.Solid = true;
      this.tChart1.Legend.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Legend.Font.Shadow.Brush.Solid = true;
      this.tChart1.Legend.Font.Shadow.Brush.Visible = true;
      this.tChart1.Legend.Font.Size = 9;
      this.tChart1.Legend.Font.SizeFloat = 9F;
      this.tChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Legend.ImageBevel.Brush.Solid = true;
      this.tChart1.Legend.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Legend.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Shadow.Brush.Solid = true;
      this.tChart1.Legend.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Legend.Symbol.Legend = this.tChart1.Legend;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Legend.Symbol.Shadow.Brush.Solid = true;
      this.tChart1.Legend.Symbol.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Legend.Title.Brush.Solid = true;
      this.tChart1.Legend.Title.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Bold = true;
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
      this.tChart1.Legend.Title.Font.Brush.Solid = true;
      this.tChart1.Legend.Title.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
      this.tChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
      this.tChart1.Legend.Title.Font.Size = 8;
      this.tChart1.Legend.Title.Font.SizeFloat = 8F;
      this.tChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Legend.Title.ImageBevel.Brush.Solid = true;
      this.tChart1.Legend.Title.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Legend.Title.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Legend.Title.Shadow.Brush.Solid = true;
      this.tChart1.Legend.Title.Shadow.Brush.Visible = true;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
      this.tChart1.Panel.Brush.Solid = true;
      this.tChart1.Panel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Panel.ImageBevel.Brush.Solid = true;
      this.tChart1.Panel.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.Panel.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Panel.Shadow.Brush.Solid = true;
      this.tChart1.Panel.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      margins1.Bottom = 100;
      margins1.Left = 100;
      margins1.Right = 100;
      margins1.Top = 100;
      this.tChart1.Printer.Margins = margins1;
      this.tChart1.Size = new System.Drawing.Size(876, 520);
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
      this.tChart1.SubFooter.Brush.Solid = true;
      this.tChart1.SubFooter.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.SubFooter.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
      this.tChart1.SubFooter.Font.Brush.Solid = true;
      this.tChart1.SubFooter.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.SubFooter.Font.Shadow.Brush.Solid = true;
      this.tChart1.SubFooter.Font.Shadow.Brush.Visible = true;
      this.tChart1.SubFooter.Font.Size = 8;
      this.tChart1.SubFooter.Font.SizeFloat = 8F;
      this.tChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.SubFooter.ImageBevel.Brush.Solid = true;
      this.tChart1.SubFooter.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.SubFooter.Shadow.Brush.Solid = true;
      this.tChart1.SubFooter.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.tChart1.SubHeader.Brush.Solid = true;
      this.tChart1.SubHeader.Brush.Visible = true;
      // 
      // 
      // 
      this.tChart1.SubHeader.Font.Bold = false;
      // 
      // 
      // 
      this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.SubHeader.Font.Brush.Solid = true;
      this.tChart1.SubHeader.Font.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.SubHeader.Font.Shadow.Brush.Solid = true;
      this.tChart1.SubHeader.Font.Shadow.Brush.Visible = true;
      this.tChart1.SubHeader.Font.Size = 12;
      this.tChart1.SubHeader.Font.SizeFloat = 12F;
      this.tChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.SubHeader.ImageBevel.Brush.Solid = true;
      this.tChart1.SubHeader.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.tChart1.SubHeader.Shadow.Brush.Solid = true;
      this.tChart1.SubHeader.Shadow.Brush.Visible = true;
      this.tChart1.TabIndex = 0;
      this.tChart1.Text = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Gradient.Visible = true;
      this.tChart1.Walls.Back.Brush.Solid = true;
      this.tChart1.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Walls.Back.ImageBevel.Brush.Solid = true;
      this.tChart1.Walls.Back.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Walls.Back.Shadow.Brush.Solid = true;
      this.tChart1.Walls.Back.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
      this.tChart1.Walls.Bottom.Brush.Solid = true;
      this.tChart1.Walls.Bottom.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
      this.tChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Walls.Bottom.Shadow.Brush.Solid = true;
      this.tChart1.Walls.Bottom.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
      this.tChart1.Walls.Left.Brush.Solid = true;
      this.tChart1.Walls.Left.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Walls.Left.ImageBevel.Brush.Solid = true;
      this.tChart1.Walls.Left.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Walls.Left.Shadow.Brush.Solid = true;
      this.tChart1.Walls.Left.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
      this.tChart1.Walls.Right.Brush.Solid = true;
      this.tChart1.Walls.Right.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
      this.tChart1.Walls.Right.ImageBevel.Brush.Solid = true;
      this.tChart1.Walls.Right.ImageBevel.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
      this.tChart1.Walls.Right.Shadow.Brush.Solid = true;
      this.tChart1.Walls.Right.Shadow.Brush.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
      this.tChart1.Zoom.Brush.Solid = true;
      this.tChart1.Zoom.Brush.Visible = true;
      this.tChart1.Zoom.FullRepaint = true;
      // 
      // cbXval
      // 
      this.cbXval.AutoSize = true;
      this.cbXval.Location = new System.Drawing.Point(21, 111);
      this.cbXval.Name = "cbXval";
      this.cbXval.Size = new System.Drawing.Size(94, 19);
      this.cbXval.TabIndex = 2;
      this.cbXval.Text = "Hide XValues";
      this.cbXval.UseVisualStyleBackColor = true;
      this.cbXval.CheckedChanged += new System.EventHandler(this.cbXval_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1081, 520);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Drag the Series up and down the Y axis";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private SplitContainer splitContainer1;
        private Steema.TeeChart.TChart tChart1;
        private CheckBox cbSelector;
        private Button bReset;
        private GroupBox groupBox1;
        private CheckBox cbBlackDots;
        private CheckBox cbZoom;
        private CheckBox cbXval;
    }
}