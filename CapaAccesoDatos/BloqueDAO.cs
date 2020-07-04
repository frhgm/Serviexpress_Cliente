using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class BloqueDAO
    {
        #region "PATRON SINGLETON"
        private static BloqueDAO daoBloque = null;
        private BloqueDAO() { }
        public static BloqueDAO getInstance()
        {
            if (daoBloque == null)
            {
                daoBloque = new BloqueDAO();
            }
            return daoBloque;
        }
        #endregion
        public List<BloqueHora> ListarReservas(int rut)
        {
            SqlConnection conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<BloqueHora> Lista = null;

            try
            {
                cmd = new SqlCommand("spListaHorariosReserva", conexion);
                cmd.Parameters.AddWithValue("@prmRut", rut);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                dr = cmd.ExecuteReader();

                Lista = new List<BloqueHora>();

                while (dr.Read())
                {
                    // llenamos los objetos
                    BloqueHora objHora = new BloqueHora();
                    objHora.Id_Horario = Convert.ToInt32(dr["id_horario"].ToString());
                    objHora.Hora_Inicio = TimeSpan.Parse(dr["hora_inicio"].ToString());

                    Lista.Add(objHora);
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
        
        public List<BloqueHora> ListarBloques(int rut, DateTime fecha)
        {
            SqlConnection conexion = Conexion.getInstance().ConexionBD();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<BloqueHora> Lista = null;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spListaBloques", conexion);
                cmd.Parameters.AddWithValue("@prmRut", rut);
                cmd.Parameters.AddWithValue("@prmFecha", fecha);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                dr = cmd.ExecuteReader();

                Lista = new List<BloqueHora>();

                while (dr.Read())
                {
                    // llenamos los objetos
                    BloqueHora objBloqueHora = new BloqueHora();
                    objBloqueHora.Id_Horario = Convert.ToInt32(dr["id_horario"].ToString());
                    objBloqueHora.Hora_Inicio = TimeSpan.Parse(dr["hora_inicio"].ToString());
                    objBloqueHora.Bloque = dr["BLOQUE"].ToString();
                    Lista.Add(objBloqueHora);
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