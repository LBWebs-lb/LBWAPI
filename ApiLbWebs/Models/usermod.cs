using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class usermod
    {
        [Key]
        public int imod { get; set; }
        public string dnommod { get; set; }
    }
}
