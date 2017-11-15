using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class Doctor
    {
        public Doctor()
        {
            ProgramaAtencion = new HashSet<ProgramaAtencion>();
        }

        public int? EscecialidadId { get; set; }
        public string NumeroColegiatura { get; set; }
        public DateTime? FechaAlta { get; set; }
        public bool? Estado { get; set; }
        public string Comentario { get; set; }
        public int DoctorId { get; set; }

        public virtual ICollection<ProgramaAtencion> ProgramaAtencion { get; set; }
        public virtual Persona DoctorNavigation { get; set; }
        public virtual Especialidad Escecialidad { get; set; }
    }
}
