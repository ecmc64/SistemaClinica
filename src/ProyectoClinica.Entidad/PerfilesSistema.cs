using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class PerfilesSistema
    {
        public PerfilesSistema()
        {
            OpcionesPerfil = new HashSet<OpcionesPerfil>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int PerfilId { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<OpcionesPerfil> OpcionesPerfil { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
