using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSample001.Helpers
{
    public static class MyClass
    {
        public static IEnumerable<T> DoWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    yield return item;
                }
                
            }
            
        }
    }
}
