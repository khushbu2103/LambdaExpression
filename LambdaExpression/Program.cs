using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            List<Person> list = new List<Person>()
            {
                new Person(){SSN=1, Name="Khushi", Address="Rajasthan", Age=26},
                new Person(){SSN=1, Name="Raj", Address="gujrat", Age=28},
                new Person(){SSN=1, Name="Harish", Address="Delhi", Age=20},
                new Person(){SSN=1, Name="Thia", Address="Mumbai", Age=21},
                new Person(){SSN=1, Name="Ramesh", Address="Pune", Age=62},

            };
            DisplayPersonDeta(list);
            PersonDetaManagement.RetreiveTop2RecordsBasedOnLessAge(list);
            Console.ReadLine();
        }

        public static void DisplayPersonDeta(List<Person> list)
        {
            foreach(Person p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
