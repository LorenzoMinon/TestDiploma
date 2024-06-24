using System.Collections.Generic;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso _cdPermiso = new CD_Permiso();

        public List<PermisoSimple> ListarPermisosConEstado(int idUsuario)
        {
            return _cdPermiso.ListarPermisosConEstado(idUsuario);
        }

        public List<GrupoPermiso> ListarGruposPermisosConEstado(int idUsuario)
        {
            return _cdPermiso.ListarGruposPermisosConEstado(idUsuario);
        }

        public PermisoSimple ObtenerPermisoPorNombre(string nombre)
        {
            return _cdPermiso.ObtenerPermisoPorNombre(nombre);
        }

        public GrupoPermiso ObtenerGrupoPermisoPorNombre(string nombre)
        {
            return _cdPermiso.ObtenerGrupoPermisoPorNombre(nombre);
        }

        public void AsignarPermisoAUsuario(int idUsuario, int idPermiso)
        {
            _cdPermiso.AsignarPermisoAUsuario(idUsuario, idPermiso);
        }

        public void RevocarPermisoDeUsuario(int idUsuario, int idPermiso)
        {
            _cdPermiso.RevocarPermisoDeUsuario(idUsuario, idPermiso);
        }

        public void AsignarGrupoPermisoAUsuario(int idUsuario, int idGrupoPermiso)
        {
            _cdPermiso.AsignarGrupoPermisoAUsuario(idUsuario, idGrupoPermiso);
        }

        public void RevocarGrupoPermisoDeUsuario(int idUsuario, int idGrupoPermiso)
        {
            _cdPermiso.RevocarGrupoPermisoDeUsuario(idUsuario, idGrupoPermiso);
        }

        public List<PermisoSimple> ListarPermisos()
        {
            return _cdPermiso.ListarPermisos();
        }

        public List<GrupoPermiso> ListarGruposPermisos()
        {
            return _cdPermiso.ListarGruposPermisos();
        }

        public int AgregarGrupoPermiso(string nombre)
        {
            return _cdPermiso.AgregarGrupoPermiso(nombre);
        }

        public void EditarGrupoPermiso(int idGrupoPermiso, string nuevoNombre)
        {
            _cdPermiso.EditarGrupoPermiso(idGrupoPermiso, nuevoNombre);
        }

        public void EliminarGrupoPermiso(int idGrupoPermiso)
        {
            _cdPermiso.EliminarGrupoPermiso(idGrupoPermiso);
        }

        public GrupoPermiso ObtenerGrupoPermisoPorId(int idGrupoPermiso)
        {
            return _cdPermiso.ObtenerGrupoPermisoPorId(idGrupoPermiso);
        }

        public List<PermisoSimple> ListarPermisosConEstadoParaGrupo(int idGrupoPermiso)
        {
            return _cdPermiso.ListarPermisosConEstadoParaGrupo(idGrupoPermiso);
        }

        public void AsignarPermisoAGrupo(int idGrupoPermiso, int idPermiso)
        {
            _cdPermiso.AsignarPermisoAGrupo(idGrupoPermiso, idPermiso);
        }

        public void RevocarPermisoDeGrupo(int idGrupoPermiso, int idPermiso)
        {
            _cdPermiso.RevocarPermisoDeGrupo(idGrupoPermiso, idPermiso);
        }
    }
}
