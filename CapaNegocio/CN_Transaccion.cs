// CapaNegocio/CN_Transaccion.cs
using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Transaccion
    {
        private CD_Transaccion objCD_Transaccion = new CD_Transaccion();

        public bool Registrar(Transaccion transaccion, out string Mensaje)
        {
            return objCD_Transaccion.Registrar(transaccion, out Mensaje);
        }

        public List<Transaccion> Listar()
        {
            return objCD_Transaccion.Listar();
        }
    }
}
