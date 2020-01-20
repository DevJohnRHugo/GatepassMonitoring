using GatepassMonitoring.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GatepassMonitoring.Models {
    public class Project : IProject {

        [Required]
        public string District { get; set; }

        public int ID { get; set; }

        [Required]
        public string Locale { get; set; }
    }
}