using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class ProgramaAtencion
    {
        public int HoraAtencionId { get; set; }
        public DateTime? FechaAtencion { get; set; }
        public bool? CitaAtendida { get; set; }
        public string Diagnostico { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaDiagnostico { get; set; }
        public DateTime? Fecha { get; set; }
        public int? PersonaId { get; set; }
        public int DoctorId { get; set; }
        public int ProgramaAtencionId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual HorarioAtencion HoraAtencion { get; set; }
        public virtual Paciente Persona { get; set; }
    }
}
