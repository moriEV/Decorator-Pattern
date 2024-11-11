using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Admin
    {
        public string Email {  get; set; }
        public string PhoneNumber { get; set; } 
        public string FacebookID { get; set; }
        public Admin(string email, string phoneNumber, string facebookID)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            FacebookID = facebookID;
        }
    }
}
