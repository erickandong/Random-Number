using System.Linq.Expressions;

namespace Nombre_Aléatoire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int nombre = rand.Next(1, 101);
            int nbcoup = 0;
            int monNombre = 0;

            Console.Title = "Trouve le nombre";
          
            while (monNombre != nombre)
            {
                Console.WriteLine("Entrez un nombre entre 1 et 100");
                try
                {
                    monNombre = int.Parse(Console.ReadLine());

                    if (monNombre > nombre)
                    {
                        Console.WriteLine($"{monNombre} est trop grand");
                        nbcoup++;
                    }
                    if (monNombre < nombre)
                    {
                        Console.WriteLine($"{monNombre} est trop petit");
                        nbcoup++;
                    }
                }
                catch
                {
                    Console.WriteLine("Une erreur est survenu,Veuillez recommencer svp...");
                }
            }
            nbcoup++;
            Console.WriteLine($"Bravo, vous avez gagné en {nbcoup} coups");

            Console.ReadKey();

        }
    }
}
