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
        public List<BloqueHora> Listar(int rut)
        {
            try
            {
                return BloqueDAO.getInstance().Listar(rut);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
        public List<Reserva> ListarReservas()
        {
            try
            {
                return ReservaDAO.getInstance().ListarReservas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /*
        public bool Eliminar(int idHorarioAtencion)
        {
            try
            {
                return HorarioAtencionDAO.getInstance().Eliminar(idHorarioAtencion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Editar(HorarioAtencion objHorario)
        {
            try
            {
                return HorarioAtencionDAO.getInstance().Editar(objHorario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
    }
}