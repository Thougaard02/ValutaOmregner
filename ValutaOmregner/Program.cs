using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValutaOmregner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indsæt DKK som du vil omregne");

            double dkk = double.Parse(Console.ReadLine());

            string usd = $"USD = {dkk * 0.16}";

            string pund = $"pund = {dkk * 0.12}";

            string euro = $"Euro = {dkk * 0.13}";

            string sek = $"SEK = {dkk * 1.36}";

            Console.WriteLine(usd);
            Console.WriteLine(pund);
            Console.WriteLine(euro);
            Console.WriteLine(sek);

            Console.ReadKey();
        }
    }
}
