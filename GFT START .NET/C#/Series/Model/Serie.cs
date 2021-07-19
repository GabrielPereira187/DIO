namespace Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero{get; set;}

        private String Titulo { get; set; }

        private String Descricao { get; set; }

        private int Ano { get; set; }

        public Serie(int id, Genero genero, String titulo, String descricao,int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }


    }
}