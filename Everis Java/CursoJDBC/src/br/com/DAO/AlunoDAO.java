package br.com.DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import br.com.ConexaoJDBC.Conexao;
import br.com.model.Aluno;

public class AlunoDAO {
	
	public List<Aluno> list() throws SQLException{
		ArrayList<Aluno> alunos = new ArrayList<>();
		
		try(Connection conn = Conexao.getConnection()){
			String sql = "select * from aluno";
			
			PreparedStatement ps = conn.prepareStatement(sql);
			
			ResultSet rs = ps.executeQuery();
			
			while(rs.next()) {
				Aluno aluno = new Aluno(rs.getInt("id"),rs.getString("nome"), rs.getInt("idade"), rs.getString("estado"));
				alunos.add(aluno);
			}
			
			
		}
		catch (Exception e) {
			// TODO: handle exception
		}
		return alunos;
	}
	
	public Aluno listbyID(int id) throws SQLException{
		Aluno aluno = null;
		try(Connection conn = Conexao.getConnection()){
			String sql = "select * from aluno where id = ?";
			
			PreparedStatement ps = conn.prepareStatement(sql);
			ps.setInt(1, id);
			
			ResultSet rs = ps.executeQuery();
			
			while(rs.next()) {
				aluno = new Aluno(rs.getInt("id"),rs.getString("nome"), rs.getInt("idade"), rs.getString("estado"));
				
			}
		}
		catch (Exception e) {
			// TODO: handle exception
		}
		return aluno;
	}
	public void insert (Aluno aluno) {
		try(Connection conn = Conexao.getConnection()){
			String sql = "insert into aluno(nome,idade,estado) values(?,?,?)";
			
			PreparedStatement ps = conn.prepareStatement(sql);
			ps.setString(1, aluno.getNome());
			ps.setInt(2, aluno.getIdade());
			ps.setString(3, aluno.getEstado());
			ps.executeUpdate();
		}
		catch (Exception e) {
			// TODO: handle exception
		}
	}
	public void delete(int id) {
		try(Connection conn = Conexao.getConnection()){
			String sql = "delete from aluno where id = ?";
			
			PreparedStatement ps = conn.prepareStatement(sql);
			ps.setInt(1, id);
			ps.executeUpdate();
		}
		catch (Exception e) {
			// TODO: handle exception
		}
	}
	public void atualizar (int id,Aluno aluno) {
		try(Connection conn = Conexao.getConnection()){
			String sql = "update aluno set nome = ?,idade = ?,estado = ? where id = ?";
			
			PreparedStatement ps = conn.prepareStatement(sql);
			ps.setString(1, aluno.getNome());
			ps.setInt(2, aluno.getIdade());
			ps.setString(3, aluno.getEstado());
			ps.setInt(4, id);
			ps.executeUpdate();
		}
		catch (Exception e) {
			// TODO: handle exception
		}
	}
	public void deleteall() {
		try(Connection conn = Conexao.getConnection()){
			String sql = "delete from aluno";
			
			PreparedStatement ps = conn.prepareStatement(sql);
			ps.executeUpdate();
		}
		catch (Exception e) {
			// TODO: handle exception
		}
	}
}
