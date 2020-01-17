using GatepassMonitoring.Interfaces;
using GatepassMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace GatepassMonitoring.ModelStateValidation {
    public class ModelValidation : ApiController, IModelValidation {
       
        public void Validation( HttpStatusCode httpStatusCode ) {

            if( !ModelState.IsValid )
                throw new HttpResponseException( httpStatusCode );
          
        }


    }
}