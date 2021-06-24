/*
 * Created by SharpDevelop.
 * User: gdeba
 * Date: 24/06/2021
 * Time: 09:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
		private List<Serie> listaSerie = new List<Serie>();
		
		public void Atualiza(int id, Serie serie ){
			listaSerie[id] = serie;
		}
		
		public void Insere(Serie serie ){
			listaSerie.Add(serie);
		}
		public void Exclui(int id){
			listaSerie[id].Excluir();
		}
		
		public List<Serie> Lista(){
			return listaSerie;
		}
		
		public int proximoId(){
			return listaSerie.Count;
		}
		
		public Serie RetornaPorId(int id){
			return listaSerie[id];
		}
	}
}
