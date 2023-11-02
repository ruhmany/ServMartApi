using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.UserDTOs
{
    public class ChangeEmailDTO
    {
        public string OldEmail { get; set; }
        public string NewEmail { get; set; }
    }
}
