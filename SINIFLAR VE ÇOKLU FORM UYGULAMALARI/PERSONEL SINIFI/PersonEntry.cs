using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONEL_SINIFI
{
    public class PersonEntry
    {
        public PersonEntry(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}\nEmail: {1}\nPhone: {2}",
                                 Name, Email, Phone);
        }
    }
}
