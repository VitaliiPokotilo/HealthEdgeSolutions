namespace HealthEdge_Solutions.Entities
{
    public class TreatmentPlan
    {
        public int TreatmentPlanId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Description { get; set; }
        public List<string> MedicationsNeeded { get; set; }
    }
}
