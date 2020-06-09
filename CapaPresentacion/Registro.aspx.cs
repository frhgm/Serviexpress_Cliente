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

        }
        
        private Cliente GetEntity() //RECUPERAR DATOS INPUTS
        {
            Cliente objCliente = new Cliente();
            objCliente.Rut = Convert.ToInt32(txtRut.Text);
            objCliente.Nombre = txtNombre.Text;
            objCliente.Apellido = txtApellido.Text;
            objCliente.Telefono = Convert.ToInt32(txtCelular.Text);
            /* DateTime tempDate = Convert.ToDateTime("1/1/2010 12:10:15 PM", culture); */
            
            

            if (txtFijo.Text == String.Empty)
            {
                objCliente.Telefono_Adicional = 0;
                objCliente.Direccion = txtDireccion.Text;
                objCliente.Fecha_Nacimiento = dpFechaNacimiento.SelectedDate;
                objCliente.Tipo_Cliente = Convert.ToBoolean(txtTipoCliente.Text);
            }
            else
            {
                objCliente.Telefono_Adicional = Convert.ToInt32(txtFijo.Text);
                objCliente.Direccion = txtDireccion.Text;
                //objCliente.Fecha_Nacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                objCliente.Tipo_Cliente = Convert.ToBoolean(txtTipoCliente.Text);
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

            }
            else
            {
                Response.Write("<script>alert('REGISTRO INCORRECTO.')</script>");
            }
        }
        
    }
}