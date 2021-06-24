/*
 * Created by SharpDevelop.
 * User: gdeba
 * Date: 24/06/2021
 * Time: 09:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Series
{
	/// <summary>
	/// Description of IRepositorio.
	/// </summary>
	public interface IRepositorio<T>
	{
		List<T>Lista();
		
		T RetornaPorId(int id);
		
		void Insere(T serie);
		
		void Exclui(int id);
		
		void Atualiza(int id, T serie);
		
		int proximoId();
		
	}
}
