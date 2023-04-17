namespace LiturgiaDasHoras
{
    public class LiturgicalDay
    {
        public string Path { get; set; }
        public string Nome { get; set; }
        public Stole Estola { get; set; }

        public string MemoriaPath { get; set; }
        public string MemoriaNome { get; set; }
        public Stole MemoriaEstola { get; set; }

        public bool TemMemoria { get; set; }
        public bool MemoriaObrigatoria { get; set; }
        public string MemoriaTitulo { get; set; }
        public string MemoriaSubTitulo { get; set; }

        public int SemanaAtual { get; set; }

        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
