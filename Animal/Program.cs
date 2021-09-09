using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Memeli
    {
        public double Boy;
        public double Agirlik;
        public Memeli(double boy, double agirlik)
        {
            this.Boy = boy;
            this.Agirlik = agirlik;
        }
        virtual public void Konus()
        {
            Console.WriteLine("Ben Konusamam..");
        }
    }

    class Kedi : Memeli
    {
        public string Turu;
        public Kedi(string turu, int boy, int agirlik) : base(boy, agirlik)
        {
            this.Turu = turu;
        }

        public override void Konus()
        {
            Console.WriteLine("Ben Bir Kediyim");
        }
    }

    class Koyun : Memeli
    {
        public string Turu;
        public Koyun(string turu, int boy, int agirlik):base(boy, agirlik)
        {
            this.Turu = turu;
        }

        public override void Konus()
        {
            Console.WriteLine("Ben Bir Koyunum");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Memeli memeli1 = new Memeli(10, 35);
            Kedi kedi1 = new Kedi("Van", 5, 10);
            Koyun koyun1 = new Koyun("Ankara", 50, 65);

            memeli1 = kedi1;
            memeli1.Konus();

            memeli1 = koyun1;
            memeli1.Konus();

            Console.ReadLine();
        }
    }
}
