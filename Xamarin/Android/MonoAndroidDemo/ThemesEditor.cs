using System;

using Android.App;
using Android.Content;
using Android.Widget;
using Steema.TeeChart;
using Steema.TeeChart.Themes;

namespace MonoAndroidDemo
{
  class ThemesEditor
  {
    TChart tChart;
	  int themeIdx;

	  public ThemesEditor(TChart TeeChart, int Selected) 
    {
      tChart = TeeChart;
      themeIdx = Selected;      
	  }

    public void Choose(Context context) 
    {
      var themes = Enum.GetNames(typeof(ThemeType));

      var builder = new AlertDialog.Builder(context)
          .SetTitle("Select Theme")
          .SetPositiveButton(Android.Resource.String.Ok, delegate
            {
              Toast
                .MakeText(context, themes[themeIdx], ToastLength.Short)
                .Show();
              tChart.CurrentTheme = (ThemeType)themeIdx;
            })
          .SetNegativeButton(Android.Resource.String.Cancel, CancelClicked);

      builder.SetSingleChoiceItems(themes, themeIdx, (sender, args) =>
      {
        themeIdx = args.Which;          
      });

      builder.Create().Show();
    }

    void CancelClicked(object sender, DialogClickEventArgs e)
    {
    }
  }
}