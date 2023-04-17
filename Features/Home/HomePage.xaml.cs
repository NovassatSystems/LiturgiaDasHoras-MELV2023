namespace LiturgiaDasHoras;

public partial class HomePage : ContentPage
{

    HomePageViewModel viewModel => BindingContext as HomePageViewModel;

    public HomePage(HomePageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;

        Routing.RegisterRoute(nameof(HourPage), typeof(HourPage));
        Routing.RegisterRoute(nameof(LiturgicalCalendarPage), typeof(LiturgicalCalendarPage));
    }

    protected override void OnAppearing()
    {
        viewModel.Initialize();
        base.OnAppearing();
    }

    

}

