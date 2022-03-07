namespace DIO.Series
{
    public class Serie : EntridadeBase
    {
        private Genero Genero{get;set;}
        private string Titulo{get;set;}
        private string Descricao{get;set;}
        private string Ano {get;set;}


        public Series(int id,Genero genero, string titulo, string descricao, string ano)
        {
            this.Id=id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}
        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
    }
}
