using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Shop
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public string UserID { get; set; }
               
        public virtual User Owner { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
