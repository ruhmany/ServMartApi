
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Message
    {
        public Guid ID { get; set; }
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual Chat Chat { get; set; }
        public virtual ICollection<MessageMedia> MessageMedias { get; set; }

    }
}
