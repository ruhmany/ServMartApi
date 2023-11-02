namespace Domain_Layer.Models
{
    public class RequestOffer
    {
        public Guid ID { get; set; }
        public string ProviderID { get; set; }
        public int State { get; set; }
        public Guid RequestID { get; set; }
        public string Details { get; set; }
        public decimal ExpectSalary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Request Request { get; set; }
        public virtual User User { get; set; }
    }
}
