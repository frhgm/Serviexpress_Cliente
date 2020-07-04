using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaAccesoDatos;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class ReservarHora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarEmpleados();
                Response.Write("<script>alert('Recuerde ingresar su rut al crear una reserva ya que lo llamaremos para confirmarla.')</script>");
            }
            
        }

        private void LlenarGridViewReservas()
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
            objReserva.Rut_Cliente = Convert.ToInt32(txtRut.Text);
            objReserva.Codigo_Servicio = Convert.ToInt32(ddlServicio.SelectedValue);
            objReserva.Rut_Empleado = Convert.ToInt32(ddlEmpleado.SelectedValue);//96715552
            objReserva.Id_Horario =  Convert.ToInt32(ddlBloque.SelectedValue);
            
            //define si esta vigente
            objReserva.Estado = true;
            
            return objReserva;
        }

        private void LlenarEmpleados()
        {
            List<Empleado> Lista = EmpleadoLN.getInstance().ListarEmpleados();

            ddlEmpleado.DataSource = Lista;
            ddlEmpleado.DataValueField = "Rut";
            ddlEmpleado.DataTextField = "Nombre";
            ddlEmpleado.DataBind();
            ddlEmpleado.Items.Insert(0, new ListItem(" Seleccione empleado"));
        }

        private void LlenarServicios()
        {
            List<Servicio> Lista = ServicioLN.getInstance().ListarServicios();

            int codigo = Convert.ToInt32(ddlEmpleado.SelectedValue);
            ddlServicio.DataSource = Lista;
            ddlServicio.DataValueField = "Codigo_Servicio";
            ddlServicio.DataTextField = "Nombre";
            ddlServicio.DataBind();
            ddlServicio.Items.Insert(0, new ListItem(" Seleccione servicio"));
        }
        

        private void LlenarBloque()
        {
            int rut = Convert.ToInt32(ddlEmpleado.SelectedValue);
            DateTime fecha = Convert.ToDateTime(dpFechaReserva.Text);
            
            List<BloqueHora> Lista = BloqueLN.getInstance().ListarBloques(rut, fecha);
                
            ddlBloque.DataSource = Lista;
            ddlBloque.DataValueField = "Id_Horario";
            ddlBloque.DataTextField = "Bloque";
            ddlBloque.DataBind();
            ddlBloque.Items.Insert(0, new ListItem(" Seleccione bloque"));
        }

        
        
        private void Reserva()
        {
            // Registro del cliente
            Reserva objReserva = GetEntity();
            
            
            // enviar a la capa de logica de negocio
            bool response = ReservaLN.getInstance().AgendarReserva(objReserva);
            if (response)
            {
                Response.Write("<script>alert('Reserva agendada correctamente.')</script>");

            }
            else
            {
                Response.Write("<script>alert('Revise los datos ingresados por favor, es posible que haya ingresado uno incorrecto')</script>");
            }
        }

        private void CancelarReserva()
        {
            SqlConnection conexion = Conexion.getInstance().ConexionBD();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<Reserva> Lista = null;
            int rut = Convert.ToInt32(txtRut.Text);
            int reserva = Convert.ToInt32(txtReserva.Text);

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
                Response.Write("<script>alert('Reserva Numero: " + reserva + " cancelada correctamente.')</script>");
                conexion.Close();
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