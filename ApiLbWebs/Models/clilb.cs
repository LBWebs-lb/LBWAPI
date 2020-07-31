using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
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
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Estat est { get; set; }
        public string dobs { get; set; }
        public string tcli { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }


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

