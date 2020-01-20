using GatepassMonitoring.Interfaces;
using GatepassMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GatepassMonitoring.RetrieveRecordLinq {
    public class RetrieveEmployeeSingleOrDefault : IRetrieveEmployeeSingleOrDefault {

       
        public CheckerBodegero GetEmployee( int id , GatepassDbContext _context ) {
            

            return _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

        }

    }
}