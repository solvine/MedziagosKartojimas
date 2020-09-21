
namespace MedziagosKartojimas
{
    class CKlase : BKlase
    {
        public int Skaicius { get; set; }
        public string Zodis { get; set; }
        public double DoubleSkaicius { get; set; }
        public AKlase AObjektas { get; set; }

        public CKlase(string name) : base(name)
        {

        }

        public CKlase(string name, int skaicius) : base(name)
        {
            Skaicius = skaicius;
        }

        public CKlase(string name, int skaicius, string zodis) : base(name)
        {
            Skaicius = skaicius;
            Zodis = zodis;
        }

        public CKlase(string name, int skaicius, string zodis, double doubleSkaicius, AKlase aObjektas) : base(name)
        {
            Skaicius = skaicius;
            Zodis = zodis;
            DoubleSkaicius = doubleSkaicius;
            AObjektas = aObjektas;
        }

    }
}
