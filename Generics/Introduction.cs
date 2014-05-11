using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Introduction
    {
        public void oldWay()
        {
            // The .NET Framework 1.1 way to create a list:
            var list1 = new System.Collections.ArrayList();
            list1.Add(3);
            list1.Add(105);

            var list2 = new System.Collections.ArrayList();
            list2.Add("It is raining in Redmond.");
            list2.Add("It is snowing in the mountains.");


            //**** there is no way at compile-time to prevent client code from doing something
            //such as this

            System.Collections.ArrayList list = new System.Collections.ArrayList();
            // Add an integer to the list.
            list.Add(3);
            // Add a string to the list. This will compile, but may cause an error later.
            list.Add("It is raining in Redmond.");

            int t = 0;
            // This causes an InvalidCastException to be returned. 
            foreach (int x in list)
            {
                t += x;
            }

            //but with generics it is possible
            // The .NET Framework 2.0 way to create a list
            List<int> list11 = new List<int>();

            // No boxing, no casting:
            list11.Add(3);

            // Compile-time error: 
            // list1.Add("It is raining in Redmond.");

        }
    }
}
