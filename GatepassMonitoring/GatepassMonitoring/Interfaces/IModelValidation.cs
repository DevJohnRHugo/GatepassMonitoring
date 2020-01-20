using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GatepassMonitoring.Interfaces {
    public interface IModelValidation {

        IHttpActionResult ErrorBadRequest( IEmployee employee );

        IHttpActionResult ErrorNotFound(  );

        //HttpResponseMessage ErrorBadRequest( IEmployee employee );

    }
}
