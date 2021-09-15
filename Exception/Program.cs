using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptioIntro();

            //TryCatch();

            //ActionDeo();

            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber2());

            Thread.Sleep(1000);

            Console.WriteLine(getRandomNumber());

            //Console.WriteLine(Topla(2, 3));

            Console.ReadLine();
        }

        static int Topla(int x,int y)
        {
            return x + y;
        }

        private static void ActionDeo()
        {
            HandledException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

            }
        }

        private static void HandledException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Demir", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!!!");
            }
            else
            {
                Console.WriteLine("Record found!!");
            }
        }

        private static void ExceptioIntro()
        {
            try
            {
                string[] students = new string[3] { "Yusuf", "Erkan", "Darıyemez" };

                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
