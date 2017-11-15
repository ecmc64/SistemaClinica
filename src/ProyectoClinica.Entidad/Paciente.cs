using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class Paciente
    {
        public Paciente()
        {
            ProgramaAtencion = new HashSet<ProgramaAtencion>();
        }

        public DateTime? FechaUltimaVisita { get; set; }
        public string Observacion { get; set; }
        public int PersonaId { get; set; }

        public virtual ICollection<ProgramaAtencion> ProgramaAtencion { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
