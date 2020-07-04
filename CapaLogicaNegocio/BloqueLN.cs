using System;
using System.Collections.Generic;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class BloqueLN
    {
        #region "PATRON SINGLETON"

        private static BloqueLN bloque = null;

        private BloqueLN()
        {
        }

        public static BloqueLN getInstance()
        {
            if (bloque == null) bloque = new BloqueLN();
            return bloque;
        }

        #endregion

        /*
        public Reserva RegistrarReserva(Reserva objReserva)
        {
            try
            {
                return ReservaDAO.getInstance().RegistrarReserva(objReserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
        public List<BloqueHora> ListarReservas(int rut)
        {
            try
            {
                return BloqueDAO.getInstance().ListarReservas(rut);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<BloqueHora> ListarBloques(int rut, DateTime fecha)
        {
            try
            {
                return BloqueDAO.getInstance().ListarBloques(rut, fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}