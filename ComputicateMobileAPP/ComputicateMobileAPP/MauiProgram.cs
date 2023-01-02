using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;

namespace ComputicateMobileAPP;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
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
