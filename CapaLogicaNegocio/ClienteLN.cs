using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ClienteLN
    {
        #region "PATRON SINGLETON"
        private static ClienteLN objCliente = null;
        private ClienteLN() { }
        public static ClienteLN getInstance()
        {
            if (objCliente == null)
            {
                objCliente = new ClienteLN();
            }
            return objCliente;
        }
        #endregion

        public Cliente AccesoSistema(String user, String pass)
        {
            try
            {
                return ClienteDAO.getInstance().AccesoSistema(user, pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente BuscarCliente(String nroDocumento)
        {
            try
            {
                return ClienteDAO.getInstance().BuscarCliente(nroDocumento);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
