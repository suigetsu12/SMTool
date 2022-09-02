using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Extensions
{
    public static class CheckNullExtensions
    {
        public static bool NotNullOrEmpty<T>(this IEnumerable<T> target)
            => target != null && target.Any();

        public static bool NotNullOrEmpty(this string target) 
            => !string.IsNullOrEmpty(target);
    }
}
