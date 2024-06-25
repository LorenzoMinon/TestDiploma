using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso cdPermiso = new CD_Permiso();

        // Métodos existentes
        public List<PermisoSimple> ListarPermisosConEstado(int idUsuario)
        {
            return cdPermiso.ListarPermisosConEstado(idUsuario);
        }

        public List<GrupoPermiso> ListarGruposPermisosConEstado(int idUsuario)
        {
            return cdPermiso.ListarGruposPermisosConEstado(idUsuario);
        }

        public PermisoSimple ObtenerPermisoPorNombre(string nombre)
        {
            return cdPermiso.ObtenerPermisoPorNombre(nombre);
        }

        public GrupoPermiso ObtenerGrupoPermisoPorNombre(string nombre)
        {
            return cdPermiso.ObtenerGrupoPermisoPorNombre(nombre);
        }

        public void AsignarPermisoAUsuario(int idUsuario, int idPermiso)
        {
            cdPermiso.AsignarPermisoAUsuario(idUsuario, idPermiso);
        }

        public void RevocarPermisoDeUsuario(int idUsuario, int idPermiso)
        {
            cdPermiso.RevocarPermisoDeUsuario(idUsuario, idPermiso);
        }

        public void AsignarGrupoPermisoAUsuario(int idUsuario, int idGrupoPermiso)
        {
            cdPermiso.AsignarGrupoPermisoAUsuario(idUsuario, idGrupoPermiso);
        }

        public void RevocarGrupoPermisoDeUsuario(int idUsuario, int idGrupoPermiso)
        {
            cdPermiso.RevocarGrupoPermisoDeUsuario(idUsuario, idGrupoPermiso);
        }

        public List<PermisoSimple> ListarPermisos()
        {
            return cdPermiso.ListarPermisos();
        }

        public List<GrupoPermiso> ListarGruposPermisos()
        {
            return cdPermiso.ListarGruposPermisos();
        }

        public int AgregarGrupoPermiso(string nombre)
        {
            return cdPermiso.AgregarGrupoPermiso(nombre);
        }

        public void EditarGrupoPermiso(int idGrupoPermiso, string nuevoNombre)
        {
            cdPermiso.EditarGrupoPermiso(idGrupoPermiso, nuevoNombre);
        }

        public void EliminarGrupoPermiso(int idGrupoPermiso)
        {
            cdPermiso.EliminarGrupoPermiso(idGrupoPermiso);
        }

        public GrupoPermiso ObtenerGrupoPermisoPorId(int idGrupoPermiso)
        {
            return cdPermiso.ObtenerGrupoPermisoPorId(idGrupoPermiso);
        }

        public List<PermisoSimple> ListarPermisosConEstadoParaGrupo(int idGrupoPermiso)
        {
            return cdPermiso.ListarPermisosConEstadoParaGrupo(idGrupoPermiso);
        }

        public void AsignarPermisoAGrupo(int idGrupoPermiso, int idPermiso)
        {
            cdPermiso.AsignarPermisoAGrupo(idGrupoPermiso, idPermiso);
        }

        public void RevocarPermisoDeGrupo(int idGrupoPermiso, int idPermiso)
        {
            cdPermiso.RevocarPermisoDeGrupo(idGrupoPermiso, idPermiso);
        }

        // Métodos para el patrón Composite
        public List<IPermiso> ObtenerTodosLosPermisos()
        {
            return cdPermiso.ObtenerTodosLosPermisos();
        }
    }
}
