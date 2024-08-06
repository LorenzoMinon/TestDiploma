using System.Collections.Generic;
using System.Linq;
using System;

namespace CapaEntidad
{
    public class GrupoPermiso : Component
    {
        private List<Component> _children = new List<Component>();

        public GrupoPermiso(int id, string nombre) : base(id, nombre) { }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override Component GetChild(int id)
        {
            return _children.FirstOrDefault(c => c.Id == id);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Nombre);
            foreach (var child in _children)
            {
                child.Display(depth + 2);
            }
        }

        public List<Component> GetChildren()
        {
            return _children;
        }
    }
}
