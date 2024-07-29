namespace CapaEntidad
{
    public interface IPermiso
    {
        int Id { get; set; }
        string Nombre { get; set; }
        bool Asignado { get; set; }
        void MostrarDetalles();
        void Agregar(IPermiso permiso);
        void Eliminar(IPermiso permiso);
        IPermiso ObtenerPermiso(int id);
    }
}
