using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var order1 = 
                from o in list
                orderby o.Name, o.Age
                select o;
            Diseplay(order1);
            var order2 =
                from o in list
                orderby o.Name descending, o.Age descending
                select o;
            Diseplay(order2);
 
            //var order1 = list.OrderBy((x) => x.Age);
            //Diseplay(order1);
            //var order2 = list.OrderByDescending((x) => x.Age);
            //Diseplay(order2);
            //var order3 = list.OrderBy((x) => x.Name).ThenBy((x) => x.Age);
            //Diseplay(order3);
            //var order4 = list.OrderBy((x) => x.Name).ThenByDescending((x) => x.Age);
            //Diseplay(order4);

            Console.ReadLine();
 
        }

        static void Diseplay(IOrderedEnumerable<MyData> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine($"{item.Name} : {item.Age}");
            }
            Console.WriteLine("---------------");
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData { Name = "Bill", Age = "47" },
                new MyData { Name = "John", Age = "37" },
                new MyData { Name = "Tom", Age = "48" },
                new MyData { Name = "David", Age = "26" },
                new MyData { Name = "Bill", Age = "35" },

            };
        }
    }
}
