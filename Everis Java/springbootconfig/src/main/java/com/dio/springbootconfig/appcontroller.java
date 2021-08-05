package com.dio.springbootconfig;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;


@RestController
public class appcontroller {
	
	
	@Value("${ENV_DB_URL:NENHUMA}")
	private String environmentVariable;
	
	
	@Value("${app.message}")
	private String appMessage;
	@GetMapping("/")
	public String getAppMessage() {
		return appMessage;
	}
	
	@GetMapping("/envVariable")
	public String getEnvironmentMessage() {
		return "Foi passada a variavel  " + environmentVariable;
	}
	
}
