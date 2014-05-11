using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usageOfNameArgument
{
    public class Contact
    {
        // constructor defined with optional parameters
        public Contact(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string email = "unknown", // optional
            string phone = "", // optional
            string state = "Other"
            ) // optional
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
            State = state;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }
        public static List<Contact> SampleData()
        {
            var n = new List<Contact>
                {
                    new Contact("ali", "ahmadi", new DateTime(), state:"CA"),
                    new Contact("reza", "abbasi", new DateTime())
                };
            return n;
        }
    }
}
