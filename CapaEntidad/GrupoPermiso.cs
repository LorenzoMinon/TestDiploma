using System.Collections.Generic;

namespace CapaEntidad
{
    public class GrupoPermiso : IPermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Asignado { get; set; }
        public List<IPermiso> Permisos { get; set; } = new List<IPermiso>();
    }
}
