using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GatepassMonitoring.Interfaces {
    public interface IModelValidation {

        void Validation( HttpStatusCode httpStatusCode );

    }
}
