using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    /// <summary>
    /// hi test hfhfgh
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public delegate double Delegate_Prod(int a, int b);

    //public delegate TResult Func<in T, out TResult>(
    //    T arg
    //    );

    class Program
    {
        static double fn_Prodvalues(int val1, int val2)
        {
            return val1 * val2;
        }
        static void Main(string[] args)
        {
            //Creating the Delegate Instance
            Delegate_Prod delObj = new Delegate_Prod(fn_Prodvalues);
            Console.Write("Please Enter Values");
            int v1 = Int32.Parse(Console.ReadLine());
            int v2 = Int32.Parse(Console.ReadLine());
            //use a delegate for processing
            double res = delObj(v1, v2);
            Console.WriteLine("Result :" + res);
            Console.ReadLine();
        }


    }


//    delegate void Delegate_Multicast(int x, int y);
//class Class2
//{
//    static void Method1(int x, int y)
//    {
//        Console.WriteLine("You r in Method 1");
//    }

//    static void Method2(int x, int y)
//    {
//        Console.WriteLine("You r in Method 2");
//    }

//    public static void Main()
//    {
//        Delegate_Multicast func = new Delegate_Multicast(Method1);
//        func += new Delegate_Multicast(Method2);
//        func(1,2);             // Method1 and Method2 are called
//        func -= new Delegate_Multicast(Method1);
//        func(2,3);             // Only Method2 is called
//    }
//}

}
