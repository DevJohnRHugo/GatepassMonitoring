using GatepassMonitoring.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GatepassMonitoring.Models;
using System.Web.Http;
using System.Net;
using GatepassMonitoring.HttpException;
using GatepassMonitoring.ModelStateValidation;

namespace GatepassMonitoring {
    public class EmployeeRepository : IEmployeeRepository {

        GatepassDbContext _context = new GatepassDbContext( );

        IModelValidation _modelValidation;

        public EmployeeRepository( IModelValidation modelValidation ) {
            _modelValidation = modelValidation;

        }

        public EmployeeRepository( ) {
            _modelValidation = new ModelValidation( );
        }

        public IEmployee RequestException( int id, HttpStatusCode httpStatusCode ) {
            var checkerBodegero = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

            if( checkerBodegero == null )
                StatusCodeExceptionResponse.StatusCodeException( httpStatusCode );
            
            return checkerBodegero;

        }

        public IEnumerable<IEmployee> GetCheckerBodegero( ) {
           
            return _context.CheckerBodegeros.ToList( );

        }

        public IEmployee GetSingleEmployee( int id ) {
            var checkerBodegero = RequestException( id, HttpStatusCode.NotFound );

            return checkerBodegero;

        }

        public IEmployee CreateEmployee( CheckerBodegero checkerBodegero ) {

            _context.CheckerBodegeros.Add( checkerBodegero );
            _context.SaveChanges( );
            return checkerBodegero;

        }

        public void UpdateCheckerBodegero( int id , CheckerBodegero checkerBodegero ) {

            _modelValidation.Validation( HttpStatusCode.BadRequest );

            var checkerBodegeroInDb = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

            RequestException( id, HttpStatusCode.NotFound );

            checkerBodegeroInDb.EmpID = checkerBodegero.EmpID;
            checkerBodegeroInDb.Name = checkerBodegero.Name;
            checkerBodegeroInDb.Designation = checkerBodegero.Designation;

            _context.SaveChanges( );


        }      


        public void DeleteCheckerBodegero( int id ) {

            var checkerBodegeroInDb = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

            RequestException(id, HttpStatusCode.NotFound );

            _context.CheckerBodegeros.Remove( checkerBodegeroInDb );
            _context.SaveChanges( );

        }       

    }
}