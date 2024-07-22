using System;

namespace CapaEntidad
{
    public class Auditoria
    {
        public int AuditoriaID { get; set; }
        public string Tabla { get; set; }
        public string Operacion { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
    }
}
