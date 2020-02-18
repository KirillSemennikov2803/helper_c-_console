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

            var anser = HelperHttpClient
                 .HelperHttpClient
                 .auth("admin", "c4ca4238a0b923820dcc509a6f75849b");
            Console.WriteLine(anser); 

        }
    }
}
