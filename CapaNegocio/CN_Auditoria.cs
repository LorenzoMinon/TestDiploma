using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Auditoria
    {
        private CD_Auditoria objcd_Auditoria = new CD_Auditoria();

        public void RegistrarAuditoria(string tabla, string operacion, int usuarioID, string valorAnterior, string valorNuevo)
        {
            Auditoria auditoria = new Auditoria
            {
                Tabla = tabla,
                Operacion = operacion,
                UsuarioID = usuarioID,
                FechaOperacion = DateTime.Now,
                ValorAnterior = valorAnterior,
                ValorNuevo = valorNuevo
            };

            objcd_Auditoria.InsertarAuditoria(auditoria);
        }

        public List<Auditoria> ObtenerAuditorias()
        {
            return objcd_Auditoria.ObtenerAuditorias();
        }
    }
}
