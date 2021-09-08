using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Kompleks
    {
        private double mGercek;
        private double mSanal;

        public double Gercek
        {
            get { return mGercek; }
            set { mGercek = value; }
        }

        public double Sanal
        {
            get { return mSanal; }
            set { mSanal = value; }
        }

        public Kompleks(double a, double b)
        {
            mGercek = a;
            mSanal = b;
        }

        public Kompleks()
        {
            mGercek = 0;
            mSanal = 0;
        }

        public Kompleks(Kompleks a)
        {
            mGercek = a.Gercek;
            mSanal = a.Sanal;
        }

        public void Yazdir()
        {
            if (mSanal > 0)
                Console.WriteLine("{0} + j{1}", mGercek, mSanal);
            else
                Console.WriteLine("{0} - j{1}", mGercek, -mSanal);
        }

        public static Kompleks operator +(Kompleks a, Kompleks b)
        {
            double GercekToplam = a.Gercek + b.Gercek;
            double SanalToplam = a.Sanal + b.Sanal;
            return new Kompleks(GercekToplam, SanalToplam);
        }
    }

    class Yazdirma
    {
        static void Main()
        {
            Kompleks a = new Kompleks(-5, 9);
            Kompleks b = new Kompleks(1, 2);
            Kompleks c = a + b;
            c.Yazdir();
            Console.ReadLine();
        
        }
    }
   

}
    

