using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Patient
    {
        public int Id { get; set; }
        public int CSYTId { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public string DOB { get; set; }

        public string HomeNumber { get; set; }
        public string StreetName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string History { get; set; }
        public string HistoryFamily { get; set; }
        public string Allergy { get; set; }
    }
}
