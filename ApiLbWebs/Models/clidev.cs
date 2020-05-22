using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class clidev
    {
        [Key]
        public int idev { get; set; }
        public int icli { get; set; }
        [ForeignKey("icli")]
        public virtual clilb Client { get; set; }
        public bool wdpins { get; set; }
        public string userwd { get; set; }
        public string passwd { get; set; }
        public string linkdev { get; set; }
        public string acc { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }
}
