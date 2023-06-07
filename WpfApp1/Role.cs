using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string PasswordRequired { get; set; }
        public string AuthenticationType { get; set; }
        public string Common { get; set; }

        public string Inherited { get; set; }
        public string Implicit { get; set; }

    }
}
