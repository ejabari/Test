using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // Declare the generic class. 
    public class GenericList<T>
    {
        void Add(T input) { }
    }
    class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {
            // Declare a list of type int.
            var list1 = new GenericList<int>();

            // Declare a list of type string.
            var list2 = new GenericList<string>();

            // Declare a list of type ExampleClass.
            var list3 = new GenericList<ExampleClass>();
        }
    }
}
