package br.com.ConexaoJDBC;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Conexao {

	public static Connection getConnection() throws SQLException {
		
		
		String driver = "mysql";
		String databaseAdress = "localhost";
		String dbName = "cursoJDBA";
		String user = "root";
		String password = "password";
		
		StringBuilder sb = new StringBuilder("jdbc:")
				.append(driver).append("://")
				.append(databaseAdress)
				.append("/").append(dbName);
		
		String urlConnection = sb.toString();
		Connection conn = null;
		conn = DriverManager.getConnection(urlConnection,user,password);
		return conn;
	}

}
