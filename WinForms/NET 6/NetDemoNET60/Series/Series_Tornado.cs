using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Series_Tornado : BaseForm
  {
    Steema.TeeChart.Styles.Tornado tornado;
    public Series_Tornado()
    {
      InitializeComponent();
    }

    private void Series_Tornado_Load(object sender, EventArgs e)
    {
      tChart1.Series.Clear();

      tornado = new Steema.TeeChart.Styles.Tornado();
      tChart1.Series.Add(tornado);

      tornado.BarStyle = Steema.TeeChart.Styles.BarStyles.RoundRectangle;
      //tornado.LeftColor = Color.Red;
      tornado.MarksOnBar = true;
      tornado.Marks.Font.Size = 12;
      tornado.Marks.Font.Bold = true;
      tornado.Marks.Font.Color = Color.White;

      tornado.SortBy = TornadoSortBy.None;

      tChart1[0].Add(1.2, 2.1, "Potatoes", Color.Empty);
      tChart1[0].Add(4.8, 3.7, "Cabbages", Color.Empty);
      tChart1[0].Add(3.1, 6.1, "Carrots", Color.Empty);
      tChart1[0].Add(5.1, 4.2, "Turnips", Color.Empty);

      tChart1.Legend.Visible = false;
      tChart1.Header.Text = "Greenhouse       Open air";
      tChart1.Axes.Bottom.Title.Text = "tonnes";

      comboBox2.Text = "None";
      comboBox1.Focus();
    }

    private ComboBox comboBox1;
    private Label label1;
    private ComboBox comboBox2;
    private Label label2;

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
      label1 = new Label();
      comboBox1 = new ComboBox();
      label2 = new Label();
      comboBox2 = new ComboBox();
      panel1.SuspendLayout();
      chartContainer.SuspendLayout();
      SuspendLayout();
      // 
      // textBox1
      // 
      textBox1.Text = "A Tornado chart, based on horizontal bars, is useful to show relativities as a scaled set between two categories..";
      // 
      // panel1
      // 
      panel1.Controls.Add(comboBox2);
      panel1.Controls.Add(label2);
      panel1.Controls.Add(comboBox1);
      panel1.Controls.Add(label1);
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
      tChart1.Axes.Bottom.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Depth.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.DepthTop.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Left.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Right.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Axes.Top.Labels.Sign = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Header.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      tChart1.Header.Font.Size = 14;
      tChart1.Header.Font.SizeFloat = 14F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Legend.Brush.Gradient.UseMiddle = true;
      tChart1.Legend.CheckBoxes = false;
      tChart1.Legend.ClipText = false;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Panel.Bevel.Outer = Drawing.BevelStyles.Raised;
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
      tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = true;
      tChart1.Walls.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Left.Brush.Gradient.UseMiddle = true;
      tChart1.Walls.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Walls.Right.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      tChart1.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
      tChart1.Zoom.Brush.Visible = false;
      // 
      // label1
      // 
      label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label1.AutoSize = true;
      label1.Location = new Point(261, 11);
      label1.Name = "label1";
      label1.Size = new Size(56, 17);
      label1.TabIndex = 0;
      label1.Text = "sort b&y: ";
      // 
      // comboBox1
      // 
      comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      comboBox1.FlatStyle = FlatStyle.Flat;
      comboBox1.FormattingEnabled = true;
      comboBox1.Items.AddRange(new object[] { "Sum", "Left", "Right", "None" });
      comboBox1.Location = new Point(311, 8);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(121, 25);
      comboBox1.TabIndex = 1;
      comboBox1.Text = "None";
      comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      // 
      // label2
      // 
      label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label2.AutoSize = true;
      label2.Location = new Point(82, 11);
      label2.Name = "label2";
      label2.Size = new Size(64, 17);
      label2.TabIndex = 2;
      label2.Text = "&Order by:";
      // 
      // comboBox2
      // 
      comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      comboBox2.FlatStyle = FlatStyle.Flat;
      comboBox2.FormattingEnabled = true;
      comboBox2.Items.AddRange(new object[] { "None", "Ascending", "Descending" });
      comboBox2.Location = new Point(152, 8);
      comboBox2.Name = "comboBox2";
      comboBox2.Size = new Size(92, 25);
      comboBox2.TabIndex = 3;
      comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
      // 
      // Series_Tornado
      // 
      ClientSize = new Size(440, 317);
      Name = "Series_Tornado";
      Load += Series_Tornado_Load;
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      chartContainer.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();

    }

    #endregion

    private void resetSort()
    {

      switch (comboBox1.SelectedIndex)
      {
        case 0: tornado.SortBy = Styles.TornadoSortBy.Sum; break;
        case 1: tornado.SortBy = Styles.TornadoSortBy.Left; break;
        case 2: tornado.SortBy = Styles.TornadoSortBy.Right; break;
        case 3: tornado.SortBy = Styles.TornadoSortBy.None; break;
      }

      switch (comboBox2.SelectedIndex)
      {
        case 0: tornado.SortOrder = ValueListOrder.None; break;
        case 1: tornado.SortOrder = ValueListOrder.Ascending; ; break;
        case 2: tornado.SortOrder = ValueListOrder.Descending; break;
      }

      tChart1.Refresh();

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      resetSort();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      resetSort();
    }
  }
}
