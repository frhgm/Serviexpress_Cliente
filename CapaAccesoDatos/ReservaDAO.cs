using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ReservaDAO
    {
        #region "PATRON SINGLETON"
        private static ReservaDAO daoReserva = null;
        private ReservaDAO() { }
        public static ReservaDAO getInstance()
        {
            if (daoReserva == null)
            {
                daoReserva = new ReservaDAO();
            }
            return daoReserva;
        }
        #endregion
        public bool AgendarReserva(Reserva objReserva)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAgendarReserva", con);
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
                cmd.Parameters.AddWithValue("@prmBloque", objReserva.Bloque_Hora);
                cmd.Parameters.AddWithValue("@prmEstado", objReserva.Estado);
                

                con.Open();
                int filas = cmd.ExecuteNonQuery();
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
            SqlConnection conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<Reserva> Lista = null;

            try
            {
                cmd = new SqlCommand("[spListaHorariosAtencion]", conexion);
                cmd.Parameters.AddWithValue("@prmRut", rut);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                dr = cmd.ExecuteReader();

                Lista = new List<Reserva>();

                while (dr.Read())
                {
                    // llenamos los objetos
                    Reserva objReserva = new Reserva();
                    //DATOS RESERVA
                    objReserva.Numero_Reserva = Convert.ToInt32(dr["n_reserva"].ToString());
                    objReserva.Fecha = Convert.ToDateTime(dr["fecha"].ToString());
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
        
        /*
        public List<HorarioAtencion> ListarHorarioReservas(Int32 IdEspecialidad, DateTime Fecha)
        {
            SqlConnection conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<HorarioAtencion> Lista = null;

            try
            {
                cmd = new SqlCommand("spListarHorariosAtencionPorFecha", conexion);
                cmd.Parameters.AddWithValue("@prmIdEspecialidad", IdEspecialidad);
                cmd.Parameters.AddWithValue("@prmFecha", Fecha);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                dr = cmd.ExecuteReader();

                Lista = new List<HorarioAtencion>();

                while (dr.Read())
                {
                    // llenamos los objetos
                    HorarioAtencion objHorarioAtencion = new HorarioAtencion();
                    Medico objMedico = new Medico();
                    Hora objHora = new Hora();

                    objHora.IdHora = Convert.ToInt32(dr["idHora"].ToString());
                    objHora.hora = dr["hora"].ToString();
                    objHorarioAtencion.Hora = objHora;

                    objMedico.IdMedico = Convert.ToInt32(dr["idMedico"].ToString());
                    objMedico.Nombre = dr["nombres"].ToString();
                    objHorarioAtencion.Medico = objMedico;

                    objHorarioAtencion.IdHorarioAtencion = Convert.ToInt32(dr["idHorarioAtencion"].ToString());
                    objHorarioAtencion.Fecha = Convert.ToDateTime(dr["fecha"].ToString());

                    Lista.Add(objHorarioAtencion);
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

        public bool Eliminar(int idHorarioAtencion)
        {
            SqlConnection conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            bool ok = false;
            try
            {
                cmd = new SqlCommand("spEliminarHorarioAtencion", conexion);
                cmd.Parameters.AddWithValue("@prmIdHorarioAtencion", idHorarioAtencion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                cmd.ExecuteNonQuery();

                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return ok;
        }


        public bool Editar(HorarioAtencion objHorario)
        {
            SqlConnection conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                cmd = new SqlCommand("spActualizarHorarioAtencion", conexion);
                cmd.Parameters.AddWithValue("@prmIdMedico", objHorario.Medico.IdMedico);
                cmd.Parameters.AddWithValue("@prmIdHorario", objHorario.IdHorarioAtencion);
                cmd.Parameters.AddWithValue("@prmFecha", objHorario.Fecha);
                cmd.Parameters.AddWithValue("@prmHora", objHorario.Hora.hora);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                cmd.ExecuteNonQuery();

                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return ok;
        }
        */
    }
}