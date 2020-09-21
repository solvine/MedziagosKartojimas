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

            var b = new BKlase("namas");
            Console.WriteLine($"NAME KODAS: {b.NameKodas(2)}");
            Console.WriteLine($"ZODIS BE BALSIU: {b.ZodisBeBalsiu()}");
            Console.WriteLine($"ZODIS BE PRIEBALSIU: {b.ZodisBePriebalsiu()}");
            Console.WriteLine($"ZODIS SU PAKEISTOMIS BALSEMIS: {b.ZodisSuPakeistomisBalsemis('o')}");
            Console.WriteLine($"ZODIS SU PAKEISTOMIS PRIEBALSEMIS: {b.ZodisSuPakeistomisPriebalsemis(2)}");
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
