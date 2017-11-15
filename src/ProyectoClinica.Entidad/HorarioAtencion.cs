using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class HorarioAtencion
    {
        public HorarioAtencion()
        {
            ProgramaAtencion = new HashSet<ProgramaAtencion>();
        }

        public int HoraAtencionId { get; set; }
        public string DescripcionRango { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<ProgramaAtencion> ProgramaAtencion { get; set; }
    }
}
