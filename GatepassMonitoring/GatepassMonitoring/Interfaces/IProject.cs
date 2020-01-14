using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatepassMonitoring.Interfaces {
    public interface IProject {
        int ID { get; set; }
        string District { get; set; }
        string Locale { get; set; }
    }
}
