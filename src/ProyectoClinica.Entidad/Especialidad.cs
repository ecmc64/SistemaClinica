using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            Doctor = new HashSet<Doctor>();
        }

        public int EscecialidadId { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Doctor> Doctor { get; set; }
    }
}
