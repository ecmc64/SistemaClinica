using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class Usuarios
    {
        public int? PerfilId { get; set; }
        public DateTime? FechaUltimoIngreso { get; set; }
        public bool? Estado { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int PersonaId { get; set; }

        public virtual PerfilesSistema Perfil { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
