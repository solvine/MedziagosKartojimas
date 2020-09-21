using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new AKlase("mama");

            Console.WriteLine($"NEW NAME: {a.NameMetodas()}");
            Console.WriteLine($"NAME KODAS: {a.NameKodas(2)}");

            ExitApp();
        }

        static void ExitApp()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
