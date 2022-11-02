using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Speed_Test;
using System.Windows.Forms;

namespace ConsoleApp1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var summary = BenchmarkRunner.Run<RunWinForm>();
    }

    public class RunWinForm
    {
      public Form1 Form1 { get; set; } = new Form1();

      public RunWinForm() 
      {
        Form1.Width = 900;
        Form1.Height = 600;
        Form1.StartPosition = FormStartPosition.CenterScreen;
        Form1.Show();
      }

      [Benchmark]
      public void RepaintForm1()
      {
        Form1.Width = 1000;
        Form1.Height = 700;
        Form1.Width = 900;
        Form1.Height = 600;
      }
    }
  }
}