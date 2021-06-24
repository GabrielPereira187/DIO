/*
 * Created by SharpDevelop.
 * User: gdeba
 * Date: 24/06/2021
 * Time: 08:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Series
{
	class Program
	{
		static SerieRepositorio repositorio = new SerieRepositorio();
		public static void Main(string[] args)
		{
			String op = opUsuario();
			
			while(op.ToUpper() != "X"){
				switch(op){
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
//					case "3":
//						Atualiza();
//						break;
//					case "4":
//						Exclui();
//						break;
//					case "5":
//						VisualizarSeries();
//						break;
					case "C":
						Console.Clear();
						break;
					default:
						Console.WriteLine("Opcao invalida");
						break;
				}
				op = opUsuario();
			}
			
			
		}
		private static string opUsuario(){
			Console.WriteLine("");
			Console.WriteLine("Digite a opção desejada");
			
			Console.WriteLine("1-Listar Series");
			Console.WriteLine("2-Inserir");
			Console.WriteLine("3-Atualizar");
			Console.WriteLine("4-Excluir");
			Console.WriteLine("5-Visualizar Serie");
			Console.WriteLine("C-Limpar Tela");
			Console.WriteLine("X-Sair");
			
			String op = Console.ReadLine().ToUpper();
			return op;
		}
		
		private static void ListarSeries(){
			var lista = repositorio.Lista();
			
			if(lista.Count == 0){
				Console.WriteLine("Nenhuma serie cadastrada");
				return;
			}
			foreach(var serie in lista){
				Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
			}
		}
		private static void InserirSerie(){
			Console.WriteLine("Inserir nova Série");
			
			foreach(int i in Enum.GetValues(typeof(Genero))){
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));
			}
			Console.WriteLine("Digite o Genero");
			int entradaGenero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o Titulo");
			string entradatitulo = Console.ReadLine();
			
			Console.WriteLine("Digite a descricao");
			string entradaDesc = Console.ReadLine();
			
			Console.WriteLine("Digite o ano");
			int entradaano = int.Parse(Console.ReadLine());
			
			Serie novaSerie = new Serie(id: repositorio.proximoId(),
			                            genero: (Genero)entradaGenero,
			                            titulo: entradatitulo,
			                            desc : entradaDesc,
			                            ano: entradaano);
			repositorio.Insere(novaSerie);
		}
		private static void Atualiza(){
			Console.WriteLine("Digite o id da serie:");
			int entradaID = int.Parse(Console.ReadLine());
			foreach(int i in Enum.GetValues(typeof(Genero))){
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));
			}
			Console.WriteLine("Digite o Genero");
			int entradaGenero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o Titulo");
			string entradatitulo = Console.ReadLine();
			
			Console.WriteLine("Digite a descricao");
			string entradaDesc = Console.ReadLine();
			
			Console.WriteLine("Digite o ano");
			int entradaano = int.Parse(Console.ReadLine());
			
			Serie novaSerie = new Serie(id: entradaID,
			                            genero: (Genero)entradaGenero,
			                            titulo: entradatitulo,
			                            desc : entradaDesc,
			                            ano: entradaano);
			repositorio.Atualiza(entradaID, novaSerie);
		}
		
		private static void visualizarSeries(){
			Console.WriteLine("Digite o id da serie:");
			int entradaID = int.Parse(Console.ReadLine());
			
			var Serie = repositorio.RetornaPorId(entradaID);
			
			Console.WriteLine(Serie);
		}
		
		private static void Exclui(){
			Console.WriteLine("Digite o id da serie:");
			int entradaID = int.Parse(Console.ReadLine());
			
			repositorio.Exclui(entradaID);
		}
	}
}