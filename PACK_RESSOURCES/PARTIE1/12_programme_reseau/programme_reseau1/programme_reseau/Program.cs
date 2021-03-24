using System;
using System.Net;

namespace programme_reseau
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://codeavecjonathan.com/res/pizzas1.json";

            var webClient = new WebClient();

            Console.WriteLine("Accès au réseau...");
            string reponse = webClient.DownloadString(url);
            Console.WriteLine(reponse); 
        }
    }
}
