using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample002
{
    //public delegate bool MyPredicate(string vaule);

    public class Myclass
    {
        //public List<string> DoWhere(List<string> source, MyPredicate predicate)
        public List<string> DoWhere(List<string> source, Func<string, bool> predicate) 
        {
            List<string> result = new List<string>();
            foreach (string item in source) 
            { 
                if (predicate.Invoke (item))
                {
                    result.Add (item);
                }
            }
            return result;
        }
    }
}
