using Microsoft.EntityFrameworkCore;
using VetSoft_EF;
using Microsoft.Extensions.Logging;
using VetSoft_Aldera.Views;

namespace VetSoft_Aldera;

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


    
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddDbContext<VetSoft_EF.KundeContext>();
        builder.Services.AddTransient<KundenView>();
        builder.Services.AddTransient<KundenEingabe>();


        var provider = builder.Services.BuildServiceProvider();
        return builder.Build();
	}
   
}
