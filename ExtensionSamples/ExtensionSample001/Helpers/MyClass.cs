using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector.Invoke(item);
            }
        }

        public static int MySum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            int result = 0;
            foreach (var item in source)
            {
                result += selector.Invoke(item);
            }
            return result;
        }

        public static int MyMin<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            int result = int.MaxValue;
            foreach(var item in source)
            {
                var temp = selector.Invoke(item);
                if (temp < result)
                {
                    result = temp;
                }
            }
            return result;
        }

    }
}
