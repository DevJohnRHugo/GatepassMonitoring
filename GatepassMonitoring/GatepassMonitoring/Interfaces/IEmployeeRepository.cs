using GatepassMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GatepassMonitoring.Interfaces {
    public interface IEmployeeRepository {

        IEnumerable<IEmployee> GetCheckerBodegero( );

        IEmployee RequestException( int id , HttpStatusCode httpStatusCode );

        IEmployee GetSingleEmployee( int id );

        IEmployee CreateEmployee( CheckerBodegero checkerBodegero );

        void UpdateCheckerBodegero( int id , CheckerBodegero checkerBodegero );

        void DeleteCheckerBodegero( int id );

    }
}
