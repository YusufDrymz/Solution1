using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            // Console.WriteLine("Hello World!");
            int number1 = 10;
            long number2 = 1231212125441274644;
            short number3 = -4646;
            byte number4 = 255;
           // bool c = true;
            char a = 'A';
            double number5 = 10.4;
            decimal number6 = 10.36453354m;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number is {0}\n" +
                              "Number sc {1}\n" +
                              "Number 3: {2}\n" +
                              "Number 4: {3}\n" +
                              "Character is :{4}\n" +
                              "Number 5: {5}\n" +
                              "Number 6: {6}\n" +
                              "{7}\n" +
                              "Number 7: {8}", number1, number2, number3, number4,(int)a, number5, number6,(int)Days.Friday , number7);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
