public abstract class Component
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool Asignado { get; set; }

    public Component(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public abstract void Add(Component component);
    public abstract void Remove(Component component);
    public abstract Component GetChild(int id);
    public abstract void Display(int depth);
}
