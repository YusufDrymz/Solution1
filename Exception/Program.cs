using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptioIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandledException(() => 
            {
                Find();
            });
       
            Console.ReadLine();
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
