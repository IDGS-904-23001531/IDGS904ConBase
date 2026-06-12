using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904ConBase.Models
{
    public class Alumno
    {

        public int Id { get; set;  }
        [Required]
        [StringLength(100)]
        public string nombre { get; set;  }
        [StringLength(150)]
        public string Apaterno { get; set;  }
        [StringLength(150)]
        public string Amaterno { get; set;  }
        public int Edad { get; set;  }
        public string Correo { get; set;  }
    }
}