using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class userslb
    {
        [Key]
        public int iduser { get; set; }
        public string user { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime cyuscusualt { get; set; }
        [ForeignKey("irol")]
        public int? irol { get; set; }
        public virtual userrol Rol { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }
}
