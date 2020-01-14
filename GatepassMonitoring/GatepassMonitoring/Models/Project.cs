using GatepassMonitoring.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GatepassMonitoring.Models {
    public class Project : IProject {
        public string District { get; set; }

        public int ID { get; set; }

        public string Locale { get; set; }
    }
}