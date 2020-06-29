using System;
using System.Collections.Generic;
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

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> Lista = new List<Usuario>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spListarUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Crear objetos de tipo Usuario
                    Usuario objUsuario= new Usuario();
                    objUsuario.Activo = Convert.ToBoolean(dr["activo"].ToString());
                    objUsuario.Id_Usuario = Convert.ToInt32(dr["id_usuario"].ToString());
                    objUsuario.Correo_Electronico = dr["correo_electronico"].ToString();
                    objUsuario.Password = dr["password"].ToString();
                    objUsuario.Fecha_Creacion = Convert.ToDateTime(dr["fecha_creacion"].ToString());
                    objUsuario.Codigo_Rol = Convert.ToChar(dr["rol_cod_rol"].ToString());

                    // añadir a la lista de objetos
                    Lista.Add(objUsuario);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return Lista;
        }
        
        public bool RegistrarUsuario(Usuario objUsuario)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmId", objUsuario.Id_Usuario);
                cmd.Parameters.AddWithValue("@prmCorreo", objUsuario.Correo_Electronico);
                cmd.Parameters.AddWithValue("@prmContrasena", objUsuario.Password);
                cmd.Parameters.AddWithValue("@prmFecha", objUsuario.Fecha_Creacion);
                cmd.Parameters.AddWithValue("@prmActivo", objUsuario.Activo);
                cmd.Parameters.AddWithValue("@prmRol", objUsuario.Codigo_Rol);
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
    }
    
    
}