using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class PersonDetaManagement
    {
       public static void RetreiveTop2RecordsBasedOnLessAge(List<Person> list)
        {
           // list.Where(person => person.Age < 60).OrderByDescending(P => P.Age).Take(2);
           //List<Person> lessThan60=list.Where(person=>person.Age<60).ToList();
           // Console.WriteLine("\nRecords age less than 60");
           // Program.DisplayPersonDeta(lessThan60);
           // List<Person>SortedData=lessThan60.OrderByDescending(p=>p.Age).ToList();
           // Console.WriteLine("\nSorted data in descending order");
           // Program.DisplayPersonDeta(SortedData);
           // List<Person>Top2Data=SortedData.Take(2).ToList();
           // Console.WriteLine("\nTop two records which has age less than 60");
           // Program.DisplayPersonDeta(Top2Data);


            List<Person>Top2Records= list.Where(Person=>Person.Age<60).OrderByDescending(P=>P.Age).Take(2).ToList();
            Console.WriteLine("\nTop two records which has age less than 60");
            Program.DisplayPersonDeta(Top2Records);
        }

        public static void RetreiveTeenageRecords(List<Person> list)
        {
            List<Person>TeenageRecords=list.Where(Person=>Person.Age>13 && Person.Age<18).ToList();
            Console.WriteLine("\nrecords which has age in between 13 to 18");
            Program.DisplayPersonDeta(TeenageRecords);

        }
    }
    
}
