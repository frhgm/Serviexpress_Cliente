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

        private ClienteLN()
        {
        }

        public static ClienteLN getInstance()
        {
            if (objCliente == null) objCliente = new ClienteLN();
            return objCliente;
        }

        #endregion

        public Cliente AccesoSistema(string user, string pass)
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

        public Cliente BuscarCliente(string nroDocumento)
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

        public bool RegistrarCliente(Cliente objCliente)
        {
            try
            {
                return ClienteDAO.getInstance().RegistrarCliente(objCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}