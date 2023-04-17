namespace LiturgiaDasHoras;

public partial class MemoryPopupPage : CommunityToolkit.Maui.Views.Popup
{
	public MemoryPopupPage()
	{
		InitializeComponent();
	}

    protected override void OnDismissedByTappingOutsideOfPopup() => Close();

    void OnYesButtonClicked(object? sender, EventArgs e) => Close(true);

    void OnNoButtonClicked(object? sender, EventArgs e) => Close(false);
}