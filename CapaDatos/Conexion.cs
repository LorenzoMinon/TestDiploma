using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        // Instancia estática y de solo lectura de la propia clase
        private static readonly Conexion instancia = new Conexion();

        // Cadena de conexión
        public string Cadena { get; private set; }

        // Constructor privado para evitar instanciación externa
        private Conexion()
        {
            Cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
        }

        // Método estático para obtener la instancia
        public static Conexion Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}