using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ReservaDAO
    {
        #region "PATRON SINGLETON"

        private static ReservaDAO daoReserva = null;

        private ReservaDAO()
        {
        }

        public static ReservaDAO getInstance()
        {
            if (daoReserva == null) daoReserva = new ReservaDAO();
            return daoReserva;
        }

        #endregion

        public bool AgendarReserva(Reserva objReserva)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            var response = false;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("[spAgendarReserva]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmReserva", objReserva.Numero_Reserva);
                cmd.Parameters.AddWithValue("@prmFecha", objReserva.Fecha);
                cmd.Parameters.AddWithValue("@prmPatente", objReserva.Patente);
                cmd.Parameters.AddWithValue("@prmMarca", objReserva.Marca);
                cmd.Parameters.AddWithValue("@prmModelo", objReserva.Modelo);
                cmd.Parameters.AddWithValue("@prmAnno", objReserva.Anno);
                cmd.Parameters.AddWithValue("@prmDescripcion", objReserva.Descripcion);
                cmd.Parameters.AddWithValue("@prmRutCliente", objReserva.Rut_Cliente);
                cmd.Parameters.AddWithValue("@prmServicio", objReserva.Codigo_Servicio);
                cmd.Parameters.AddWithValue("@prmRutEmpleado", objReserva.Rut_Empleado);
                cmd.Parameters.AddWithValue("@prmId_Horario", objReserva.Id_Horario);
                cmd.Parameters.AddWithValue("@prmEstado", objReserva.Estado);


                con.Open();
                var filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;
            }
            catch (Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return response;
        }

        public List<Reserva> Listar(int rut)
        {
            var conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<Reserva> Lista = null;

            try
            {
                cmd = new SqlCommand("[spListaHorariosReserva]", conexion);
                cmd.Parameters.AddWithValue("@prmRut", rut);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                dr = cmd.ExecuteReader();

                Lista = new List<Reserva>();

                while (dr.Read())
                {
                    // llenamos los objetos
                    var objReserva = new Reserva();
                    //DATOS RESERVA
                    objReserva.Numero_Reserva = Convert.ToInt32(dr["n_reserva"].ToString());
                    
                    objReserva.Fecha = Convert.ToDateTime(dr["fecha"].ToString());
                    
                    objReserva.Id_Horario = Convert.ToInt32(dr["bloque_hora_id_horario"].ToString());
                    //DATOS CLIENTE
                    objReserva.Rut_Cliente = Convert.ToInt32(dr["ficha_cliente_rut_cliente"].ToString());
                    //DATOS BLOQUE
                    objReserva.Hora_Inicio = TimeSpan.Parse(dr["hora_inicio"].ToString());
                    objReserva.Hora_Final = TimeSpan.Parse(dr["hora_final"].ToString());

                    Lista.Add(objReserva);
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