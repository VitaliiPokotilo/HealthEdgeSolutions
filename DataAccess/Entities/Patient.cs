using HealthEdge_Solutions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HealthEdge_Solutions.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public MedicalInsurance InsurancePolicyNumber { get; set; }
        public List<MedicalRecord> MedicalRecords { get; set; }
    }
}
