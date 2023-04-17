namespace LiturgiaDasHoras
{
    [QueryProperty(nameof(Path), nameof(Path))]
    [QueryProperty(nameof(Hour), nameof(Hour))]
    public partial class HourPageViewModel : ObservableObject
    {
        #region Properties
        public string Path { get; set; }
        public string Hour { get; set; }
        #endregion

        #region Commands
        [RelayCommand]
        async Task OpenInvitingAsync() => await Shell.Current.GoToAsync($"{nameof(InvitingPage)}");
        [RelayCommand]
        async Task GoBackAsync() => await Shell.Current.GoToAsync("..", true);
        #endregion

        #region Ctor
        public HourPageViewModel()
        {

        }

        #endregion


    }
}
