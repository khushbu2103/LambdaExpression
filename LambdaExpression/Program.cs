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
                new Person(){SSN=1, Name="Harish", Address="Delhi", Age=16},
                new Person(){SSN=1, Name="Thia", Address="Mumbai", Age=14},
                new Person(){SSN=1, Name="Ramesh", Address="Pune", Age=62},

            };

            Console.WriteLine("please choose any program");
            Console.WriteLine("1.Display person data\n" +
                "2.Top 2 records age less than 60\n" +
                "3.Records of age between 13 to 18\n" +
                "4.Records of average age in list");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    DisplayPersonDeta(list);
                    break;
                case 2:
                    PersonDetaManagement.RetreiveTop2RecordsBasedOnLessAge(list);
                    break;
                case 3:
                    PersonDetaManagement.RetreiveTeenageRecords(list);
                    break;
                case 4:
                    PersonDetaManagement.RetreiveAvaregeAgeRecords(list);
                    break;
                default:
                    break;
            }
            
           
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
