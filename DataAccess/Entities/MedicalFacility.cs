namespace HealthEdge_Solutions.Entities
{
    public class MedicalFacility
    {
        public int MedicalFacilityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
