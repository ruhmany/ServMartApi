namespace Domain_Layer.Models
{
    public class Request
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public Guid CleintID { get; set; }
        public string Details { get; set; }
        public decimal ExpectSalary { get; set; }
        public int State { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float RateValue { get; set; }
        public string RateMassage { get; set; }
        public bool IsDirect { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<RequestMedia> Media { get; set; }
        public virtual ICollection<RequestOffer> RequestOffer { get; set; }
    }
}
