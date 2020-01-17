using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace GatepassMonitoring.HttpException {
    public static class StatusCodeExceptionResponse   {

        public static void StatusCodeException( HttpStatusCode httpStatusCode) {
            throw new HttpResponseException( httpStatusCode );
        }

    }
}