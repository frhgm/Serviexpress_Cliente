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
    public partial class ReservarHora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarBloques();
            LlenarServicios();
            LlenarEmpleados();
        }

        private void LlenarGridViewHorariosAtencion()
        {
            if (txtRut.Text.Equals(string.Empty))//VALIDAR QUE NO EXISTA
            {
                Response.Write("<script>console.log('USUARIO INCORRECTO.')</script>");
                Response.Redirect("Registro.aspx");
            }
            int rut = Convert.ToInt32(txtRut.Text);
            List<Reserva> reservas = ReservaLN.getInstance().Listar(rut);
            grdHorariosAtencion.DataSource = reservas;
            grdHorariosAtencion.DataBind();
            /* PRIMERO SE SELECCIONA HORA(bloque), LUEGO SELECCIONA EMPLEADO DISPONIBLE */
            /* O */
            /* PRIMERO SELECCIONAR EMPLEADO */
            /* EMPLEADO YA EXISTE PARA SELECCIONAR */
            /* SI RUT NO EXISTE, DESPLEGAR REGISTRO */
            /* VALOR TIPO_CLIENTE POR DEFECTO COMO 1 */ /* COMBO BOX */
        }
        private Reserva GetEntity() //RECUPERAR DATOS INPUTS
        {
            Reserva objReserva = new Reserva();
            objReserva.Fecha = dpFechaReserva.SelectedDate;
            objReserva.Patente = txtPatente.Text;
            objReserva.Marca = txtMarca.Text;
            objReserva.Modelo = txtModelo.Text;
            objReserva.Anno = Convert.ToInt32(txtAnno.Text);
            objReserva.Descripcion = txtDescripcion.Text;
            objReserva.Rut_Cliente = int.Parse(txtRut.Text);
            objReserva.Codigo_Servicio = int.Parse(ddlServicio.SelectedValue);
            objReserva.Rut_Empleado = Convert.ToInt32(ddlEmpleado.SelectedValue);
            objReserva.Bloque_Hora = Convert.ToInt32(ddlBloque.SelectedValue);
            objReserva.Estado = true;
            /* DateTime tempDate = Convert.ToDateTime("1/1/2010 12:10:15 PM", culture); */
            //objPaciente.Sexo = (ddlSexo.SelectedValue == "Femenino") ? 'F' : 'M'; // Masculino , Femenino

            return objReserva;
        }

        private void LlenarServicios()
        {
            List<Servicio> Lista = ServicioLN.getInstance().ListarServicios();

            ddlServicio.DataSource = Lista;
            ddlServicio.DataValueField = "Codigo_Servicio";
            ddlServicio.DataTextField = "Nombre";
            ddlServicio.DataBind();
            ddlServicio.Items.Insert(0, new ListItem(" Seleccione servicio", "0"));
        }
        
        
        private void LlenarBloques()
        {
            //int rut = 96715552;
            int rut = Convert.ToInt32(ddlEmpleado.SelectedItem.ToString());
            List<BloqueHora> Lista = BloqueLN.getInstance().ListarBloques(rut);
            ddlBloque.DataSource = Lista;
            ddlBloque.DataValueField = "Id_Horario";
            ddlBloque.DataTextField = "Hora_Inicio";
            ddlBloque.DataBind();
            ddlBloque.Items.Insert(0, new ListItem(" Seleccione horario", "0"));
        }

        private void LlenarEmpleados()
        {
            List<Empleado> Lista = EmpleadoLN.getInstance().ListarEmpleados();

            ddlEmpleado.DataSource = Lista;
            ddlEmpleado.DataValueField = "Rut";
            ddlEmpleado.DataTextField = "Nombre";
            ddlEmpleado.DataBind();
            ddlEmpleado.Items.Insert(0, new ListItem(" Seleccione empleado", "0"));
        }

        private void Reserva()
        {
            // Registro del cliente
            Reserva objReserva = GetEntity();
            
            
            // enviar a la capa de logica de negocio
            bool response = ReservaLN.getInstance().AgendarReserva(objReserva);
            if (response)
            {
                Response.Write("<script>alert('REGISTRO CORRECTO.')</script>");

            }
            else
            {
                Response.Write("<script>alert('REGISTRO INCORRECTO.')</script>");
            }
        }
        
/*
        private void LlenarBloque()
        {
            if (txtRut.Text.Equals(string.Empty))
            {
                Response.Write("<script>alert('No ha ingresado un rut valido')</script>");
                return;
            }
            int rut = Convert.ToInt32(txtRut.Text);
            List<BloqueHora> Bloques = BloqueLN.getInstance().Listar(rut);
            grdBloque.DataSource = Bloques;
            
            grdBloque.DataBind();
        }
*/
        protected void btnListarReserva_Click(object sender, EventArgs e)
        {
            LlenarGridViewHorariosAtencion();
            
        }

        protected void btnAgendarReserva_Click(object sender, EventArgs e)
        {
            Reserva();
        }
    }
}