using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterNamedArg
{
    public class NamedArgument
    {
        // reversing the order of arguments.
        Point p1 = new Point(y: 100, x: 10);
        
        //”Named argument ‘x’ specifies a parameter for which a
        // positional argument has already been given”
        //Point p3 = new Point(10, x: 10);

        // “Named argument specifications must appear after all
        // fixed arguments have been specified”
        //Point p4 = new Point(y: 100, 10);

        // “The best overload for ‘.ctor’ does not have a
        // parameter named ‘x’”
        //Point p5 = new Point(x: 10);

        public void NamedArg()
        {
            NewWay newWay = new NewWay();
            // skipping an optional parameter
            newWay.DoSomething(
                    "({0},{1}) New way - param1 skipped.",
                    param2: false);   
  
            // any order, but if it doesn’t have a default
            // it must be specified by name somewhere!
            newWay.DoSomething(
                    param2: false,
                    formatString: "({0},{1}) New way - params specified" +
                    " by name, in any order.",
                    param1: 5);
        }
     
    }
}
