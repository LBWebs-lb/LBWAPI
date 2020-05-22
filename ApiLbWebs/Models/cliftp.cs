using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class cliftp
    {
        [Key]
        public int iftp { get; set; }
        public string userftp { get; set; }
        public string passftp { get; set; }
        public string ipserver { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }
}
