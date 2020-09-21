using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    public abstract class BaseClass
    {
        public string Name { get; }

        public BaseClass(string name)
        {
            Name = name;
        }
    }
}
