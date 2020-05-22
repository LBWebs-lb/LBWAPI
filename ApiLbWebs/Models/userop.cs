using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class userop
    {
        [Key]
        public int iuserop { get; set; }
        public string dnommod { get; set; }
        public int iMod { get; set; }
        [ForeignKey("iMod")]
        public virtual usermod Modul { get; set; }
    }
}
