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
using GatepassMonitoring.RetrieveRecordLinq;

namespace GatepassMonitoring {
    public class EmployeeRepository : IEmployeeRepository {

        GatepassDbContext _context = new GatepassDbContext( );

        IModelValidation _modelValidation;

        IValidationException _validationException;

        IRetrieveEmployeeSingleOrDefault _retrieveEmployeeSingleOrDefault;

        public EmployeeRepository( IModelValidation modelValidation ) {

            _modelValidation = modelValidation;

        }

        public EmployeeRepository( IValidationException validationException ) {

            _validationException = validationException;

        }

        public EmployeeRepository( IRetrieveEmployeeSingleOrDefault retrieveEmployeeSingleOrDefault ) {

            _retrieveEmployeeSingleOrDefault = retrieveEmployeeSingleOrDefault;

        }


        public EmployeeRepository( ) {

            _modelValidation = new ModelValidation( );

            _validationException = new ValidationException( );

            _retrieveEmployeeSingleOrDefault = new RetrieveEmployeeSingleOrDefault( );
          
        }

       
        /// <summary>
        /// GET request the employee recrods
        /// </summary>
        /// <returns>Checker/Bodegero</returns>

        public IEnumerable<IEmployee> GetCheckerBodegero( ) {
           
            return _context.CheckerBodegeros.ToList( );

        }

        /// <summary>
        /// GET request a single employee with the primary key id
        /// </summary>
        /// <param name="id">Identity</param>
        /// <returns>Single Checker/Bodegero</returns>
        public IEmployee GetSingleEmployee( int id ) {

            var checkerBodegero = _retrieveEmployeeSingleOrDefault.GetEmployee( id, _context );

            if( checkerBodegero == null )
                //StatusCodeExceptionResponse.StatusCodeException( HttpStatusCode.NotFound );
                _modelValidation.ErrorNotFound( );

            return checkerBodegero;

        }

        /// <summary>
        /// POST request
        /// Creates new Employee
        /// </summary>
        /// <param name="checkerBodegero">Object model</param>
        /// <returns>New Checker/Bodegero</returns>
        public IEmployee CreateEmployee( CheckerBodegero checkerBodegero ) {

            _modelValidation.ErrorBadRequest( checkerBodegero );

            _context.CheckerBodegeros.Add( checkerBodegero );
            _context.SaveChanges( );
            return checkerBodegero;

        }

        /// <summary>
        /// PUT request
        /// Edit and updates the records of employee
        /// </summary>
        /// <param name="id">Identity</param>
        /// <param name="checkerBodegero">Object model</param>
        public void UpdateCheckerBodegero( int id , CheckerBodegero checkerBodegero ) {

            //_modelValidation.ErrorBadRequest(  );

            var checkerBodegeroInDb = _retrieveEmployeeSingleOrDefault.GetEmployee( id, _context );

            //_validationException.RequestException( id/*, HttpStatusCode.NotFound*/ );
            if( checkerBodegeroInDb == null )
                StatusCodeExceptionResponse.StatusCodeException( HttpStatusCode.NotFound );

            checkerBodegeroInDb.EmpID = checkerBodegero.EmpID;
            checkerBodegeroInDb.Name = checkerBodegero.Name;
            checkerBodegeroInDb.Designation = checkerBodegero.Designation;

            _context.SaveChanges( );

        }

        //if( !ModelState.IsValid )
        //    throw new HttpResponseException( HttpStatusCode.BadRequest );

        //var checkerBodegeroInDb = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

        //if( checkerBodegeroInDb == null )
        //    throw new HttpResponseException( HttpStatusCode.NotFound );

        //checkerBodegeroInDb.EmpID = checkerBodegero.EmpID;
        //checkerBodegeroInDb.Name = checkerBodegero.Name;
        //checkerBodegeroInDb.Designation = checkerBodegero.Designation;

        //_context.SaveChanges( );


        /// <summary>
        /// DELETE request
        /// Deletes the employee
        /// </summary>
        /// <param name="id">Identity</param>
        public void DeleteCheckerBodegero( int id ) {

            //_modelValidation.ErrorNotFound( );

            var checkerBodegeroInDb = _retrieveEmployeeSingleOrDefault.GetEmployee( id, _context );

            //_validationException.RequestException(id/*, HttpStatusCode.NotFound*/ );
            if( checkerBodegeroInDb == null )
                StatusCodeExceptionResponse.StatusCodeException( HttpStatusCode.NotFound );

            _context.CheckerBodegeros.Remove( checkerBodegeroInDb );
            _context.SaveChanges( );

        }

        //var checkerBodegeroInDb = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

        //if( checkerBodegeroInDb == null )
        //    throw new HttpResponseException( HttpStatusCode.NotFound );

        //_context.CheckerBodegeros.Remove( checkerBodegeroInDb );
        //_context.SaveChanges( );


    }
}