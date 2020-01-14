using GatepassMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatepassMonitoring.Interfaces {
    public interface IGatepass {
         int ID { get; set; }
        DateTime DateIssued { get; set; }
        CheckerBodegero CheckerBodegero { get; set; }
        byte CheckerBodegeroId { get; set; }

        Project Project { get; set; }

        byte ProjectId { get; set; }

        string PickUp { get; set; }

        int? QuantityShort { get; set; }

        string GatePassHalf { get; set; }

        int? QuantityLong { get; set; }

        string GatePassLong { get; set; }

        string Remarks { get; set; }


    }
}
