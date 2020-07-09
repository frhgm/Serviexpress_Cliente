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
    public class ClienteDAO
    {
        #region "PATRON SINGLETON"

        private static ClienteDAO daoCliente = null;

        private ClienteDAO()
        {
        }

        public static ClienteDAO getInstance()
        {
            if (daoCliente == null) daoCliente = new ClienteDAO();
            return daoCliente;
        }

        #endregion

        public Cliente AccesoSistema(string user, string pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Cliente objCliente = null;
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
                    objCliente = new Cliente();
                    objCliente.Rut = Convert.ToInt32(dr["rut_cliente"].ToString());
                    objCliente.Nombre = dr["nombre_cliente"].ToString();
                    objCliente.Apellido = dr["apellido_cliente"].ToString();
                    objCliente.Direccion = dr["direccion"].ToString();
                    objCliente.Telefono = Convert.ToInt32(dr["telefono"].ToString());
                    objCliente.Telefono_Adicional = Convert.ToInt32(dr["telefono_adicional"].ToString());
                    objCliente.Fecha_Nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"].ToString());
                    objCliente.Tipo_Cliente = Convert.ToBoolean(dr["usuario_id_usuario"].ToString());
                }
            }
            catch (Exception ex)
            {
                objCliente = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return objCliente;
        }

        public bool RegistrarCliente(Cliente objCliente)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            var response = false;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmRut", objCliente.Rut);
                cmd.Parameters.AddWithValue("@prmNombre", objCliente.Nombre);
                cmd.Parameters.AddWithValue("@prmApellido", objCliente.Apellido);
                cmd.Parameters.AddWithValue("@prmTelefono", objCliente.Telefono);
                cmd.Parameters.AddWithValue("@prmTelefono_Adicional", objCliente.Telefono_Adicional);
                cmd.Parameters.AddWithValue("@prmDireccion", objCliente.Direccion);
                cmd.Parameters.AddWithValue("@prmFechaNacimiento", objCliente.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@prmTipoCliente", objCliente.Tipo_Cliente);
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

        public Cliente BuscarCliente(int rut)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Cliente cliente = new Cliente();

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spBuscarCliente", con);
                cmd.Parameters.AddWithValue("@prmRut", rut);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cliente.Rut = Convert.ToInt32(dr["rut_cliente"].ToString());
                    cliente.Nombre = dr["nombre_cliente"].ToString();
                    cliente.Apellido = dr["apellido_cliente"].ToString();
                    cliente.Direccion = dr["direccion"].ToString();
                    cliente.Telefono = Convert.ToInt32(dr["telefono"].ToString());
                    cliente.Telefono_Adicional = Convert.ToInt32(dr["telefono_adicional"].ToString());
                    cliente.Fecha_Nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"].ToString());
                    cliente.Tipo_Cliente = Convert.ToBoolean(dr["usuario_id_usuario"].ToString());
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

            return cliente;
        }
        
        
    }
}