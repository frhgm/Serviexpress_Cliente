using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

namespace Front
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> Lista = null;
            try
            {
                Lista = UsuarioLN.getInstance().ListarUsuarios();
            }
            catch (Exception ex)
            {
                Lista = new List<Usuario>();
            }
            return Lista;
        }
        
        private Usuario GetEntity()
        {
            Usuario objUsuario = new Usuario();
            objUsuario.Id_Usuario = Convert.ToInt32(txtUsuario.Text);
            objUsuario.Correo_Electronico = txtCorreo.Text;
            objUsuario.Password = txtPassword.Text;
            objUsuario.Fecha_Creacion = Convert.ToDateTime(txtFecha.Text);
            /* DateTime tempDate = Convert.ToDateTime("1/1/2010 12:10:15 PM", culture); */
            objUsuario.Codigo_Rol = Convert.ToInt32(txtRol.Text);
            objUsuario.Activo = Convert.ToBoolean(txtActivo.Text);

            return objUsuario;
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Registro del paciente
            Usuario objUsuario = GetEntity();
            // enviar a la capa de logica de negocio
            bool response = UsuarioLN.getInstance().RegistrarUsuario(objUsuario);
            if (response)
            {
                Response.Write("<script>alert('REGISTRO CORRECTO.')</script>");

            }
            else
            {
                Response.Write("<script>alert('REGISTRO INCORRECTO.')</script>");
            }
        }
        
    }
}