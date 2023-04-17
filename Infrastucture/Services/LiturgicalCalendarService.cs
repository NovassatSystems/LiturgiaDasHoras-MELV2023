namespace LiturgiaDasHoras
{
    public class LiturgicalCalendarService
    {
        public List<LiturgicalDay> GetLiturgicalDays()
        {
            var list =  new List<LiturgicalDay>()
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

            return list;
        }
        public LiturgicalDay GetLiturgicalDay(DateTime date)
        {
            if (date.Month != 1 || date.Month == 1 && date.Day < 10 || date.Month == 1 && date.Day > 26)
            {
                if(date.Month == 12 && date.Year == 2022)
                {
                    switch (date.Day)
                    {
                        case 21:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Roxa,
                                Nome = "4quarta",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                        case 22:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                        case 23:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                        case 24:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                        case 25:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                        case 26:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                            case 27:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                            case 28:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };  
                            case 29:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                            case 30:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                            case 31:
                            return new LiturgicalDay
                            {
                                Estola = Stole.Verde,
                                Nome = "1terca",
                                Path = "oficio/tempocomum/horas",
                                SemanaAtual = 1,
                                Date = new DateTime(2023, 01, 10),
                                Title = "1ª Semana do Tempo Comum"
                            };
                        default:
                            break;
                    }
                }
                return null;
            }
            switch (date.Day)
            {
                case 10:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "1terca",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 1,
                        Date = new DateTime(2023, 01, 10),
                        Title = "1ª Semana do Tempo Comum"
                    };
                case 11:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "1quarta",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 1,
                        Date = new DateTime(2023, 01, 11),
                        Title = "1ª Semana do Tempo Comum"
                    };
                case 12:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "1quinta",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 1,
                        Date = new DateTime(2023, 01, 12),
                        Title = "1ª Semana do Tempo Comum"
                    };
                case 13:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "1sexta",
                        Path = "oficio/tempocomum/horas",
                        TemMemoria = true,
                        MemoriaEstola = Stole.Branca,
                        MemoriaNome = "1sexta",
                        MemoriaPath = "oficio/tempocomum/horas",
                        MemoriaTitulo = "SANTO HILÁRIO, BISPO E DOUTOR DA IGREJA",
                        MemoriaSubTitulo = "(Do Comum dos pastores: para bispos, e doutores da igreja)",
                        SemanaAtual = 1,
                        Date = new DateTime(2023, 01, 13),
                        Title = "1ª Semana do Tempo Comum"
                    };
                case 14:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "1sabado",
                        Path = "oficio/tempocomum/horas",
                        TemMemoria = true,
                        MemoriaEstola = Stole.Branca,
                        MemoriaNome = "santamarianosabado",
                        MemoriaPath = "oficio/proprio/horas",
                        MemoriaTitulo = "NOSSA SENHORA NO SÁBADO",
                        SemanaAtual = 1,
                        Date = new DateTime(2023, 01, 14),
                        Title = "1ª Semana do Tempo Comum"
                    };
                case 15:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "2domingo",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 2,
                        Date = new DateTime(2023, 01, 15),
                        Title = "2ª Semana do Tempo Comum"
                    };
                case 16:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "2segunda",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 2,
                        Date = new DateTime(2023, 01, 16),
                        Title = "2ª Semana do Tempo Comum"
                    };
                case 17:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Branca,
                        TemMemoria = true,
                        MemoriaObrigatoria = true,
                        MemoriaNome = "2terca",
                        MemoriaPath = "oficio/tempocomum/horas",
                        MemoriaEstola = Stole.Branca,
                        MemoriaTitulo = "SANTO ANTÃO, ABADE",
                        MemoriaSubTitulo = "Memória",
                        SemanaAtual = 2,
                        Date = new DateTime(2023, 01, 17),
                        Title = "2ª Semana do Tempo Comum"
                    };
                case 18:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "2quarta",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 2,
                        Date = new DateTime(2023, 01, 18),
                        Title = "2ª Semana do Tempo Comum"
                    };
                case 19:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "2quinta",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 2,
                        Date = new DateTime(2023, 01, 19),
                        Title = "2ª Semana do Tempo Comum"
                    };
                case 20:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "2sexta",
                        Path = "oficio/tempocomum/horas",
                        TemMemoria = true,
                        MemoriaEstola = Stole.Vermelha,
                        MemoriaNome = "saosebastiao",
                        MemoriaPath = "oficio/proprio/horas",
                        MemoriaTitulo = "SÃO SEBASTIÃO, MÁRTIR",
                        MemoriaSubTitulo = "(Do Comum de um(a) mártir)",
                        SemanaAtual = 2,
                        Date = new DateTime(2023, 01, 20),
                        Title = "2ª Semana do Tempo Comum"
                    };
                case 21:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Vermelha,
                        TemMemoria = true,
                        MemoriaObrigatoria = true,
                        MemoriaNome = "santaines",
                        MemoriaPath = "oficio/proprio/horas",
                        MemoriaEstola = Stole.Vermelha,
                        MemoriaTitulo = "SANTA INÊS, VIRGEM E MÁRTIR",
                        MemoriaSubTitulo = "(Do Comum de um(a) mártir)",
                        SemanaAtual = 2,
                        Date = new DateTime(2023, 01, 21),
                        Title = "2ª Semana do Tempo Comum"
                    };
                case 22:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "3domingo",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 3,
                        Date = new DateTime(2023, 01, 22),
                        Title = "3ª Semana do Tempo Comum"
                    };
                case 23:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Verde,
                        Nome = "3segunda",
                        Path = "oficio/tempocomum/horas",
                        SemanaAtual = 3,
                        Date = new DateTime(2023, 01, 23),
                        Title = "3ª Semana do Tempo Comum"
                    };
                case 24:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Branca,
                        TemMemoria = true,
                        MemoriaObrigatoria = true,
                        MemoriaNome = "3terca",
                        MemoriaPath = "oficio/tempocomum/horas",
                        MemoriaEstola = Stole.Branca,
                        MemoriaTitulo = "SÃO FRANCISCO DE SALES, BISPO E DOUTOR DA IGREJA",
                        MemoriaSubTitulo = "(Do Comum dos pastores: para bispos, e doutores da Igreja)",
                        SemanaAtual = 3,
                        Date = new DateTime(2023, 01, 24),
                        Title = "3ª Semana do Tempo Comum"
                    };
                case 25:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Branca,
                        TemMemoria = true,
                        MemoriaObrigatoria = true,
                        MemoriaNome = "conversaosaopaulo",
                        MemoriaPath = "oficio/proprio/horas",
                        MemoriaEstola = Stole.Branca,
                        MemoriaTitulo = "CONVERSÃO DE SÃO PAULO APÓSTOLO",
                        MemoriaSubTitulo = "Festa",
                        SemanaAtual = 3,
                        Date = new DateTime(2023, 01, 25),
                        Title = "3ª Semana do Tempo Comum"
                    };
                case 26:
                    return new LiturgicalDay
                    {
                        Estola = Stole.Branca,
                        TemMemoria = true,
                        MemoriaObrigatoria = true,
                        MemoriaNome = "3quinta",
                        MemoriaPath = "oficio/tempocomum/horas",
                        MemoriaEstola = Stole.Branca,
                        MemoriaTitulo = "SÃO TIMÓTEO E SÃO TITO, BISPOS",
                        MemoriaSubTitulo = "(Do Comum dos pastores: para bispos)",
                        SemanaAtual = 3,
                        Date = new DateTime(2023, 01, 26),
                        Title = "3ª Semana do Tempo Comum"
                    };
                default:
                    return null;
            }
        }
    }
}
