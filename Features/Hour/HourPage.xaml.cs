namespace LiturgiaDasHoras;

public partial class HourPage : ContentPage
{
	HourPageViewModel vm => BindingContext as HourPageViewModel;
	public HourPage(HourPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

        Routing.RegisterRoute(nameof(InvitingPage), typeof(InvitingPage));
    }

    protected override void OnAppearing()
    {
        webView.Source = vm.Path;
        frameInviting.IsVisible = vm.Hour == "0";
        framePath.Margin = vm.Hour == "0" ? new Thickness(0, 16) : new Thickness(0, 0, 0, 16);
        imageButton.IsVisible = vm.Hour != "0";
        base.OnAppearing();
    }
}