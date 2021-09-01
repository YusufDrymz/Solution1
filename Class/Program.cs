using Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustumerManager custumerManager = new CustumerManager();
            custumerManager.Add();
            custumerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Yusuf";
            customer.LastName = "Darıyemez";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Erkam", LastName = "Darıyemez"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
    
    
}
