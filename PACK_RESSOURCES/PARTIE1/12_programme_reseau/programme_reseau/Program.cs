using System;
using System.Net;

namespace programme_reseau
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://codeavecjonathan.com/res/papillon.jpg";

            var webClient = new WebClient();

            Console.WriteLine("Accès au réseau...");
            try
            {
                webClient.DownloadFile(url, "papillon.jpg");
                Console.WriteLine("Téléchargement terminé");
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
