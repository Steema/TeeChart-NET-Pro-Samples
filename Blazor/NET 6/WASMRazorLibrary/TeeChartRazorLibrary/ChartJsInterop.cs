using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeChartRazorLibrary
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class ChartJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> fetchChart;

        public ChartJsInterop(IJSRuntime jsRuntime)
        {
            fetchChart = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/TeeChartRazorLibrary/chartAPI.js").AsTask());
        }

        public async ValueTask DrawChart()
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("drawChart");
        }

        public async ValueTask AnimateSeries(int aDuration)
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("animateSeries", aDuration);
        }

        public async ValueTask SetAxisMinMax(string axis, double min, double max)
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("setAxisMinMax", axis, min, max);
        }

        public async ValueTask AppendData(int seriesIndex, Tuple<double, double> data) 
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("appendData", seriesIndex, data.Item1, data.Item2);
        }
        public async ValueTask ChangeTheme(string aTheme)
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("changeTheme", aTheme);
        }

        public async ValueTask AddData(int seriesIndex, List<Tuple<double, double>> data)
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("addData", seriesIndex, data.Select(x => x.Item1).ToArray(), data.Select(x => x.Item2).ToArray());
        }

        public async ValueTask AddDateData(int seriesIndex, List<Tuple<double, double>> data)
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("addDateData", seriesIndex, data.Select(x => x.Item1).ToArray(), data.Select(x => x.Item2).ToArray());
        }

        public async ValueTask NewCode()
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("newCode");
        }


        public async ValueTask AddSeries(string seriesType)
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("addSeries", seriesType);
        }

        public async ValueTask SetChart(string chartName)
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("setChart", chartName);
        }

        public async ValueTask SetChartTitle(string aTitle)
        {
            var module = await fetchChart.Value;

            await module.InvokeVoidAsync("setChartTitle", aTitle);
        }

        public async ValueTask DisposeAsync()
        {
            if (fetchChart.IsValueCreated)
            {
                var module = await fetchChart.Value;
                await module.DisposeAsync();
            }
        }
    }
}
