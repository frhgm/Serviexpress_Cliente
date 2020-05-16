using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class UsuarioDAO
    {
        #region "PATRON SINGLETON"
        private static UsuarioDAO daoUsuario = null;
        private UsuarioDAO() { }
        public static UsuarioDAO getInstance()
        {
            if (daoUsuario == null)
            {
                daoUsuario = new UsuarioDAO();
            }
            return daoUsuario;
        }
        #endregion

        public Usuario AccesoSistema(String user, String pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Usuario objUsuario = null;
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
                    objUsuario = new Usuario();
                    objUsuario.Id_Usuario = Convert.ToInt32(dr["id_usuario"].ToString());
                    objUsuario.Correo_Electronico = dr["correo_electronico"].ToString();
                    objUsuario.Password = dr["password"].ToString();
                    objUsuario.Fecha_Creacion = Convert.ToDateTime(dr["fecha_creacion"].ToString());
                    objUsuario.Activo = Convert.ToBoolean(dr["activo"].ToString());
                    objUsuario.Codigo_Rol = Convert.ToInt32(dr["rol_cod_rol"].ToString());
                }
            }
            catch (Exception ex)
            {
                objUsuario = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return objUsuario;
        }
/*
        public Cliente BuscarUsuario(String nroDocumento)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Usuario objUsuario = new Usuario();

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
                    objCliente.Rut = Convert.ToInt32(dr["rut_cliente"].ToString());
                    objCliente.Nombre = dr["nombre_cliente"].ToString();
                    objCliente.Apellido = dr["apellido_cliente"].ToString();
                    objCliente.Direccion = dr["direccion"].ToString();
                    objCliente.Telefono = Convert.ToInt32(dr["telefono"].ToString());
                    objCliente.Telefono_Adicional = Convert.ToInt32(dr["telefono_adicional"].ToString());
                    objCliente.Fecha_Nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"].ToString());
                    objCliente.Id_Usuario = Convert.ToInt32(dr["usuario_id_usuario"].ToString());
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

            return objCliente;
        }
        */
    }
}