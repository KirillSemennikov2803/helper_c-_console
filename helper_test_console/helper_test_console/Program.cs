using System;
using RestSharp;
using RestSharp.Authenticators;
using System.Text.Json;
using User;
namespace helper_test_console
{
    class Program
    {
        
        static void Main(string[] args)
        {


            var client = new RestClient("http://127.0.0.1:8000/auth");

            User.User_db_web tom = new User.User_db_web { login = "admin", password_hash = "c4ca4238a0b923820dcc509a6f75849b" };
            string json = JsonSerializer.Serialize<User.User_db_web>(tom);
            var request = new RestRequest();
            request.AddJsonBody(json);
            var response = client.Post(request);
            Console.WriteLine(json);
            var a = 1;

        }
    }
}
