using System;

namespace CapaEntidad
{
    public class PermisoSimple : Component
    {
        public PermisoSimple(int id, string nombre) : base(id, nombre) { }

        public override void Add(Component component)
        {
            throw new InvalidOperationException("No se pueden agregar componentes a un PermisoSimple.");
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException("No se pueden eliminar componentes de un PermisoSimple.");
        }

        public override Component GetChild(int id)
        {
            throw new NotImplementedException("Cannot get child from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Nombre);
        }
    }
}
