using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodClass
{
    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }

        public static string Pluralize(this string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return s + "s";
        }
        public static string Capitalize(this string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return s.ToUpper();
        }
    }

    static class ObjectHelper
    {
        public static bool IsCapitalized(this object s)
        {
            var s1 = s as string;
            if (string.IsNullOrEmpty(s1)) return false;
            return char.IsUpper(s1[0]);
           
        }
    }

}
