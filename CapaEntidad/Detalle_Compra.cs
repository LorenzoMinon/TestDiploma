using System;

namespace CapaEntidad
{
    public class Detalle_Compra
    {
        public int IdDetalleCompra { get; set; }
        public Producto oProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; } // Asegurarse de que es DateTime
        public int CantidadRecibida { get; set; } // Añadimos la propiedad CantidadRecibida
    }
}
