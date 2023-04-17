using LiturgiaDasHoras;

internal static class MauiProgramExtensions
{

    public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<HourPage>();
        builder.Services.AddSingleton<InvitingPage>();
        builder.Services.AddSingleton<LiturgicalCalendarPage>();
        return builder;
    }
    public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<LiturgicalCalendarService>();
        return builder;
    }

    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<HourPageViewModel>();
        builder.Services.AddSingleton<InvitingPageViewModel>();
        builder.Services.AddSingleton<LiturgicalCalendarViewModel>();
        return builder;
    }
}