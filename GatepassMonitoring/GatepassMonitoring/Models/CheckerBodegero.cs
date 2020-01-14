using GatepassMonitoring.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GatepassMonitoring.Models {
    public class CheckerBodegero : IEmployee {
        public string Designation { get; set; }

        public int EmpID { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}