﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class usrrolop
    {
        [Key]
        public int iusrrolop { get; set; }
        public int irol { get; set; }
        [ForeignKey("irol")]
        public virtual userrol Rol { get; set; }
        public int iuserop { get; set; }
        [ForeignKey("iuserop")]
        public virtual userop Operacion { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }
}
