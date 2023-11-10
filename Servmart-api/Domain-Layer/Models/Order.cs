using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreateAt { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }
    }
}
