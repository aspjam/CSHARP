using System;
using System.Collections.Generic;
using System.IO;

namespace programme_fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path = "out";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //  c:\User\...
            //  /User/
            string filename = "monFichier.txt";
            string filename2 = "monFichier2.txt";

            string pathAndFile = Path.Combine(path, filename);
            string pathAndFile2 = Path.Combine(path, filename2);

            if (File.Exists(pathAndFile))
            {
                Console.WriteLine("Le fichier existe déjà, on va écraser son contenu");
            }
            else
            {
                Console.WriteLine("Le fichier n'existe pas, on va le créer");
            }


            Console.WriteLine("FICHIER : " + pathAndFile);

            var noms = new List<string>()
            {
                "Jean",
                "Paul",
                "Martin"
            };

            //File.WriteAllText("monFichier.txt", "Voici le contenu que j'écris dans le fichier texte");
            //File.AppendAllText(filename, "je rajoute ce texte.");
            File.WriteAllLines(pathAndFile, noms);

            try
            {
                ///string resultat = File.ReadAllText(filename);
                var lignes = File.ReadAllLines(pathAndFile);

                foreach(var ligne in lignes)
                {
                    Console.WriteLine(ligne);
                }
                
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("ERREUR : Ce fichier n'existe pas (" + ex.Message + ")");
            }
            catch
            {
                Console.WriteLine("Une erreur inconnue est arrivée");
            }

            //File.Copy(pathAndFile, pathAndFile2);
            //File.Delete(pathAndFile2);
            File.Move(pathAndFile, pathAndFile2);
        }
    }
}
