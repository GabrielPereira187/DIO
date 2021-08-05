package com.dio.springbootconfig.config;

import org.springframework.boot.context.properties.ConfigurationProperties;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Profile;

import lombok.Getter;
import lombok.Setter;



@Getter
@Setter
@Configuration
@ConfigurationProperties("spring.datasource")
public class DBConfiguration {
	private String driverClassName;
	private String url;
	private String password;
	private String username;
	
	
	@Profile("dev")
	@Bean
	public String testeDataBaseConnection() {
		System.out.println("DB connection for dev");
		System.out.println(driverClassName);
		System.out.println(url);
		return "Conexao de banco - dev";
	}
	
	@Profile("prod")
	@Bean
	public String testeDataBaseConnectionprod() {
		System.out.println("DB connection for prod");
		System.out.println(driverClassName);
		System.out.println(url);
		return "Conexao de banco - prod";
	}
}
