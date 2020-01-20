using GatepassMonitoring.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GatepassMonitoring.Models {
    public class CheckerBodegero : IEmployee {

        [Required]
        public string Designation { get; set; }

        [Required]
        public int EmpID { get; set; }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}