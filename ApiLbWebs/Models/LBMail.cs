using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class LBMail
    {
        [Key]
        public int idlbmail { get; set; }
        public string dnommail { get; set; }
        public string mailuser { get; set; }
        public string passmail { get; set; }
        public string lnkmail { get; set; }
    }
}
