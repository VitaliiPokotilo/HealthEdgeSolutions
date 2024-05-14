namespace HealthEdge_Solutions.Entities
{
    public class MedicalTest
    {
        public int MedicalTestId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Type { get; set; }
        public string Results { get; set; }
    }
}
