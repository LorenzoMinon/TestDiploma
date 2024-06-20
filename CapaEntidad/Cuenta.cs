using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Activo, Pasivo, Patrimonio, Ingreso, Gasto
        public string Codigo { get; set; }
        public int? Padre { get; set; } // Referencia a la cuenta padre si es una subcuenta
    }
}