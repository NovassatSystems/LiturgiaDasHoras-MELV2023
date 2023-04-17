namespace LiturgiaDasHoras;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

    }

    public static class StaticProperties
    {
        public static LiturgicalDay LiturgicalDay { get; set; }
        public static List<LiturgicalDay> LiturgicalDayList = new List<LiturgicalDay>()
        {
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "1terca", Path = "oficio/tempocomum/horas/1terca",
                SemanaAtual = 1,
                Date = new DateTime(2023, 01, 10),
                Title = "1ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "1quarta",
                Path = "oficio/tempocomum/horas/1quarta",
                SemanaAtual = 1 ,
                Date = new DateTime(2023, 01, 11),
                Title = "1ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "1quinta",
                Path = "oficio/tempocomum/horas/1quinta",
                SemanaAtual = 1 ,
                Date = new DateTime(2023, 01, 12),
                Title = "1ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "1sexta",
                Path = "oficio/tempocomum/horas/1sexta",
                TemMemoria = true,
                MemoriaEstola = Stole.Branca,
                MemoriaNome = "1sexta",
                MemoriaPath = "oficio/tempocomum/horas/1sexta",
                MemoriaTitulo = "SANTO HILÁRIO, BISPO E DOUTOR DA IGREJA",
                MemoriaSubTitulo = "(Do Comum dos pastores: para bispos, e doutores da igreja)",
                SemanaAtual = 1,
                Date = new DateTime(2023, 01, 13),
                Title = "1ª Semana do Tempo Comum"
             },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "1sabado",
                Path = "oficio/tempocomum/horas/1sabado",
                TemMemoria = true,
                MemoriaEstola = Stole.Branca,
                MemoriaNome = "santamarianosabado",
                MemoriaPath = "oficio/proprio/horas/santamarianosabado",
                MemoriaTitulo = "NOSSA SENHORA NO SÁBADO",
                SemanaAtual = 1,
                Date = new DateTime(2023, 01, 14),
                Title = "1ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "2domingo",
                Path = "oficio/tempocomum/horas/2domingo",
                SemanaAtual = 2 ,
                Date = new DateTime(2023, 01, 15),
                Title = "2ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "2segunda",
                Path = "oficio/tempocomum/horas/2segunda",
                SemanaAtual = 2 ,
                Date = new DateTime(2023, 01, 16),
                Title = "2ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Branca,
                TemMemoria = true,
                MemoriaObrigatoria = true,
                MemoriaNome = "2terca",
                MemoriaPath = "oficio/tempocomum/horas/2terca",
                MemoriaEstola = Stole.Branca,
                MemoriaTitulo = "SANTO ANTÃO, ABADE",
                MemoriaSubTitulo = "Memória",
                SemanaAtual = 2,
                Date = new DateTime(2023, 01, 17),
                Title = "2ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "2quarta",
                Path = "oficio/tempocomum/horas/2quarta",
                SemanaAtual = 2,
                Date = new DateTime(2023, 01, 18),
                Title = "2ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "2quinta",
                Path = "oficio/tempocomum/horas/2quinta",
                SemanaAtual = 2 ,
                Date = new DateTime(2023, 01, 19),
                Title = "2ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "2sexta",
                Path = "oficio/tempocomum/horas/2sexta",
                TemMemoria = true,
                MemoriaEstola = Stole.Vermelha,
                MemoriaNome = "saosebastiao",
                MemoriaPath = "oficio/proprio/horas/saosebastiao",
                MemoriaTitulo = "SÃO SEBASTIÃO, MÁRTIR",
                MemoriaSubTitulo = "(Do Comum de um(a) mártir)",
                SemanaAtual = 2,
                Date = new DateTime(2023, 01, 20),
                Title = "2ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Vermelha,
                TemMemoria = true,
                MemoriaObrigatoria = true,
                MemoriaNome = "santaines",
                MemoriaPath = "oficio/proprio/horas/santaines",
                MemoriaEstola = Stole.Vermelha,
                MemoriaTitulo = "SANTA INÊS, VIRGEM E MÁRTIR",
                MemoriaSubTitulo = "(Do Comum de um(a) mártir)",
                SemanaAtual = 2,
                Date = new DateTime(2023, 01, 21),
                Title = "2ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "3domingo",
                Path = "oficio/tempocomum/horas/",
                SemanaAtual = 3 ,
                Date = new DateTime(2023, 01, 22),
                Title = "3ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Verde,
                Nome = "3segunda",
                Path = "oficio/tempocomum/horas/",
                SemanaAtual = 3 ,
                Date = new DateTime(2023, 01, 23),
                Title = "3ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Branca,
                TemMemoria = true,
                MemoriaObrigatoria = true,
                MemoriaNome = "3terca",
                MemoriaPath = "oficio/tempocomum/horas/3terca",
                MemoriaEstola = Stole.Branca,
                MemoriaTitulo = "SÃO FRANCISCO DE SALES, BISPO E DOUTOR DA IGREJA",
                MemoriaSubTitulo = "(Do Comum dos pastores: para bispos, e doutores da Igreja)",
                SemanaAtual = 3,
                Date = new DateTime(2023, 01, 24),
                Title = "3ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Branca,
                TemMemoria = true,
                MemoriaObrigatoria = true,
                MemoriaNome = "conversaosaopaulo",
                MemoriaPath = "oficio/proprio/horas/conversaosaopaulo",
                MemoriaEstola = Stole.Branca,
                MemoriaTitulo = "CONVERSÃO DE SÃO PAULO APÓSTOLO",
                MemoriaSubTitulo = "Festa",
                SemanaAtual = 3,
                Date = new DateTime(2023, 01, 25),
                Title = "3ª Semana do Tempo Comum"
            },
            new LiturgicalDay
            {
                Estola = Stole.Branca,
                TemMemoria = true,
                MemoriaObrigatoria = true,
                MemoriaNome = "3quinta",
                MemoriaPath = "oficio/tempocomum/horas/3quinta",
                MemoriaEstola = Stole.Branca,
                MemoriaTitulo = "SÃO TIMÓTEO E SÃO TITO, BISPOS",
                MemoriaSubTitulo = "(Do Comum dos pastores: para bispos)",
                SemanaAtual = 3,
                Date = new DateTime(2023, 01, 26),
                Title = "3ª Semana do Tempo Comum"
            }
        };
    }
}
