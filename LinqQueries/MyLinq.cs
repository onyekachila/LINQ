using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public static class MyLinq
    {
        // To invoke this method I need to call it from the class level
        // like this MyLinq.Count
        // To avoid that I need to make it an extension method by adding the this keyword.


        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count += 1;
            }

            return count; 
        }
    }
}
