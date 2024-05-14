namespace HealthEdge_Solutions.Entities
{
    public class MedicalInsurance
    {
        public string InsurancePolicyNumber { get; set; }
        public int PatientId { get; set; }
        public string Company { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
