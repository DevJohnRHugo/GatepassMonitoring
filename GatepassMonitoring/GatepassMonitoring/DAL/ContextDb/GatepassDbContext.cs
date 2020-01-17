using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GatepassMonitoring.Models;
using GatepassMonitoring.Interfaces;

namespace GatepassMonitoring {
    public class GatepassDbContext : DbContext {
        public DbSet<CheckerBodegero> CheckerBodegeros { get; set; }

        public DbSet<Gatepass> Gatepasses { get; set; }

        public DbSet<Project> Projects { get; set; }
    }
}