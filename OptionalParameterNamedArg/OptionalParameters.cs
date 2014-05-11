using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterNamedArg
{
    public class OptionalParameters
    {
        //Required parameters cannot appear after any optional parameter.
        public void M1(string s, int i = 1) { }
        //this is incorrect:
        //public void M11(int i = 1, string s) { }

        public void M2(Point p = new Point()) { }
        //this is incorrect:
        //public void M22(Point p = new Point(0,0)) { }

        //The default specified must be a constant expression available at
        //compile time or a value type constructor without parameters
        public void M3(Point p = default(Point)) { }

        //Parameter arrays (params) can occur after optional parameters,
        //but these cannot have a default value assigned
        public void M4(int i = 1, params string[] values) { }


        //this is incorect
        //Default parameter value for ‘p’ must be a compile-time constant
        //(Must be a value type (struct or built-in value types only))
        // void M5(StringBuilder p = new StringBuilder()) { }

        //A ref or out parameter cannot have a default value
        //public void M6(int i = 1, out string s = "") {}

        //Cannot specify a default value for a parameter array
        //public void M7(int i = 1, params string[] values = "test") {}
    }
}
