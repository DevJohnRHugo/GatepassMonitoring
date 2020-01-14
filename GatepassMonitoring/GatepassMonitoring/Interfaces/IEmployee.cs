using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatepassMonitoring.Interfaces {
    public interface IEmployee {
         int ID { get; set; }
        int EmpID { get; set; }
        string Name { get; set; }
        string Designation { get; set; }

    }
}
