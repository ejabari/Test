using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usageOfNameArgument
{
    class Program
    {
        public static List<Contact> Usage()
        {
            var q = (from c in Contact.SampleData()
                    where c.State == "CA"
                    select new Contact(
                        c.FirstName, c.LastName,
                        state: c.State,
                        dateOfBirth: c.DateOfBirth
                    )).ToList();
            return q;
            
        }
        static void Main(string[] args)
        {
            var q = Usage();
            foreach (var c in q)
                Console.WriteLine("{0}, {1} ({2}) - {3}",
                c.LastName, c.FirstName,
                c.DateOfBirth.ToShortDateString(), c.State);
        }
    }
}
