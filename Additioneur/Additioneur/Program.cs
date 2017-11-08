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
            Console.WriteLine("Calculateur");
            Console.WriteLine("===========");

            Console.Write("Saisir une valeur numérique: ");
            double dblValeur = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valeur saisie: " + dblValeur.ToString());

            Console.Read();
        }
    }
}
