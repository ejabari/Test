using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodClass;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Leopard";
            
            //Extension method chaining 
            //using extensionMethod 
            var x = name.Pluralize().Capitalize();

            //using staticMethods
            string y = StringHelper.Capitalize(StringHelper.Pluralize("Leopard"));

            var test1 = "test1".IsCapitalized();
            //explicitly
            var test2 = (ObjectHelper.IsCapitalized("Test2"));

            
            Console.WriteLine("Kasra".IsCapitalized());
            Console.WriteLine(x);
            Console.WriteLine("test1 is capitalazed: "+test1);
            Console.WriteLine("test2 is capitalazed: " + test2);
        }
    }
}
