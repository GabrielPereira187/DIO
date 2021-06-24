
using System;

namespace Series
{
	public class Serie
	{
		
		
		private int Id{get; set;}
		
		private Genero Genero{get; set;}
		
		private String Titulo{get; set;}
		
		private String Descricao{get; set;}
		
		private int Ano{get; set;}
		
		private bool Excluido;
		
		public Serie(int id, Genero genero, String titulo,String desc, int ano )
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = desc;
			this.Ano = ano;
			this.Excluido = false;
		}
		
		
		public override string ToString()
		{
			String retorno = "";
			retorno += "Genero: " + this.Genero +Environment.NewLine;
			retorno += "Titulo: " + this.Titulo + Environment.NewLine;
			retorno += "Descricao: " + this.Descricao + Environment.NewLine;
			retorno += "Ano: " + this.Ano + Environment.NewLine;
			retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

		public int retornaId(){
			return this.Id;
		}
		
		public String retornaTitulo(){
			return this.Titulo;
		}
		
		public void Excluir(){
			this.Excluido = true;
		}
	}
}
