using System;

using System.Collections.Generic;
using Android.App;
using Android.Content.Res;
using Android.Views;
using Android.Widget;

namespace MonoAndroidDemo
{
	class SeriesAdapter : BaseAdapter
	{
    List<Series> _seriesList;
    Activity _activity;        
        
    public SeriesAdapter (Activity activity)
    {
      _activity = activity;

      FillSeries();
    }
        
    public override int Count {
      get { return _seriesList.Count; }
    }

    public override Java.Lang.Object GetItem (int position)
    {
      return null;
    }

    public override long GetItemId (int position)
    {
      return _seriesList [position].Id;
    }
        
    public override View GetView (int position, View convertView, ViewGroup parent)
    {          
      var view = convertView ?? _activity.LayoutInflater.Inflate (Resource.Layout.ListItem, parent, false);
      var seriesName = view.FindViewById<TextView> (Resource.Id.textView1);
      var seriesImage = view.FindViewById<ImageView> (Resource.Id.imageView1);

      seriesName.Text = _seriesList[position].Name;
      string imageName = _seriesList[position].Name.ToLower();

      Resources res = _activity.ApplicationContext.Resources; //parent.Context.Resources;
      int id = res.GetIdentifier(imageName, "drawable", _activity.ApplicationContext.PackageName); //parent.Context.PackageName);
      id = (id == 0) ? Resource.Drawable.logo57x57 : id;

      seriesImage.SetImageResource(id);

      return view;
    }

    void FillSeries()
    {
      _seriesList = new List<Series>();

		  for (int t = 0; t < Steema.TeeChart.Utils.SeriesTypesCount; t++)
      {
        var tmp = Steema.TeeChart.Utils.SeriesTypesOf [t];
				int id = Steema.TeeChart.Utils.SeriesTypesIndex(tmp);

        _seriesList.Add(new Series
        {
          Id = id,
          Name = tmp.ToString().Replace("Steema.TeeChart.Styles.", ""),
          SeriesType = tmp,
          Icon = tmp.ToString()
        });
      }

    }
	}

  class Series
  {
    public long Id { get; set; }

    public string Name { get; set; }

    public Type SeriesType { get; set; }

    public string Icon { get; set; }
  }
}

