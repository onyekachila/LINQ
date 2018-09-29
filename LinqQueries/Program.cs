using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Stanley"}
            };

            // To loop over this so that we can get the count

            //Console.WriteLine(developers.Count());

            // to get the name

            //foreach (var item in developers)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // to get a method where name starts with S

            foreach (var employee in developers.Where(NameStartsWithS))
            {
                Console.WriteLine(employee.Name);
            }





            // because the type List implement an interface called IEnumerable<T> 
            // we have the chance to iterate over this collection.

            // Extension method allows us to define a static method that appears to be a member of another type.
            // classes, interfaces, structs even sealed types that we can not extend through inheritance

            // Lambda expression

            // Delegate helps us to write inline methord or anonymous mehtiod


            Console.ReadKey(); 
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S"); 
        }
    }
}
