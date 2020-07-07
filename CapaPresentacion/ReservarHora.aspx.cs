using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using CapaAccesoDatos;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class ReservarHora : Page
    {
        private string mensaje = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarEmpleados();
                panelMensajes.CssClass = "alert-info alert text-center";
                mensaje =
                    "Recuerde ingresar el rut con el que se registro, ya que lo llamaremos para confirmar su reserva";
                lblMensaje.Text = mensaje;
            }
        }

        private void LlenarGridViewReservas()
        {
            var rut = 0;

            if (txtRut.Text.Equals(string.Empty)) //VALIDAR QUE NO EXISTA
            {
                panelMensajes.CssClass = "alert-warning alert text-center";
                mensaje = "Debe ingresar su rut para buscar reservas";
                lblMensaje.Text = mensaje;
            }
            else
            {
                mensaje = "";
                rut = Convert.ToInt32(txtRut.Text);
                lblMensaje.Text = mensaje;
                var reservas = ReservaLN.getInstance().Listar(rut);
                grdHorariosAtencion.DataSource = reservas;
                grdHorariosAtencion.DataBind();
            }
        }


        private Reserva GetEntity() //RECUPERAR DATOS
        {
            Reserva objReserva = new Reserva();

            objReserva.Fecha = Convert.ToDateTime(dpFechaReserva.Text);
            objReserva.Patente = txtPatente.Text;
            objReserva.Marca = txtMarca.Text;
            objReserva.Modelo = txtModelo.Text;
            objReserva.Anno = Convert.ToInt32(txtAnno.Text);
            objReserva.Descripcion = txtDescripcion.Text;
            objReserva.Cliente.Rut = Convert.ToInt32(txtRut.Text);
            objReserva.Servicio.Codigo_Servicio = Convert.ToInt32(ddlServicio.SelectedValue);
            objReserva.Empleado.Rut = Convert.ToInt32(ddlEmpleado.SelectedValue); //96715552
            objReserva.BloqueHora.Id_Horario = Convert.ToInt32(ddlBloque.SelectedValue);

            //define si esta vigente
            objReserva.Estado = true;

            return objReserva;
        }

        /*
        public Reserva BuscarClienteReserva(int rut)
        {
            return ReservaLN.getInstance().BuscarClienteReserva(rut);
        }
*/
        private void LlenarEmpleados()
        {
            var Lista = EmpleadoLN.getInstance().ListarEmpleados();

            ddlEmpleado.DataSource = Lista;
            ddlEmpleado.DataValueField = "Rut";
            ddlEmpleado.DataTextField = "Nombre";
            ddlEmpleado.DataBind();
            ddlEmpleado.Items.Insert(0, new ListItem(" Seleccione empleado"));
        }

        private void LlenarServicios()
        {
            var Lista = ServicioLN.getInstance().ListarServicios();

            var codigo = Convert.ToInt32(ddlEmpleado.SelectedValue);
            ddlServicio.DataSource = Lista;
            ddlServicio.DataValueField = "Codigo_Servicio";
            ddlServicio.DataTextField = "Nombre";
            ddlServicio.DataBind();
            ddlServicio.Items.Insert(0, new ListItem(" Seleccione servicio"));
        }


        private void LlenarBloque()
        {
            var rut = Convert.ToInt32(ddlEmpleado.SelectedValue);
            var fecha = Convert.ToDateTime(dpFechaReserva.Text);

            var Lista = BloqueLN.getInstance().ListarBloques(rut, fecha);

            ddlBloque.DataSource = Lista;
            ddlBloque.DataValueField = "Id_Horario";
            ddlBloque.DataTextField = "Bloque";
            ddlBloque.DataBind();
            ddlBloque.Items.Insert(0, new ListItem(" Seleccione bloque"));
        }


        private void Reserva()
        {
            // Registro del cliente
            var objReserva = GetEntity();


            // enviar a la capa de logica de negocio
            var response = ReservaLN.getInstance().AgendarReserva(objReserva);
            if (response)
            {
                /*
                detallesReserva.InnerText = "Fecha: " + GetEntity().Fecha.Date + "\nRut empleado: " +
                                            GetEntity().Rut_Empleado + "Servicio: " + GetEntity().Codigo_Servicio +
                                            "Horario: " + GetEntity().Hora_Inicio;
                                            */
                panelMensajes.CssClass = "alert-success alert text-center";
                mensaje = "Reserva agendada correctamente";
                lblMensaje.Text = mensaje;
            }
            else
            {
                panelMensajes.CssClass = "alert-warning alert text-center";
                mensaje = "Revise los datos ingresados por favor, es posible que haya ingresado algo incorrectamente";
                lblMensaje.Text = mensaje;
            }
        }

        private void CancelarReserva()
        {
            var conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<Reserva> Lista = null;
            
            if (txtRut.Text.Equals(string.Empty) || txtReserva.Text.Equals(string.Empty))
            {
                panelMensajes.CssClass = "alert-danger alert text-center";
                mensaje = "Debe ingresar un numero de reserva y su rut para cancelar";
                lblMensaje.Text = mensaje;
            }
            else
            {
                var rut = Convert.ToInt32(txtRut.Text);
                var reserva = Convert.ToInt32(txtReserva.Text);

                try
                {
                    cmd = new SqlCommand("[spCancelarReserva]", conexion);
                    cmd.Parameters.AddWithValue("@prmRut", rut);
                    cmd.Parameters.AddWithValue("@prmReserva", reserva);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    panelMensajes.CssClass = "alert-success alert text-center";
                    mensaje = "Reserva cancelada correctamente";
                    lblMensaje.Text = mensaje;
                    conexion.Close();
                }
            }
        }

        private void ReservaExitosa()
        {
        }

        protected void btnListarReserva_Click(object sender, EventArgs e)
        {
            LlenarGridViewReservas();
        }


        protected void btnAgendarReserva_Click(object sender, EventArgs e)
        {
            Reserva();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarReserva();
        }

        //busca si se ha cambiado la seleccion de empleado y actualiza ddlServicios
        protected void SeleccionEmpleado(object sender, EventArgs e)
        {
            LlenarServicios();
        }

        //busca si se ha cambiado la seleccion de servicio y actualiza ddlBloque
        protected void SeleccionServicio(object sender, EventArgs e)
        {
            LlenarBloque();
        }
    }
}