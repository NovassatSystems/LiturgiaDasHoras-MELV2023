using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using SkiaSharp.Views.Maui.Controls.Hosting;

//ALIAS KEYSTOPRE = oasis2023_1grau
//PWDKeystore = Drmfsls33#

namespace LiturgiaDasHoras;


public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureServices()
            .UseSkiaSharp()
            .ConfigurePages()
            .ConfigureViewModels()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("JosefinSansLight.ttf", "JoseLight");
                fonts.AddFont("JosefinSansRegular.ttf", "JoseRegular");
                fonts.AddFont("JosefinSansSemiBold.ttf", "JoseSemiBold");
                fonts.AddFont("Neuton.ttf", "Cursiva");
                fonts.AddFont("Caps.ttf", "Initial");
                fonts.AddFont("Liturgia.ttf", "Liturgia");
            });

        return builder.Build();
    }
}
