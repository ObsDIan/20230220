using ExtensionSample001.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> source = new List<string> { "Bill", "John", "David", "Tom", "David" };
            int[] arr = {1, 2, 3, 1};
            var result = source.DoWhere((x) => x == "David");
            var result2 = arr.DoWhere((x) => x == 1);
            Func<string, char> f = PPP;
            var r = source.MySelect(f);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        static char PPP(string x)
        {
            return x.ToArray()[0];
        }
    }
}
