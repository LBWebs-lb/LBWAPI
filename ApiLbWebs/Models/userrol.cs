using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class userrol
    {
        [Key]
        public int irol { get; set; }
        public string dnomrol { get; set; }
    }
}
