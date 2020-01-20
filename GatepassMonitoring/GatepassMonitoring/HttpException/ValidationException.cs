using GatepassMonitoring.Interfaces;
using GatepassMonitoring.RetrieveRecordLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace GatepassMonitoring.HttpException {
    public class ValidationException : IValidationException {

        //GatepassDbContext _context = new GatepassDbContext( );

        //IRetrieveEmployeeSingleOrDefault _retrieveEmployeeSingleOrDefault;

        //public ValidationException( IRetrieveEmployeeSingleOrDefault retrieveEmployeeSingleOrDefault ) {

        //    _retrieveEmployeeSingleOrDefault = retrieveEmployeeSingleOrDefault;

        //}

        //public ValidationException( ) {

        //    _retrieveEmployeeSingleOrDefault = new RetrieveEmployeeSingleOrDefault( );

        //}

        //public IEmployee RequestException( int id ) {
        //    var checkerBodegero = _retrieveEmployeeSingleOrDefault.GetEmployee( id, _context );         

        //    return checkerBodegero;

        //}



    }
}