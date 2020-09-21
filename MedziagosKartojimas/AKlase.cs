using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
     class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {

        }
        public override int NameKodas(int a)
        {
            int suma = 0;

            foreach (var item in Name)
            {
                suma += (int)item * a;
            }
            return suma;
        }

        public override string NameMetodas()
        {
            string name = String.Empty;
            char[] balses = new char[] { 'a', 'A', 'o', 'O', 'u', 'U', 'i', 'I', 'y', 'Y', 'e', 'E' };

            for (int i = 0; i < Name.Count(); i++)
            {
                if (balses.Contains(Name[i]))
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
    }
}
