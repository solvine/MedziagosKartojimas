
namespace MedziagosKartojimas
{
    public abstract class BaseClass
    {
        public string Name { get; }

        public BaseClass(string name)
        {
            Name = name;
        }

        public abstract string NameMetodas();

        public abstract int NameKodas(int a);

    }
}
