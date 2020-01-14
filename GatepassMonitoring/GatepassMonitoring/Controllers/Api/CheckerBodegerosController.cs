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
        private GatepassDbContext _context;

        public CheckerBodegerosController( ) {
            _context = new GatepassDbContext( );
        }

        //GET /api/checkerBodegeros
        public IEnumerable<CheckerBodegero> GetCheckerBodegeros( ) {

            return _context.CheckerBodegeros.ToList( );

        }

        //GET /api/checkerBodegeros/1
        public CheckerBodegero GetCheckerBodegero( int id ) {

            var checkerBodegero = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );
            
            if( checkerBodegero == null )
                throw new HttpResponseException( HttpStatusCode.NotFound );

            return checkerBodegero;

        }

        //POST /api/checkerBodegeros
        [HttpPost]
        public CheckerBodegero CreateCheckerBodegero( CheckerBodegero checkerBodegero ) {

            if( !ModelState.IsValid )
                throw new HttpResponseException( HttpStatusCode.BadRequest );
            _context.CheckerBodegeros.Add( checkerBodegero );
            _context.SaveChanges( );
            return checkerBodegero;
        }

        //PUT /api/checkerBodegeros/1
        [HttpPut]
        public void UpdateCheckerBodegero( int id, CheckerBodegero checkerBodegero ) {

            if( !ModelState.IsValid )
                throw new HttpResponseException( HttpStatusCode.BadRequest );
            var checkerBodegeroInDb = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );
            if(checkerBodegeroInDb == null)
                throw new HttpResponseException( HttpStatusCode.NotFound );

            checkerBodegeroInDb.EmpID = checkerBodegero.EmpID;
            checkerBodegeroInDb.Name = checkerBodegero.Name;
            checkerBodegeroInDb.Designation = checkerBodegero.Designation;

            _context.SaveChanges( );
        }

        //DELETE /api/checkerBodegeros/1
        [HttpDelete]
        public void DeleteCheckerBodegero( int id ) {

            var checkerBodegeroInDb = _context.CheckerBodegeros.SingleOrDefault( c => c.ID == id );
            if( checkerBodegeroInDb == null )
                throw new HttpResponseException( HttpStatusCode.NotFound );

            _context.CheckerBodegeros.Remove( checkerBodegeroInDb );
            _context.SaveChanges( );
        }



    }
}
