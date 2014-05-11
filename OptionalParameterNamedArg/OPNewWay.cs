using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterNamedArg
{
    public class NewWay
    {
        public void DoSomething(
                    string formatString,
                    int param1 = 0,
                    bool param2 = true)
        {
            Console.WriteLine(
            String.Format(formatString, param1, param2));
        }
    }
}
