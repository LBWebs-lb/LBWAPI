using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class clilb
    {
        [Key]
        public int icli { get; set; }
        [ForeignKey("ihos")]
        public int? ihos { get; set; }
        [ForeignKey("ihos")]
        public virtual clihos Host { get; set; }
        public int? iftp { get; set; }
        [ForeignKey("iftp")]
        public virtual cliftp Ftp { get; set; }
        public int? ipredis { get; set; }
        [ForeignKey("ipredis")]
        public virtual prediscli PreDis { get; set; }
        public string dnom { get; set; }
        public string dnommail { get; set; }
        public Estat est { get; set; }
        public string dobs { get; set; }
        public string tcli { get; set; }
    }
    
    public enum Estat
    {
        Pressupostat,
        Predisseny,
        Desenvolupament,
        Mostrada,
        Entregada,
        RespostaClient
    }
}
