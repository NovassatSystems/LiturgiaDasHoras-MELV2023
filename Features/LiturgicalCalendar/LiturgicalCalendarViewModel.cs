namespace LiturgiaDasHoras
{
    public partial class LiturgicalCalendarViewModel : ObservableObject
    {
        #region Service
        readonly LiturgicalCalendarService _liturgicalCalendarService;
        #endregion

        #region Properties

        [ObservableProperty]
        public List<LiturgicalDay> days;

        [ObservableProperty]
        public LiturgicalDay selectedDay;

        #endregion

        #region Commands
        [RelayCommand]
        void GoBack() => Shell.Current.GoToAsync("..");

        public ICommand SelectLiturgicalDayCommand { get; }

        [RelayCommand]
        async Task SelectDay(LiturgicalDay liturgicalDay)
        {
            var data = new Dictionary<string, object>();
            data.Add("LiturgicalDaySelected", liturgicalDay);
            StaticProperties.LiturgicalDay = liturgicalDay;
            await Shell.Current.GoToAsync($"..?liturgicalDayDate={liturgicalDay.Date.ToString()}");
        }
        #endregion

        public LiturgicalCalendarViewModel(LiturgicalCalendarService liturgicalCalendar)
        {
            _liturgicalCalendarService = liturgicalCalendar;
            SelectLiturgicalDayCommand = new Command<LiturgicalDay>(async (day) => await SelectLiturgicalDayCommandExecute(day));
            Initialize();
        }

        async Task SelectLiturgicalDayCommandExecute(LiturgicalDay day)
        {
            var data = new Dictionary<string, object>();
            data.Add("LiturgicalDaySelected", day);

            await Shell.Current.GoToAsync($"..",true, data);
        }

        internal Task Initialize()
        {
            GetLiturgicalDays();
            return Task.CompletedTask;
        }

        public void GetLiturgicalDays()
        {
            //MainThread.BeginInvokeOnMainThread(async () => {
            //    await Task.Delay(3000);
            //    Days = _liturgicalCalendarService.GetLiturgicalDays();
            //});
            Days = StaticProperties.LiturgicalDayList;
        }
    }
}
