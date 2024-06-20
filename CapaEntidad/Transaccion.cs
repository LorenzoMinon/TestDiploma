using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Transaccion
    {
        public int IdTransaccion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public int CuentaDebe { get; set; } // Cuenta que recibe el débito
        public int CuentaHaber { get; set; } // Cuenta que recibe el crédito
        public string Descripcion { get; set; }
    }
}