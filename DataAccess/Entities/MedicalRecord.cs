namespace HealthEdge_Solutions.Entities
{
    public class MedicalRecord
    {
        public int MedicalRecordId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public List<string> Medications { get; set; }
    }
}
