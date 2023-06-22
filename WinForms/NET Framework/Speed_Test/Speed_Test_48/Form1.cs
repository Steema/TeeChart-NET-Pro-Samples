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

namespace Speed_Test_48
{
    public partial class Form1 : Form
    {
        private TChart tChart1 = new TChart();
        public Form1()
        {
            InitializeComponent();

            tChart1.Dock = DockStyle.Fill;
            Controls.Add(tChart1);

            int seriesCount = 10;
            int pointCount = 300;
            Random rnd = new Random();

            for (int i = 0; i < seriesCount; i++)
            {
                Line line = new Line(tChart1.Chart);
                line.Pointer.Visible = true;
                line.Pointer.Style = PointerStyles.Circle;
                for (int j = 0; j < pointCount; j++)
                {
                    _ = line.Add(rnd.NextDouble() * 100);
                }
            }
        }
    }
}
