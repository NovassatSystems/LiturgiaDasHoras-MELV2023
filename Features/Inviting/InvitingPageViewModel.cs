namespace LiturgiaDasHoras
{
    public partial class InvitingPageViewModel : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        public string source = $"oficio/invitatorio/invitatorio94s.html";

        [ObservableProperty]
        public string psalm = "94";
        #endregion

        #region Commands
        [RelayCommand]
        void ChangePsalm(string salmo)
        {
            Psalm = salmo;
            Source = $"oficio/invitatorio/invitatorio{salmo}s.html";
        }

        [RelayCommand]
        async Task GoBackAsync() => await Shell.Current.GoToAsync("..", true);

        #endregion
    }
}
