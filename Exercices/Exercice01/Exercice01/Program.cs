using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, c;
            Console.Write("Valeur de a : ");
            int a = int.Parse(Console.ReadLine());



            while (true)
            {
                Console.Write("Valeur de b : ");
                b = int.Parse(Console.ReadLine());
                if (b > a) break;
                Console.WriteLine($"\t Vous devez saisir une valeur supérieur à {a}");
            }

            while (true)
            {
                Console.Write("Valeur de c : ");
                c = int.Parse(Console.ReadLine());
                if (c > b) break;
                Console.WriteLine($"\t Vous devez saisir une valeur supérieur à {b}");
            }
            Console.WriteLine("Saisie correcte");
            Console.ReadKey();
        }
    }
}