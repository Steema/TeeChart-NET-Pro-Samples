using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TeeChartFeatures.Model
{
    public class SearchItemsModel
    {

        private string _name;
        private string _groupStyles;

        public SearchItemsModel() { }

        public SearchItemsModel(string name, string groupStyles)
        {
            _name = name;
            _groupStyles = groupStyles;
        }

        public string Name { get => _name; set => _name = value; }
        public string Group { get => _groupStyles; set => _groupStyles = value; }

    }
}