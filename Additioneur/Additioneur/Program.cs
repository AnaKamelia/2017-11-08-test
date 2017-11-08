using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additioneur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Additioneur");
            Console.WriteLine("===========");

            Console.Write("Saisir une valeur réelle: ");
            double dblValeur = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valeur saisie: " + dblValeur.ToString());

            Console.Read();
        }
    }
}
