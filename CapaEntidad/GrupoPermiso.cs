using System.Collections.Generic;
using System.Linq;
using System;

namespace CapaEntidad
{
    public class GrupoPermiso : IPermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Asignado { get; set; }
        private List<IPermiso> _permisos = new List<IPermiso>();

        public void Agregar(IPermiso permiso)
        {
            _permisos.Add(permiso);
        }

        public void Eliminar(IPermiso permiso)
        {
            _permisos.Remove(permiso);
        }

        public IPermiso ObtenerPermiso(int id)
        {
            return _permisos.FirstOrDefault(p => p.Id == id);
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Grupo: {Nombre}");
            foreach (var permiso in _permisos)
            {
                permiso.MostrarDetalles();
            }
        }

        public List<IPermiso> ObtenerPermisos()
        {
            return _permisos;
        }
    }
}
