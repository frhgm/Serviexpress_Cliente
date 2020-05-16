using System;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class UsuarioLN
    {
        #region "PATRON SINGLETON"
        private static UsuarioLN objUsuario = null;
        private UsuarioLN() { }
        public static UsuarioLN getInstance()
        {
            if (objUsuario == null)
            {
                objUsuario = new UsuarioLN();
            }
            return objUsuario;
        }
        #endregion

        public Usuario AccesoSistema(String user, String pass)
        {
            try
            {
                return UsuarioDAO.getInstance().AccesoSistema(user, pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
/*
        public Usuario BuscarUsuario(String nroDocumento)
        {
            try
            {
                return UsuarioDAO.getInstance().BuscarUsuario(nroDocumento);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        */
    }
}