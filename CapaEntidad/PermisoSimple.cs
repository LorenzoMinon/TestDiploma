using System;

namespace CapaEntidad
{
    public class PermisoSimple : IPermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Asignado { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Permiso: {Nombre}");
        }

        public void Agregar(IPermiso permiso)
        {
            throw new InvalidOperationException("No se pueden agregar permisos a un permiso simple.");
        }

        public void Eliminar(IPermiso permiso)
        {
            throw new InvalidOperationException("No se pueden eliminar permisos de un permiso simple.");
        }

        public IPermiso ObtenerPermiso(int id)
        {
            return Id == id ? this : null;
        }
    }
}
