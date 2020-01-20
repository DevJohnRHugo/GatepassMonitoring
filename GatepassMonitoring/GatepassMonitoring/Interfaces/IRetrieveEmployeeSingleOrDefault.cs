using GatepassMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatepassMonitoring.Interfaces {
    public interface IRetrieveEmployeeSingleOrDefault {

        CheckerBodegero GetEmployee( int id , GatepassDbContext _context );

    }
}
