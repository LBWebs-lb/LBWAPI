﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLbWebs.Models
{
    public class clihos
    {
        [Key]
        public int ihos { get; set; }
        public string userhos { get; set; }
        public string passhos { get; set; }
        public string linkwphos { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }
}
