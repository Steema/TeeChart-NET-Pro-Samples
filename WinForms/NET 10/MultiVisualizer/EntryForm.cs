using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinAppMultiVis;

namespace WinformRealtime
{
  public partial class EntryForm : Form
  {
    public EntryForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var axisDemo = new FormMultiAxis();
      axisDemo.Show(this);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var realtimeDemo = new FormMultiPanel();
      realtimeDemo.Show(this);
    }
  }
}
