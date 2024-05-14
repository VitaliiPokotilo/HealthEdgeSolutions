namespace HealthEdge_Solutions.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int MedicalFacilityId { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
