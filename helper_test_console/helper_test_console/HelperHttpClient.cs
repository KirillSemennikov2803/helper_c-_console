﻿using RestSharp;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using User;
public enum HttpAnswer
{
	auth_error,
	server_is_not_available,
	internal_server_error,
	success
}
public class HelperHttpClient
{

	public HelperHttpClient()
	{

	}

	public static HttpAnswer auth(string login,string password_hash)
    {
		User.User_db_web tom = new User.User_db_web { login = login, password_hash = password_hash };
		var client = new RestClient("http://127.0.0.1:8000/auth");
		string json = JsonSerializer.Serialize<User.User_db_web>(tom);
		var request = new RestRequest()
			.AddJsonBody(json);
		var response = client.Post(request);
		return HttpAnswer.success;
	}
}
