using System;
using System.Collections.Generic;

namespace ProyectoClinica.Entidad
{
    public partial class OpcionSistema
    {
        public OpcionSistema()
        {
            OpcionesPerfil = new HashSet<OpcionesPerfil>();
        }

        public int OpcionId { get; set; }
        public string DescripcionOpcion { get; set; }
        public bool? Estado { get; set; }
        public string TipoOpcion { get; set; }
        public string SubTipoOpcion { get; set; }

        public virtual ICollection<OpcionesPerfil> OpcionesPerfil { get; set; }
    }
}
