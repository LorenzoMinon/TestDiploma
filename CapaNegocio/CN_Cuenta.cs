// CapaNegocio/CN_Cuenta.cs
using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Cuenta
    {
        private CD_Cuenta objCD_Cuenta = new CD_Cuenta();

        public bool Registrar(Cuenta cuenta, out string Mensaje)
        {
            return objCD_Cuenta.Registrar(cuenta, out Mensaje);
        }

        public List<Cuenta> Listar()
        {
            return objCD_Cuenta.Listar();
        }
    }
}
