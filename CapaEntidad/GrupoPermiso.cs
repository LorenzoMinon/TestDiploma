using System;
using System.Collections.Generic;

namespace CapaEntidad
{
    public class GrupoPermiso : IPermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Asignado { get; set; }
        public List<IPermiso> Permisos { get; set; }

        public GrupoPermiso()
        {
            Permisos = new List<IPermiso>();
        }

        public void AgregarPermiso(IPermiso permiso)
        {
            Permisos.Add(permiso);
        }

        public void EliminarPermiso(IPermiso permiso)
        {
            Permisos.Remove(permiso);
        }

        public void Mostrar()
        {
            Console.WriteLine($"Grupo de Permiso: {Nombre}");
            foreach (var permiso in Permisos)
            {
                permiso.Mostrar();
            }
        }
    }
}
