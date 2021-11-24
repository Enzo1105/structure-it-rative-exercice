using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            string separateur = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            while(true) // while = boucle 
            {
                Console.Write("Note : ");
                string valeurSaisie = Console.ReadLine();
                if (valeurSaisie.ToLower() == "ab") break;
                // contrôle du séparateur
                if (separateur == ",")
                {
                    valeurSaisie = valeurSaisie.Replace('.', '.');
                }
                else
                {
                    valeurSaisie = valeurSaisie.Replace('.', '.');
                }
                if (decimal.TryParse(valeurSaisie, out decimal note))
                {           
                    if ( note < 0 || note > 20 || note * 2 != Math.Truncate(note * 2)) // les ||veulent dire OU
                    {
                        Console.WriteLine("\t Note invalide");
                    }
                    else
                    {
                        break; // break = sortir de la boucle
                    }
                }
            }

            Console.WriteLine("Note correcte");
            Console.ReadKey();
        }
    }
}
