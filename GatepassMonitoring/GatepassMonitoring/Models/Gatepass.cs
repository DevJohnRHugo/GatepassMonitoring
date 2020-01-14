using GatepassMonitoring.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GatepassMonitoring.Models {
    public class Gatepass : IGatepass {

        public int ID { get; set; }
        public DateTime DateIssued { get; set; }
        public CheckerBodegero CheckerBodegero { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(255)]
        public byte CheckerBodegeroId { get; set; }

        public Project Project { get; set; }

        [Required]
        [Display( Name = "Project" )]
        [StringLength( 255 )]
        public byte ProjectId { get; set; }


        [Display( Name = "Gatepass-Half" )]
        [StringLength( 255 )]
        public string GatePassHalf { get; set; }


        [Display( Name = "Gatepass-Long" )]
        [StringLength( 255 )]
        public string GatePassLong { get; set; }

        [Display( Name = "Picked-up by" )]
        [StringLength( 255 )]

        public string PickUp { get; set; }


        [Display( Name = "Quantity" )]
        public int? QuantityLong { get; set; }


        [Display( Name = "Quantity" )]
        public int? QuantityShort { get; set; }

        public string Remarks { get; set; }
       
    }
}