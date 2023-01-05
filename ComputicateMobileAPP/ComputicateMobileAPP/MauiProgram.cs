using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using ComputicateMobileAPP.ViewModel;
using ComputicateMobileAPP.Views;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Mopups.Hosting;

namespace ComputicateMobileAPP;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

        builder.Services.AddSingleton<AppShell>();
        //resolving services for Method-1
        builder.Services.AddTransient<DashboardPage>();
        builder.Services.AddTransient<TimeEntriesPage>();
        builder.Services.AddSingleton<TimeEntriesVM>();

        builder
			.UseMauiApp<App>()
			.ConfigureMopups()
			.UseMauiCommunityToolkit()
			.UseMauiCommunityToolkitMarkup()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Inter-Regular.ttf", "InterRegular");
				fonts.AddFont("Inter-Bold.ttf", "InterBold");
                fonts.AddFont("Inter-Medium.ttf", "InterMedium");
            });
        


        return builder.Build();
	}
}
