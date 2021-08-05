package br.com.model;

import java.sql.SQLException;
import java.util.List;
import java.util.Scanner;

import br.com.DAO.AlunoDAO;

public class QueryExecution {

	public static void main(String[] args) throws SQLException {
		AlunoDAO alunodao = new AlunoDAO();
		List<Aluno> alunos;
		int id;
		String op,nome,estado;
		Scanner in = new Scanner(System.in);
		while(true) {
			menu();
			op = in.nextLine();
			switch (op) {
			case "1": 
				alunos = alunodao.list();
				if(alunos.size() == 0) {
					System.out.println("Nenhum nome para listar");
				}
				else {
					for(int i = 0; i < alunos.size();i++) {
						System.out.println(alunos.get(i).getId() + "-" + 
					    alunos.get(i).getNome() + "-" + alunos.get(i).getIdade() + "-" +
					    alunos.get(i).getEstado());
					}
				}
			break;
			case "2":
				nome = in.nextLine();
				int idade = in.nextInt();
				estado = in.next();
				Aluno aluno = new Aluno(nome, idade, estado);
				alunodao.insert(aluno);
			break;
			case "3":
				boolean existe = false;
				id = in.nextInt();
				alunos = alunodao.list();
				if(alunos.size() == 0) {
					System.out.println("Nenhum nome para atualizar");
				}
				else {
					for(int i = 0; i < alunos.size();i++) {
						if(alunos.get(i).getId() == id) {
							existe = true;
						}
					}
					if(!existe) {
						System.out.println("Nao existe esse id para atualizar");
					}
					else {
							nome = in.nextLine();
							int idadea = in.nextInt();
							estado = in.next();
							Aluno alunoA = new Aluno(nome, idadea, estado);
							alunodao.atualizar(id, alunoA);
					}
				}
			break;
			case "4":
				boolean existes = false;
				id = in.nextInt();
				alunos = alunodao.list();
				if(alunos.size() == 0) {
					System.out.println("Nenhum nome para excluir");
				}
				else {
					for(int i = 0; i < alunos.size();i++) {
						if(alunos.get(i).getId() == id) {
							existes = true;
						}
					}
					if(!existes) {
						System.out.println("Nao existe esse id para excluir");
					}
					else {
							alunodao.delete(id);
					}
				}
			break;
			case "5":
				
				alunos = alunodao.list();
				if(alunos.size() == 0) {
					System.out.println("Nenhum nome para excluir");
				}
				else {
					alunodao.deleteall();
				}
			break;
			case "6":
				System.exit(0);
			break;
			default:
				System.out.println("Opcao invalida");
				break;
			}
			
		}
		
	}
	
	public static void menu(){
		System.out.println("1-Listar");
		System.out.println("2-Cadastrar");
		System.out.println("3-Atualizar");
		System.out.println("4-Deletar");
		System.out.println("5-Deletar tudo");
		System.out.println("6-Sair");
		System.out.print("Escolha sua opção:");
		}

}


