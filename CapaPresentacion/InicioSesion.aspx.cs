using CapaEntidades;
using CapaLogicaNegocio;
using CapaPresentacion.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class InicioSesion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) Session["UserSessionId"] = null;
        }

        protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var conectado = false;
            var auth = Membership.ValidateUser(LoginUser.UserName, LoginUser.Password);

            if (auth)
            {
                var objUsuario = UsuarioLN.getInstance().AccesoSistema(LoginUser.UserName, LoginUser.Password);

                if (objUsuario != null)
                {
                    var sessionManager = new SessionManager(Session);
                    //SessionManager.UserSessionId = objEmpleado.ID.ToString();
                    sessionManager.UserSessionUsuario = objUsuario;
                    FormsAuthentication.SetAuthCookie(LoginUser.UserName, true);
                    Response.Redirect("miCuenta.aspx");
                }
                else
                {
                    Response.Write("<script>alert('USUARIO INCORRECTO.')</script>");
                }
            }
        }
    }
}