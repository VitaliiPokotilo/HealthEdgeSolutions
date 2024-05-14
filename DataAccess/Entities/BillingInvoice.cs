namespace HealthEdge_Solutions.Entities
{
    public class BillingInvoice
    {
        public int InvoiceId { get; set; }
        public int PatientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
