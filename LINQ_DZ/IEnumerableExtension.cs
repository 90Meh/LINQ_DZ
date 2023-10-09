using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DZ
{
    internal static class IEnumerableExtension
    {

        public static IEnumerable<T> Top<T>(this IEnumerable<T> values, double percent)
        {

            if (percent < 1 || percent <= 100)
            {
                return values.OrderByDescending(x => x).Take((int)Math.Ceiling(values.Count() * percent / 100));
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> values, double percent, Func<T, int> func)
        {
            if (percent < 1 || percent <= 100)
            {             
                return values.OrderByDescending(func).Take((int)Math.Ceiling(values.Count() * percent / 100));
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
