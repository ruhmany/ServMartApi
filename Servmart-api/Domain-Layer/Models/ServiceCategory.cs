namespace Domain_Layer.Models
{
    public class ServiceCategory
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
               
        public virtual ICollection<Service> Services { get; set; }
    }

}
