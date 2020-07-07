using System;
using System.Collections.Generic;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class EmpleadoLN
    {
        #region "PATRON SINGLETON"

        private static EmpleadoLN empleado = null;

        private EmpleadoLN()
        {
        }

        public static EmpleadoLN getInstance()
        {
            if (empleado == null) empleado = new EmpleadoLN();
            return empleado;
        }

        #endregion


        public List<Empleado> ListarEmpleados()
        {
            try
            {
                return EmpleadoDAO.getInstance().ListarEmpleados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}