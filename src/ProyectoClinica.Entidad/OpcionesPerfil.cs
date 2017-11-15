using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class OpcionesPerfil
    {
        public int? PerfilId { get; set; }
        public int? OpcionId { get; set; }
        public int OpcionPorPerfilId { get; set; }

        public virtual OpcionSistema Opcion { get; set; }
        public virtual PerfilesSistema Perfil { get; set; }
    }
}
