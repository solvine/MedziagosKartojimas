using System;
using System.Linq;

namespace MedziagosKartojimas
{
    class BKlase : BaseClass, IZodisKitaip
    {
        public char[] Balses { get; set; }
        public char[] Priebalses { get; set; }
        public BKlase(string name) : base(name)
        {
            Balses = new char[] { 'a', 'A', 'o', 'O', 'u', 'U', 'i', 'I', 'y', 'Y', 'e', 'E' };
            Priebalses = new char[] { 'b','B', 'c', 'C', 'd', 'D', 'f', 'F', 'g', 'G', 'h', 'H', 'j', 'J', 'k', 'K', 'l', 'L',
                'm', 'M', 'n', 'N', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'v', 'V', 'w', 'W', 'x', 'X', 'z', 'Z' };
        }
        public override int NameKodas(int a)
        {
            int suma = 0;

            foreach (var item in Name)
            {
                suma += item - a;
            }

            return suma;
        }

        public override string NameMetodas()
        {
            string name = String.Empty;
            

            for (int i = 0; i < Name.Count(); i++)
            {
                if (Balses.Contains(Name[i]))
                {
                    name += (int)Name[i];
                }
                else
                {
                    name += Name[i];
                }

            }
            return name;
        }

        public string ZodisBeBalsiu()
        {
            string zodis = "";

            foreach (var item in Name)
            {
                if (!Balses.Contains(item))
                {
                    zodis += item;
                }

            }
            return zodis;
        }

        public string ZodisBePriebalsiu()
        {
            string zodis = "";

            foreach (var item in Name)
            {
                if (!Priebalses.Contains(item))
                {
                    zodis += item;
                }

            }
            return zodis;
        }

        public string ZodisSuPakeistomisBalsemis(char a)
        {
            string zodis = "";

            foreach (var item in Name)
            {
                if (Balses.Contains(item))
                {
                    zodis += a;
                }
                else
                {
                    zodis += item;
                }

            }
            return zodis;
        }

        public string ZodisSuPakeistomisPriebalsemis(int a)
        {
            string zodis = "";

            foreach (var item in Name)
            {
                if (Priebalses.Contains(item))
                {
                    zodis += $"{a}";
                }
                else
                {
                    zodis += item;
                }

            }
            return zodis;
        }
    }
}
