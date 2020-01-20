using GatepassMonitoring.Interfaces;
using GatepassMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace GatepassMonitoring.ModelStateValidation {
    public class ModelValidation : ApiController, IModelValidation {

        public IHttpActionResult ErrorBadRequest( IEmployee employee ) {

            if( !ModelState.IsValid )
                //throw new HttpResponseException( httpStatusCode );
                return BadRequest( );

            return Ok( );
        }

        public IHttpActionResult ErrorNotFound(  ) {
            //if( !ModelState.IsValid )
                //throw new HttpResponseException( httpStatusCode );
                return NotFound( );

            //return Ok( );
        }


        //public HttpResponseMessage ErrorBadRequest( IEmployee employee ) {

        //    if( ModelState.IsValid )
        //    {
        //        // Do something with the product (not shown).

        //        return new HttpResponseMessage( HttpStatusCode.OK );
        //    }
        //    return Request.CreateErrorResponse( HttpStatusCode.BadRequest , ModelState );
        //}

    }
}