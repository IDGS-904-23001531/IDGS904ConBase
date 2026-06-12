using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IDGS904ConBase.Models
{
    public class AlumnoContext: DbContext
    {
        private const string ConnectionString = "DefaultConnection";
        public AlumnoContext():base(ConnectionString) 
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Maestro> Maestros { get; set; }

    }
}