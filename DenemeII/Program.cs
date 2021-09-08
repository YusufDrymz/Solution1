using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DenemeII
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            string str = String.Format("{0:C}", a);
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
