namespace LiturgiaDasHoras
{
    [QueryProperty(nameof(liturgicalDayDate), "liturgicalDayDate")]
    public partial class HomePageViewModel : ObservableObject
    {
        #region Service
        readonly LiturgicalCalendarService _liturgicalCalendarService;
        #endregion

        #region Properties
        [ObservableProperty]
        public DateTime today;

        [ObservableProperty]
        public LiturgicalDay liturgicalDay;

        [ObservableProperty]
        public string liturgicalDayDate;

        [ObservableProperty]
        public bool retreatNotStarted;
        #endregion

        #region Commands
        [RelayCommand]
        async Task OpenHourAsync(string hour)
        {
            if (RetreatNotStarted && LiturgicalDay == null)
            {
                await App.Current.MainPage.DisplayAlert("oOps", "O retiro ainda não iniciou, mas você ainda pode olhar a liturgia das horas de outros dias clicando na Agenda na parte superior do App", "OK");
                return;
            }
            var lastPart = string.Empty;
            var path = string.Empty;

            switch (hour)
            {
                case "0":
                    lastPart = "_laudes.htm"; break;
                case "1":
                    lastPart = "_terca.htm"; break;
                case "2":
                    lastPart = "_sexta.htm"; break;
                case "3":
                    lastPart = "_nona.htm"; break;
                case "4":
                    lastPart = "_vesperas.htm"; break;
                case "5":
                    lastPart = "completas_";
                    
                    break;
                default:
                    break;
            }

            

                var dayname = LiturgicalDay.MemoriaObrigatoria ? LiturgicalDay.MemoriaNome :LiturgicalDay.Nome;
                path = $"{LiturgicalDay.Path}/{dayname}{lastPart}";

            if (LiturgicalDay != null && LiturgicalDay.TemMemoria && (hour == "0" || hour == "4") && !LiturgicalDay.MemoriaObrigatoria)
            {

                var popup = new MemoryPopupPage();
                var result = await Application.Current.MainPage.ShowPopupAsync(popup);
                if(result is bool memory)
                {
                    dayname = memory ? LiturgicalDay.MemoriaNome : LiturgicalDay.Nome;
                    path = memory ? $"{LiturgicalDay.MemoriaPath}/{dayname}{lastPart}" : $"{LiturgicalDay.Path}/{dayname}{lastPart}";
                }
                

            }

            if (LiturgicalDay.MemoriaObrigatoria)
                path = $"{LiturgicalDay.MemoriaPath}{lastPart}";

            if (hour == "5")
            {
                var splitted = LiturgicalDay.Date.ToString("dddd").Split('-');

                var sufix = splitted[0];
                sufix = sufix == "terça" ? "terca" : sufix;
                path = $"{LiturgicalDay.Path}/{lastPart}{sufix}.htm";
            }

            await Shell.Current.GoToAsync($"{nameof(HourPage)}?Path={path}&Hour={hour}");
        }

        [RelayCommand]
        async Task OpenListHoursAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(LiturgicalCalendarPage)}", true);
        }
        #endregion

        public HomePageViewModel(LiturgicalCalendarService liturgicalCalendar)
        {
            Today = DateTime.Today;
            _liturgicalCalendarService = liturgicalCalendar;
            Initialize();
        }

        internal Task Initialize()
        {
            RetreatNotStarted = false;
            if(Today.Day < 10 && Today.Month == 1)
            {
                RetreatNotStarted = true;
            }
            if (StaticProperties.LiturgicalDay != null)
            {
                var date = StaticProperties.LiturgicalDay.Date;
                GetDiaLiturgico(new DateTime(date.Year, date.Month, date.Day));
                RetreatNotStarted = false;
                return Task.CompletedTask;
            }
            GetDiaLiturgico(Today);
            return Task.CompletedTask;
        }

        public void GetDiaLiturgico(DateTime? dateTime = null)
        {

            if (dateTime == null)
                dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            LiturgicalDay = _liturgicalCalendarService.GetLiturgicalDay(dateTime.Value);
        }
    }
}
