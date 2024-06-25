namespace CapaEntidad
{
    public interface IPermiso
    {
        int Id { get; set; }
        string Nombre { get; set; }
        bool Asignado { get; set; }
        void Mostrar();

    }

}
