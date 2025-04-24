using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3
{
    public partial class Customer
    {
        public string Email { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Id}- {Name} [{Email}] ({Address})";
        }

    }
}
