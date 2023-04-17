namespace LiturgiaDasHoras;

public partial class InvitingPage : ContentPage
{
	InvitingPageViewModel vm => BindingContext as InvitingPageViewModel;
	public InvitingPage(InvitingPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

	}
}