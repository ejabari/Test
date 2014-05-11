using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterNamedArg
{
    public class OldWay
    {
        // multiple overloads call the one master
        // implementation of a method that handles all inputs

        public void DoSomething(string formatString)
        {
            // passing 0 as param1 default,
            // and true as param2 default.
            DoSomething(formatString, 0, true);
        }
        public void DoSomething(string formatString, int param1)
        {
            DoSomething(formatString, param1, true);
        }
        public void DoSomething(string formatString, bool param2)
        {
            DoSomething(formatString, 0, param2);
        }
        // the actual implementation. All variations call this
        // method to implement the methods function.
        public void DoSomething(
        string formatString,
        int param1,
        bool param2)
        {
            Console.WriteLine(
            String.Format(formatString, param1, param2));
        }
    }
}
