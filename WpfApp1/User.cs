using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class User
    {
        //ACCOUNT_STATUS, CREATED, EXPIRY_DATE, LAST_LOGIN
        public int Id { get; set; }
        public string Username { get; set; }
        public string AccountStatus { get; set; }
        public string Created { get; set; }
        public string ExpiryDate { get; set; }

        public string LastLogin { get; set; }
    }
}
