using System;

public class HelperHttpClient
{

	public HelperHttpClient()
	{

	}

	async static Boolean auth()
    {
		var client = new RestClient("http://127.0.0.1:8000/auth");
	}
}
