using Steema.TeeChart;
using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Steema.TeeChart.Samples
{
  public partial class Sankey_Series : Steema.TeeChart.Samples.BaseForm
  {
        private Steema.TeeChart.ChartController chartController1;        
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private HScrollBar hScrollBar1;
        private ComboBox comboBox1;        
        private Steema.TeeChart.Tools.MarksTip marksTip1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(1114, 73);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Size = new System.Drawing.Size(1114, 82);
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
            this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            this.tChart1.Header.Font.Size = 14;
            this.tChart1.Header.Font.SizeFloat = 14F;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Brush.Gradient.UseMiddle = true;
            this.tChart1.Legend.ClipText = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
            this.tChart1.Size = new System.Drawing.Size(1114, 378);
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
            this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = true;
            this.tChart1.Walls.Bottom.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Left.Brush.Gradient.UseMiddle = true;
            this.tChart1.Walls.Left.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Right.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tChart1.Zoom.Brush.Visible = false;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 155);
            this.chartContainer.Size = new System.Drawing.Size(1114, 378);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(19, 43);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(208, 27);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(257, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "mouse";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "click";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(542, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Highlight";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(542, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "labels in/out";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "data 1",
            "data 2",
            "data 3",
            "data 4"});
            this.comboBox1.Location = new System.Drawing.Point(19, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sankey_Series
            // 
            this.ClientSize = new System.Drawing.Size(1114, 533);
            this.Name = "Sankey_Series";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

}

#endregion

    public Sankey_Series()
    {
      InitializeComponent();

      InitializeChart();
    }

    private void InitializeChart()
    {
            var datas = new List<SankeyData>()
                  {
                      new SankeyData("A1", "B1", 8),
                      new SankeyData("A2", "B2", 4),
                      new SankeyData("A1", "B2", 2),
                      new SankeyData("B1", "C1", 8),
                      new SankeyData("B2", "C1", 4),
                      new SankeyData("B2", "C2", 2),
                  };

            SankeyDatas = datas;
            SankeyShowLabels = true;
            //SankeyLinkCurvature = 0.95;
            //SankeyFlowDirection = FlowDirection.TopToBottom;

            tChart1.Panel.MarginTop = 0;
            tChart1.Panel.MarginBottom = 3;
            tChart1.Panel.MarginLeft = 10;
            tChart1.Panel.MarginRight = 10;

            sdiag = new Steema.TeeChart.Styles.Sankey(tChart1.Chart);

            sdiag.FillSampleValues();

            sdiag.LinkCurvature = 0.70F; // 0.95F;
            sdiag.SankeyFlowDirection = Steema.TeeChart.Styles.FlowDirection.LeftToRight;
            sdiag.FirstAndLastLabelPosition = FirstAndLastLabelPosition.Inward;

            tChart1.Chart.Title.Visible = false;
            this.textBox1.Visible = false;
            this.comboBox1.SelectedIndex = 2;
            hScrollBar1.Value = hScrollBar1.Maximum / 2;

        }
            
        private List<SankeyData> sankeyDatas;
        public IReadOnlyList<SankeyData> SankeyDatas
        {
          get
          {
            return sankeyDatas;
          }
          private set
          {
            if (value != sankeyDatas)
            {
              sankeyDatas = value == null ? null : value.ToList();
            }
          }
        }

        private bool sankeyShowLabels;
        public bool SankeyShowLabels
        {
          get
          {
            return sankeyShowLabels;
          }
          set
          {
            if (value != sankeyShowLabels)
            {
              sankeyShowLabels = value;
            }
          }
        }

        private double sankeyLinkCurvature;
        public double SankeyLinkCurvature
        {
          get
          {
            return sankeyLinkCurvature;
          }
          set
          {
            if (value != sankeyLinkCurvature)
            {
              sankeyLinkCurvature = value;
            }
          }
        }

    private List<SankeyData> GetData1()
    {
      var datas = new List<SankeyData>()
      {
          new SankeyData("Agricultural 'waste'", "Bio-conversion", 124.729),
          new SankeyData("Bio-conversion","Liquid", 0.597),
          new SankeyData("Bio-conversion", "Losses", 26.862),
          new SankeyData("Bio-conversion", "Solid", 280.322),
          new SankeyData("Bio-conversion", "Gas", 81.144),
          new SankeyData("Biofuel imports", "Liquid", 35),
          new SankeyData("Biomass imports", "Solid", 35),
          new SankeyData("Coal imports", "Coal", 11.606),
          new SankeyData("Coal reserves", "Coal", 63.965),
          new SankeyData("Coal", "Solid", 75.571),
          new SankeyData("District heating", "Industry", 10.639),
          new SankeyData("District heating", "Heating and cooling - commercial", 22.505),
          new SankeyData("District heating", "Heating and cooling - homes", 46.184),
          new SankeyData("Electricity grid", "Over generation / exports", 104.453),
          new SankeyData("Electricity grid", "Heating and cooling - homes", 113.726),
          new SankeyData("Electricity grid", "H2 conversion", 27.14),
          new SankeyData("Electricity grid", "Industry", 342.165),
          new SankeyData("Electricity grid", "Road transport", 37.797),
          new SankeyData("Electricity grid", "Agriculture", 4.412),
          new SankeyData("Electricity grid", "Heating and cooling - commercial", 40.858),
          new SankeyData("Electricity grid", "Losses", 56.691),
          new SankeyData("Electricity grid", "Rail transport", 7.863),
          new SankeyData("Electricity grid", "Lighting & appliances - commercial", 90.008),
          new SankeyData("Electricity grid", "Lighting & appliances - homes", 93.494),
          new SankeyData("Gas imports", "Ngas", 40.719),
          new SankeyData("Gas reserves", "Ngas", 82.233),
          new SankeyData("Gas", "Heating and cooling - commercial", 0.129),
          new SankeyData("Gas", "Losses", 1.401),
          new SankeyData("Gas", "Thermal generation", 151.891),
          new SankeyData("Gas", "Agriculture", 2.096),
          new SankeyData("Gas", "Industry", 48.58),
          new SankeyData("Geothermal", "Electricity grid", 7.013),
          new SankeyData("H2 conversion", "H2", 20.897),
          new SankeyData("H2 conversion", "Losses", 6.242),
          new SankeyData("H2", "Road transport", 20.897),
          new SankeyData("Hydro", "Electricity grid", 6.995),
          new SankeyData("Liquid", "Industry", 121.066),
          new SankeyData("Liquid", "International shipping", 128.69),
          new SankeyData("Liquid", "Road transport", 135.835),
          new SankeyData("Liquid", "Domestic aviation", 14.458),
          new SankeyData("Liquid", "International aviation", 206.267),
          new SankeyData("Liquid", "Agriculture", 3.64),
          new SankeyData("Liquid", "National navigation", 33.218),
          new SankeyData("Liquid", "Rail transport", 4.413),
          new SankeyData("Marine algae", "Bio-conversion", 4.375),
          new SankeyData("Ngas", "Gas", 122.952),
          new SankeyData("Nuclear", "Thermal generation", 839.978),
          new SankeyData("Oil imports", "Oil", 504.287),
          new SankeyData("Oil reserves", "Oil", 107.703),
          new SankeyData("Oil", "Liquid", 611.99),
          new SankeyData("Other waste", "Solid", 56.587),
          new SankeyData("Other waste", "Bio-conversion", 77.81),
          new SankeyData("Pumped heat",  "Heating and cooling - homes", 193.026),
          new SankeyData("Pumped heat", "Heating and cooling - commercial", 70.672),
          new SankeyData("Solar PV", "Electricity grid", 59.901),
          new SankeyData("Solar Thermal", "Heating and cooling - homes", 19.263),
          new SankeyData("Solar", "Solar Thermal", 19.263),
          new SankeyData("Solar", "Solar PV", 59.901),
          new SankeyData("Solid", "Agriculture", 0.882),
          new SankeyData("Solid", "Thermal generation", 400.12),
          new SankeyData("Solid", "Industry", 46.477),
          new SankeyData("Thermal generation", "Electricity grid", 525.531),
          new SankeyData("Thermal generation", "Losses", 787.129),
          new SankeyData("Thermal generation", "District heating", 79.329),
          new SankeyData("Tidal", "Electricity grid", 9.452),
          new SankeyData("UK land based bioenergy", "Bio-conversion", 182.01),
          new SankeyData("Wave", "Electricity grid", 19.013),
          new SankeyData("Wind", "Electricity grid", 289.366)
      };

      return datas;
    }

    private List<SankeyData> GetData2()
    {

      var datas = new List<SankeyData>()
      {
          new SankeyData("A", "C", 255),
          new SankeyData("A", "D", 355),
          new SankeyData("B", "C", 555),
          new SankeyData("B", "D", 255),
          new SankeyData("B", "E", 1555),
          new SankeyData("C", "H", 155),
          new SankeyData("D", "F", 25),
          new SankeyData("D", "G", 155),
          new SankeyData("D", "H", 15),
          new SankeyData("D", "I", 55),
          new SankeyData("E", "H", 1555),
          new SankeyData("B", "G", 255),
          new SankeyData("A", "E", 95),
          new SankeyData("E", "I", 1555),
          new SankeyData("C", "G", 755),
          new SankeyData("C", "F", 455)
      };

      return datas;
    }

    private List<SankeyData> GetData3()
    {
      var data = new List<SankeyData>()
      {
        new SankeyData("A1", "B1", 8),
        new SankeyData("A2", "B2", 4),
        new SankeyData("A1", "B2", 2),
        new SankeyData("B1", "C1", 8),
        new SankeyData("B2", "C1", 4),
        new SankeyData("A2", "B2", 7),
        new SankeyData("B2", "C2", 2),
      };

      return data;
    }

    private List<SankeyData> GetData4()
    {
      var data = new List<SankeyData>()
      {
        new SankeyData("A1", "B1", 18),
        new SankeyData("A2", "B2", 41),
        new SankeyData("A1", "B2", 12),
        new SankeyData("B1", "C1", 81),
        new SankeyData("B2", "C1", 14),
        new SankeyData("B2", "C2", 21),
      };

      return data;
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      
    }

    private void setHighlighting(bool active)
    {
      sdiag.HighlightBrush.Color = Color.Olive;
      sdiag.Highlighting = active;
      sdiag.HighlightMode = HighlightMode.MouseClick;
      sdiag.UsePalette = SankeyPalette.LinksOnly;
    }

    Steema.TeeChart.Styles.Sankey sdiag;

    private void Sdiag_Click(object sender, MouseEventArgs e)
    {
      int idx = sdiag.Clicked(e.X, e.Y);

      if (idx != -1)
      {
        if (idx < -1)
        {
          SankeyLink link = sdiag.FindLink(idx);
          //MessageBox.Show(idx.ToString() + ", from: " + sdiag.FindLink(idx).FromNode.Name + ", to: " + sdiag.FindLink(idx).ToNode.Name);
        }
        else
        {
          SankeyNode node = sdiag.FindNode(idx);
          node.Highlight = !node.Highlight;
          tChart1.Invalidate();
          //MessageBox.Show(idx.ToString() + " " + sdiag.FindNode(idx).Name);
        }
      }
      tChart1.Chart.CancelMouse = true;
    }

    int counter = 0;

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      counter++;
      g.Font.Color = Color.White;
      g.TextOut(10, 10, counter.ToString());
    }

    private void tChart1_MouseMove(object sender, MouseEventArgs e)
    {
      //sdiag.Sankey_Click(sender, e);
    }

    private void setData(List<SankeyData> data)
    {
      sdiag.Clear();

      hScrollBar1.Value = 0;
      sdiag.LinkCurvature = hScrollBar1.Value * 1.0F;
      groupBox1.Visible = false;
      //setHighlighting(false);
      checkBox1.Checked = false;
      radioButton1.Checked = true;
      checkBox2.Checked = true;

      sdiag.initialize(tChart1.Chart);
      //sdiag = new Sankey(tChart1.Chart);
      sdiag.Add(data);
      sdiag.Invalidate();

      tChart1.Invalidate();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (comboBox1.SelectedIndex)
      {
        case 0: setData(GetData1()); break;
        case 1: setData(GetData2()); break;
        case 2: setData(GetData3()); break;
        case 3: setData(GetData4()); break;
      }
    }

    private void hScrollBar1_ValueChanged(object sender, EventArgs e)
    {
      sdiag.LinkCurvature = 0.01F * hScrollBar1.Value;
      sdiag.Invalidate();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      groupBox1.Visible = checkBox1.Checked;
      setHighlighting(checkBox1.Checked);
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButton1.Checked)
        sdiag.HighlightMode = HighlightMode.MouseClick;
      else
        sdiag.HighlightMode = HighlightMode.MouseEnter;
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox2.Checked)
        sdiag.FirstAndLastLabelPosition = FirstAndLastLabelPosition.Inward;
      else
        sdiag.FirstAndLastLabelPosition = FirstAndLastLabelPosition.Outward;

      tChart1.Invalidate();
    }

    private void tChart1_BeforeDrawAxes(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      Steema.TeeChart.Styles.Line line1 = new Steema.TeeChart.Styles.Line();
      Steema.TeeChart.Styles.Line line2 = new Steema.TeeChart.Styles.Line();
      Steema.TeeChart.Styles.Line line3 = new Steema.TeeChart.Styles.Line();

      tChart1.Series.Add(line1);
      tChart1.Series.Add(line2);
      tChart1.Series.Add(line3);

      tChart1.Invalidate();
    }

    private void tChart1_BeforeDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {

    }

    private void tChart1_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {

    }
  }
}

