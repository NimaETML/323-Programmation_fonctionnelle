using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_mylib_nima_zarrabi
{
    public static class Program
    {
        public static void Main()
        {
            //Entrées
            int year = "Année de naissance: ".ReadInt();
            $"Vous avez {DateTime.Now.Year - year} ans".Write(ConsoleColor.Green);

            // Conversions
            string input = "1237445275648";
            int number = input.ToIntSafe();
            Console.WriteLine($"Nombre converti : {number}");
            Console.WriteLine($"Pas un nombre, valeur par défaut : {"notANumber".ToIntSafe()}");
            Console.WriteLine($"Pas un nombre, valeur par défaut spécifique : {"notANumber".ToIntSafe(-1)}");

            //Random
            var random = new Random();
            string randomStr = random.RandomString(8);
            Console.WriteLine($"Chaîne aléatoire : {randomStr}");
            bool randomBool = random.RandomBool();
            Console.WriteLine($"Booléen aléatoire: {randomBool}");
        }
    }
}