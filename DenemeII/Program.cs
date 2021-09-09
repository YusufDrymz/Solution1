using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AddveRemoveErisim
{
    delegate void OlayYoneticisi();
    class Buton
    {
        OlayYoneticisi[] olay = new OlayYoneticisi[2];
        public event OlayYoneticisi ButonKlik
        {
            add
                
            {
                int i;
                for (i = 0; i < 2; ++i)
                    if (olay[i] == null)
                    {
                        olay[i] = value;
                        break;
                    }
                if (i== 2)
                        Console.WriteLine("Olay Yoneticisine En Fazla 2 Metot Eklenebilr.");
            }
            remove
            {
                int i;
                for (i = 0; i < 2; ++i)
                    if (olay[i] == null)
                    {
                        olay[i] = value;
                        break;
                    }
                if (i== 2)
                        Console.WriteLine("Metot Bulunumadı");
            }
        }
        public void Kliklendi()
        {
            for (int i = 0; i < 2; ++i)
                if (olay[i] != null)
                    olay[i]();           
        }
    }
    class Pencere
    {
        int PencereNo;
        public Pencere(int no)
        {
            PencereNo = no;
        }
        public void ButonKlik()
        {
            Console.WriteLine("{0} nolu pencere olayı algıladı.", PencereNo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buton buton = new Buton();
            Pencere p1 = new Pencere(1);
            Pencere p2 = new Pencere(2);

            //Geçerli Ekleme
            buton.ButonKlik += new OlayYoneticisi(ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();

            //Geçerli Ekleme
            buton.ButonKlik += new OlayYoneticisi(p1.ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();

            //Geçerli Ekleme
            buton.ButonKlik += new OlayYoneticisi(p2.ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();

            buton.ButonKlik -= new OlayYoneticisi(p1.ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();

            buton.ButonKlik -= new OlayYoneticisi(ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();

            buton.ButonKlik -= new OlayYoneticisi(ButonKlik);
            buton.Kliklendi();
            Console.WriteLine();

            Console.ReadLine();
        }
        public static void ButonKlik()
        {
            Console.WriteLine("Statik Metot Olayı Algılandı..");
        }
    }
}
