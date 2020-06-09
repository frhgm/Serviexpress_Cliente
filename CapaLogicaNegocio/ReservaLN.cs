using System;
using System.Collections.Generic;
using CapaAccesoDatos;
using CapaEntidades;

namespace CapaLogicaNegocio
{
    public class ReservaLN
    {
        #region "PATRON SINGLETON"
        private static ReservaLN reserva = null;
        private ReservaLN() { }
        public static ReservaLN getInstance()
        {
            if (reserva == null)
            {
                reserva = new ReservaLN();
            }
            return reserva;
        }
        #endregion
        public bool AgendarReserva(Reserva objReserva)
        {
            try
            {
                return ReservaDAO.getInstance().AgendarReserva(objReserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Reserva> Listar(int rut)
        {
            try
            {
                return ReservaDAO.getInstance().Listar(rut);
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