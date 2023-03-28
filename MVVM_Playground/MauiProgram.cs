using Microsoft.Extensions.Logging;

namespace MVVM_Playground;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<BaseViewModel>(); // Needed for MVVM stuff to work
		builder.Services.AddTransient<MainPage>(); // Needed for MVVM stuff to work

		return builder.Build();
	}
}
