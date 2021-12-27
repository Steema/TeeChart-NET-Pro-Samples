using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TeeChartFeatures.Model;

namespace TeeChartFeatures.ViewModel
{

    public class SearchItemsViewModel
    {

        private List<SearchItemsModel> _items;
        private Context _context;

        public SearchItemsViewModel(Context context)
        {
            _context = context;
            _items = InitializeItems();
        }

        /// <summary>
        /// Crea los items del recycler view
        /// </summary>
        /// <returns></returns>
        private List<SearchItemsModel> InitializeItems()
        {
            List<SearchItemsModel> items = new List<SearchItemsModel>()
            {
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.lineChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.interpolatingLineChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.columnbarChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.barStylesChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.barGradientChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.areaChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.stackAreaChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.pieChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.multiPiesChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.semiPieChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.fstlineChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.realTimeChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.hAreaChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.hBarChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.hLineChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.donutChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.semiDonutChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.bubbleChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.transBubbleChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.ganttChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.shapeChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.pointscatterChartName), Utils.GetResources.GetString(Resource.String.titleStdCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.arrowChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.polarChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.polarBarChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.radarChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.pyramidChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.invertedPyramidChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.candleChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.histogramChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.horizHistogramChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.errorChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.errorBarChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.funnelChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.smithChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.bezierChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.highLowChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.speedTimeChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.waterfallChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.volumeChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.colorGridChartName), Utils.GetResources.GetString(Resource.String.titleProCharts)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.circularGaugeChartName), Utils.GetResources.GetString(Resource.String.titleCircularGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.carFuelChartName), Utils.GetResources.GetString(Resource.String.titleCircularGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.customHandChartName), Utils.GetResources.GetString(Resource.String.titleCircularGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.accelerationChartName), Utils.GetResources.GetString(Resource.String.titleCircularGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.mapGISChartName), Utils.GetResources.GetString(Resource.String.titleMaps)),
                //new SearchItemsModel(Utils.GetResources.GetString(Resource.String.worldMapChartName), Utils.GetResources.GetString(Resource.String.titleMaps)),
                //new SearchItemsModel(Utils.GetResources.GetString(Resource.String.treeMapChartName), Utils.GetResources.GetString(Resource.String.titleTreeMap)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.knobGaugeChartName), Utils.GetResources.GetString(Resource.String.titleKnobGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.temperaturaKnobChartName), Utils.GetResources.GetString(Resource.String.titleKnobGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.compassChartName), Utils.GetResources.GetString(Resource.String.titleKnobGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.basicClockChartName), Utils.GetResources.GetString(Resource.String.titleClock)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.customClockChartName), Utils.GetResources.GetString(Resource.String.titleClock)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.organizationalChartName), Utils.GetResources.GetString(Resource.String.titleOrganizational)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.numericGaugeChartName), Utils.GetResources.GetString(Resource.String.titleNumericGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.linearGaugeChartName), Utils.GetResources.GetString(Resource.String.titleLinearGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.scalesChartName), Utils.GetResources.GetString(Resource.String.titleLinearGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.sublinesChartName), Utils.GetResources.GetString(Resource.String.titleLinearGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.mobileBatteryChartName), Utils.GetResources.GetString(Resource.String.titleLinearGauge)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.calendarChartName), Utils.GetResources.GetString(Resource.String.titleCalendar)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.specialDatesChartName), Utils.GetResources.GetString(Resource.String.titleCalendar)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.tagCloudChartName), Utils.GetResources.GetString(Resource.String.titleTagCloud)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.addFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.substractFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.multiplyFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.divideFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.countFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.averageFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.highFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.lowFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.medianFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),
                new SearchItemsModel(Utils.GetResources.GetString(Resource.String.percentChangeFuncChartName), Utils.GetResources.GetString(Resource.String.titleStdFunctions)),

            };
            return items;
        }

        public List<SearchItemsModel> Items { get => _items; set => _items = value; }

        public int ItemsCount { get => _items.Count; }

    }
}