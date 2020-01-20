using GatepassMonitoring.Interfaces;
using GatepassMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GatepassMonitoring.Controllers.Api
{
    public class CheckerBodegerosController : ApiController {

        IEmployeeRepository _context;

        public CheckerBodegerosController( IEmployeeRepository gatepassRepository ) {

            _context = gatepassRepository;
        }

        public CheckerBodegerosController( ) {

            _context = new EmployeeRepository( );
           
        }

        //GET /api/checkerBodegeros
        public IEnumerable<IEmployee> GetCheckerBodegeros( ) {

            #region Codes before
            //return _context.CheckerBodegeros.ToList( );
            #endregion

            return _context.GetCheckerBodegero();           

        }


        //GET /api/checkerBodegeros/1
        public IHttpActionResult GetCheckerBodegero( int id ) {

            #region Codes before
            //var checkerBodegero = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

            //if( checkerBodegero == null )
            //    throw new HttpResponseException( HttpStatusCode.NotFound );

            //return checkerBodegero;
            #endregion

            //return _context.GetSingleEmployee( id );

            return Ok( _context.GetSingleEmployee( id ) );

        }


        //POST /api/checkerBodegeros
        [HttpPost]
        public IEmployee CreateCheckerBodegero( CheckerBodegero checkerBodegero ) {

            #region Codes before
            //if( !ModelState.IsValid )
            //    throw new HttpResponseException( HttpStatusCode.BadRequest );

            //_context.CheckerBodegeros.Add( checkerBodegero );
            //_context.SaveChanges( );
            //return checkerBodegero;
            #endregion

            return _context.CreateEmployee( checkerBodegero );

        }


        //PUT /api/checkerBodegeros/1
        [HttpPut]
        public void UpdateCheckerBodegero( int id , CheckerBodegero checkerBodegero ) {

            #region Codes before
            //if( !ModelState.IsValid )
            //    throw new HttpResponseException( HttpStatusCode.BadRequest );

            //var checkerBodegeroInDb = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

            //if( checkerBodegeroInDb == null )
            //    throw new HttpResponseException( HttpStatusCode.NotFound );

            //checkerBodegeroInDb.EmpID = checkerBodegero.EmpID;
            //checkerBodegeroInDb.Name = checkerBodegero.Name;
            //checkerBodegeroInDb.Designation = checkerBodegero.Designation;

            //_context.SaveChanges( );
            #endregion

            _context.UpdateCheckerBodegero( id , checkerBodegero );

        }


        //DELETE /api/checkerBodegeros/1
        [HttpDelete]
        public void DeleteCheckerBodegero( int id ) {

            #region Codes before
            //var checkerBodegeroInDb = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );

            //if( checkerBodegeroInDb == null )
            //    throw new HttpResponseException( HttpStatusCode.NotFound );

            //_context.CheckerBodegeros.Remove( checkerBodegeroInDb );
            //_context.SaveChanges( );
            #endregion

            _context.DeleteCheckerBodegero( id );


        }



    }
}
