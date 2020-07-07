using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class Registro : Page
    {
        private string mensaje = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        private Cliente GetEntity() //RECUPERAR DATOS INPUTS
        {
            var objCliente = new Cliente();
            if (txtFijo.Text == string.Empty)
            {
                objCliente.Rut = Convert.ToInt32(txtRut.Text);
                objCliente.Telefono_Adicional = 0;
                objCliente.Nombre = txtNombre.Text;
                objCliente.Apellido = txtApellido.Text;
                objCliente.Telefono = Convert.ToInt32(txtCelular.Text);
                objCliente.Direccion = txtDireccion.Text;
                objCliente.Fecha_Nacimiento = Convert.ToDateTime(dpFechaNacimiento.Text);
                objCliente.Tipo_Cliente = true;
            }
            else
            {
                objCliente.Rut = Convert.ToInt32(txtRut.Text);
                objCliente.Nombre = txtNombre.Text;
                objCliente.Apellido = txtApellido.Text;
                objCliente.Telefono = Convert.ToInt32(txtCelular.Text);
                objCliente.Telefono_Adicional = Convert.ToInt32(txtFijo.Text);
                objCliente.Direccion = txtDireccion.Text;
                objCliente.Fecha_Nacimiento = Convert.ToDateTime(dpFechaNacimiento.Text);
                objCliente.Tipo_Cliente = true;
            }


            return objCliente;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Registro del cliente
            var objCliente = GetEntity();


            // enviar a la capa de logica de negocio
            var response = ClienteLN.getInstance().RegistrarCliente(objCliente);
            if (response)
            {
                panelMensajes.CssClass = "alert-success alert text-center";
                mensaje = "Registro exitoso, sera redirigido a reservas";
                lblMensaje.Text = mensaje;
                
                var oScript = new HtmlMeta();
                oScript.Attributes.Add("http-equiv", "REFRESH");
                oScript.Attributes.Add("content", "3; url='ReservarHora.aspx'");
                Page.Header.Controls.Add(oScript);
            }
            else
            {
                panelMensajes.CssClass = "alert-danger alert text-center";
                mensaje = "Registro fallido, revise los datos ingresados";
                lblMensaje.Text = mensaje;
            }
        }
    }
}