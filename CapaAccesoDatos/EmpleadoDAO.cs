using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class EmpleadoDAO
    {
        #region "PATRON SINGLETON"
        private static EmpleadoDAO daoEmpleado = null;
        private EmpleadoDAO() { }
        public static EmpleadoDAO getInstance()
        {
            if (daoEmpleado == null)
            {
                daoEmpleado = new EmpleadoDAO();
            }
            return daoEmpleado;
        }
        #endregion

        public Empleado AccesoSistema(String user, String pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Empleado objEmpleado = null;
            SqlDataReader dr = null;
            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objEmpleado = new Empleado();
                    objEmpleado.Rut = Convert.ToInt32(dr["rut_empleado"].ToString());
                    objEmpleado.Nombre = dr["nombre_empleado"].ToString();
                    objEmpleado.Apellido = dr["apellido_empleado"].ToString();
                    objEmpleado.Direccion = dr["direccion"].ToString();
                    objEmpleado.Telefono = Convert.ToInt32(dr["telefono"].ToString());
                    objEmpleado.Telefono_Adicional = Convert.ToInt32(dr["apMaterno"].ToString());
                    objEmpleado.Fecha_Nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"].ToString());
                    objEmpleado.Id_Usuario = Convert.ToInt32(dr["usuario_id_usuario"].ToString());
                }
            }
            catch (Exception ex)
            {
                objEmpleado = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return objEmpleado;
        }

        public Empleado BuscarEmpleado(String nroDocumento)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Empleado objEmpleado = new Empleado();

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spBuscarEmpleado", con);
                cmd.Parameters.AddWithValue("@prmNroDocumento", nroDocumento);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objEmpleado.Rut = Convert.ToInt32(dr["rut_empleado"].ToString());
                    objEmpleado.Nombre = dr["nombre_empleado"].ToString();
                    objEmpleado.Apellido = dr["apellido_empleado"].ToString();
                    objEmpleado.Direccion = dr["direccion"].ToString();
                    objEmpleado.Telefono = Convert.ToInt32(dr["telefono"].ToString());
                    objEmpleado.Telefono_Adicional = Convert.ToInt32(dr["apMaterno"].ToString());
                    objEmpleado.Fecha_Nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"].ToString());
                    objEmpleado.Id_Usuario = Convert.ToInt32(dr["usuario_id_usuario"].ToString());
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }

            return objEmpleado;
        }
        
        public List<Empleado> ListarEmpleados()
        {
            SqlConnection conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<Empleado> Lista = null;

            try
            {
                cmd = new SqlCommand("[spListaEmpleados]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                dr = cmd.ExecuteReader();

                Lista = new List<Empleado>();

                while (dr.Read())
                {
                    // llenamos los objetos
                    Empleado objEmpleado = new Empleado();
                    objEmpleado.Rut = Convert.ToInt32(dr["rut_empleado"].ToString());
                    objEmpleado.Nombre = dr["NOMBRE"].ToString();

                    Lista.Add(objEmpleado);
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
