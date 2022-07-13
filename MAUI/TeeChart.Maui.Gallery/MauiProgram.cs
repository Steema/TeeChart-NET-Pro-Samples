//using TeeChart.Maui.Hosting;

using Microsoft.Maui.Controls.Compatibility.Hosting;
using TeeChart.Maui.Hosting;
using TeeChart.Maui;

namespace TeeChart.Maui.Gallery;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        //TeeChart.Maui.InitTypes();

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            //.ConfigureTeeChart()
            

			.UseMauiCompatibility()
            /*
			.ConfigureMauiHandlers(handlers =>
			{
#if ANDROID                
                handlers.TryAddCompatibilityRenderer(typeof(ChartView), typeof(CustomChartRenderer));
#elif IOS
				handlers.TryAddCompatibilityRenderer(typeof(ChartView), typeof(CustomIOSChartRenderer));
#elif WINDOWS
				handlers.TryAddCompatibilityRenderer(typeof(ChartView), typeof(CustomWindowsChartRenderer));
#endif
            })*/

            

            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
            TeeChart.Maui.Hosting.AppHostBuilderExtensions.ConfigureTeeChart(builder);

        return builder.Build();
	}
}
