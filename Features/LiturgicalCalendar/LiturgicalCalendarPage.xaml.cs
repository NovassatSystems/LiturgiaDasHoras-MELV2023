namespace LiturgiaDasHoras;

public partial class LiturgicalCalendarPage : ContentPage
{
	LiturgicalCalendarViewModel vm => BindingContext as LiturgicalCalendarViewModel;
	public LiturgicalCalendarPage(LiturgicalCalendarViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}