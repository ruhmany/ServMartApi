namespace Domain_Layer.Models
{
    public class RequestOffer
    {
        public Guid ID { get; set; }
        public string ProviderID { get; set; }
        public int State { get; set; }
        public bool IsDirect { get; set; }
        public Guid RequestID { get; set; }
               
        public virtual Request Request { get; set; }
        public virtual User User { get; set; }
    }
}
