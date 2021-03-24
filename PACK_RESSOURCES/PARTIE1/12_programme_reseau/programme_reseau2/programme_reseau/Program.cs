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
            try
            {
                string reponse = webClient.DownloadString(url);
                Console.WriteLine(reponse);
            }
            catch(WebException ex)
            {
                if (ex.Response != null)
                {
                    var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                    if (statusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine("ERREUR RESEAU : Non trouvé");
                    }
                    else
                    {
                        Console.WriteLine("ERREUR RESEAU : " + statusCode);
                    }
                }
                else
                {
                    Console.WriteLine("ERREUR RESEAU : " + ex.Message);
                }
            }
            
        }
    }
}
