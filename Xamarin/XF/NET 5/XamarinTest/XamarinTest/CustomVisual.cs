using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinTest;

[assembly: Visual("MyVisual", typeof(CustomVisual))]
namespace XamarinTest
{

    public class CustomVisual : IVisual
    {
    }
}
