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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.bReset = new System.Windows.Forms.Button();
      this.cbSelector = new System.Windows.Forms.CheckBox();
      this.tChart1 = new Steema.TeeChart.TChart();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
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
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      this.tChart1.Axes.Top.UseMaxPixelPos = true;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
      this.tChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      this.tChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
      // 
      // 
      // 
      this.tChart1.Legend.Title.Pen.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      this.tChart1.Panel.Pen.Visible = false;
      this.tChart1.Size = new System.Drawing.Size(876, 520);
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
      this.tChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
      this.tChart1.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
      // 
      // 
      // 
      this.tChart1.Zoom.FullRepaint = true;
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
      this.ResumeLayout(false);

    }

        #endregion

        private SplitContainer splitContainer1;
        private Steema.TeeChart.TChart tChart1;
        private CheckBox cbSelector;
        private Button bReset;
    }
}