using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> source
                = new List<string> { "Bill", "John", "Daid", "Tom", "David" };

            Myclass obj = new Myclass();

            var result = obj.DoWhere(source, (x) => { return x == "David"; });
            // (x) => x == "David" or (x) => { return x == "David"; }

            //var result = obj.DoWhere(source, delegate (string x) { return x == "David"; });
            
            //MyPredicate predicate = SearchDavid;
            //var result = obj.DoWhere(source, predicate);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static bool SearchDavid(string vaule)
        {
            return (vaule == "David");
        }
    }
}
