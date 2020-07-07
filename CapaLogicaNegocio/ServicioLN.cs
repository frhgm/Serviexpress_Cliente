using System;
using System.Collections.Generic;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class ServicioLN
    {
        #region "PATRON SINGLETON"

        private static ServicioLN servicio = null;

        private ServicioLN()
        {
        }

        public static ServicioLN getInstance()
        {
            if (servicio == null) servicio = new ServicioLN();
            return servicio;
        }

        #endregion


        public List<Servicio> ListarServicios()
        {
            try
            {
                return ServicioDAO.getInstance().ListarServicios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}