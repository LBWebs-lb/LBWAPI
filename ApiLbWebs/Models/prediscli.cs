using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class prediscli
    {
        [Key]
        public int ipredis { get; set; }
        public string ptheme { get; set; }
        public bool envcli { get; set; }
        public bool themebuy { get; set; }
        public int pctheme { get; set; }
        public string bouby { get; set; }
        public bool paid { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }

    }
}
