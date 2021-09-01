using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Intro();
            string sentence = "My Name is Yusuf Darıyemez";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My Name is Erkam Darıyemez";

            bool result3 = sentence.EndsWith("z");
            bool result4 = sentence.StartsWith("My Name");
            var result5 = sentence.IndexOf("Name ");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2);

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            // Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }

    }
}
