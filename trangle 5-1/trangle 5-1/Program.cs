using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace trangle_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var math = Enumerable.Range(1, n).Select((x) => x);

            foreach (var x in math)
            {
                var result = Enumerable.Repeat((n + 1)- x, x);
                foreach (var y in result)
                {
                    Console.Write(y);
                }
                Console.WriteLine();

            }
            

            //var list = new List<int>() {1, 2, 3, 4, 5 };
            //var result = from a in list
            //            join b in list.OrderByDescending(x => x).ToList()
            //            on a equals 6 - b
            //            select new { number = b, time = a };
            //foreach (var item in result)
            //{
            //    for (int i = 0; i < item.time; i++)
            //    {
            //        Console.Write(item.number);
            //    }
            //    Console.WriteLine();
            //}

            
            Console.ReadLine();

        }

 

    }

    
}
