using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            //Dictionary();
            Console.ReadLine();

        }

        private static void Dictionary()
        {
            Dictionary<string, string> dicrinory = new Dictionary<string, string>();
            dicrinory.Add("book", "kitap");
            dicrinory.Add("table", "tablo");
            dicrinory.Add("computer", "bilgisayar");

            //Console.WriteLine(dicrinory["table"]);
            //Console.WriteLine(dicrinory["kitap"]);

            foreach (var item in dicrinory)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dicrinory.ContainsKey("glass"));
            Console.WriteLine(dicrinory.ContainsKey("book"));
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Yusuf" });
            //customers.Add(new Customer { Id = 2, FirstName = "Erkan" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Yusuf" },
                new Customer { Id = 2, FirstName = "Erkan" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer2);


            customers.AddRange(new Customer[2] {
                new Customer{Id=4,FirstName="Ali" },
                new Customer{Id=5,FirstName="Ayşe"}
            });

            Console.WriteLine(customers.Contains(customer2));
            //customers.Clear();

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer2);

            var lastindex = customers.LastIndexOf(customer2);
            Console.WriteLine("Last Index: {0}", lastindex);

            customers.Insert(0, customer2);

            //customers.Remove(customer2);
            //customers.Remove(customer2);
            //customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Salih");


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
