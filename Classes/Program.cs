using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.ID = 1;
            customer.FirstName = "İsmet";
            customer.LastName = "Sayın";

            Customer customer2 = new Customer
            {
                ID = 2, City="İstanbul", FirstName="Ali", LastName="Korkal"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
