using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "İsmet",
                    LastName = "Sayın"
                    
                },

                new Student
                {
                    FirstName = "Ali",
                    LastName = "Korkal"
                },

                new Person
                {
                    FirstName = "Salih",
                    LastName = "Köse"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.LastName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
