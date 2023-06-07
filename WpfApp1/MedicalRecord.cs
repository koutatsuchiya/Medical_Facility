using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MedicalRecord
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string DateChecked { get; set; }
        public string Diagnose { get; set; }
        public int DoctorId { get; set; }

        public int SpecialistId { get; set; }
        public int CSYTId { get; set; }
        public string Conclusion { get; set; }
    }
}
