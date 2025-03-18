using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vid1_2
{
    internal static class Int32Extension
    {
        //Extension Method
        public static int Mirror(this int value)
        {
            char[] str = value.ToString().ToCharArray();

            Array.Reverse(str);

            return (int.Parse(str));
        }
    }
}
