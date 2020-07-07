using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ServicioDAO
    {
        #region "PATRON SINGLETON"

        private static ServicioDAO daoServicio = null;

        private ServicioDAO()
        {
        }

        public static ServicioDAO getInstance()
        {
            if (daoServicio == null) daoServicio = new ServicioDAO();
            return daoServicio;
        }

        #endregion


        public List<Servicio> ListarServicios()
        {
            var conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<Servicio> Lista = null;

            try
            {
                cmd = new SqlCommand("[spListaServicios]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                dr = cmd.ExecuteReader();

                Lista = new List<Servicio>();

                while (dr.Read())
                {
                    // llenamos los objetos
                    var objServicio = new Servicio();
                    objServicio.Nombre = dr["SERVICIO"].ToString();
                    objServicio.Codigo_Servicio = Convert.ToInt32(dr["cod_servicio"]);

                    Lista.Add(objServicio);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return Lista;
        }
    }
}