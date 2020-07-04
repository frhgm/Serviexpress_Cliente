using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }
        
        private Cliente GetEntity() //RECUPERAR DATOS INPUTS
        {
            Cliente objCliente = new Cliente();
            if (txtFijo.Text == String.Empty)
            {
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
            Cliente objCliente = GetEntity();
            
            
            // enviar a la capa de logica de negocio
            bool response = ClienteLN.getInstance().RegistrarCliente(objCliente);
            if (response)
            {
                Response.Write("<script>alert('REGISTRO CORRECTO.')</script>");
                Response.Redirect("ReservarHora.aspx");
            }
            else
            {
                Response.Write("<script>alert('REGISTRO INCORRECTO.')</script>");
            }
        }
        
    }
}