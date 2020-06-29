using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            if (!IsPostBack)
            {
                LlenarBloques();
                LlenarServicios();
                LlenarEmpleados();
                SqlCommand cmd;
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
        private Reserva GetEntity() //RECUPERAR DATOS INPUTS
        {
            Reserva objReserva = new Reserva();
            objReserva.Fecha = dpFechaReserva.SelectedDate;
            objReserva.Patente = txtPatente.Text;
            objReserva.Marca = txtMarca.Text;
            objReserva.Modelo = txtModelo.Text;
            objReserva.Anno = Convert.ToInt32(txtAnno.Text);
            objReserva.Descripcion = txtDescripcion.Text;
            objReserva.Rut_Cliente = Convert.ToInt32(txtRut.Text);
            objReserva.Codigo_Servicio = Convert.ToInt32(ddlServicio.SelectedValue);
            objReserva.Rut_Empleado = Convert.ToInt32(ddlEmpleado.SelectedValue);//96715552
            objReserva.Id_Horario =  Convert.ToInt32(ddlBloque.SelectedValue);
            
            objReserva.Estado = true;

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
            /*
            SqlCommand cmd;

            SqlConnection conexion = new SqlConnection();
            

            SqlDataAdapter da;
            
            conexion.ConnectionString = "Data Source=DESKTOP-AKH9PI2\\SQLEXPRESS;Initial Catalog=SERVIEXPRESS;Integrated Security=True";

            cmd =new SqlCommand ("SELECT hora_inicio,hora_final,id_horario FROM bloque_hora order by hora_inicio;", conexion);

            da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

            {

                ddlBloque.Items.Add(ds.Tables[0].Rows[i][0] + "--" + ds.Tables[0].Rows[i][1]);     

            }
            ddlBloque.DataBind();
            ddlBloque.Items.Insert(0, new ListItem(" Seleccione horario", "0"));
            */
            int rut = 96715552;
            List<BloqueHora> Lista = BloqueLN.getInstance().ListarBloques(rut);
            ddlBloque.DataSource = Lista;
            ddlBloque.DataValueField = "Id_Horario";
            ddlBloque.DataTextField = "Hora_Inicio";
            ddlBloque.DataBind();
            ddlBloque.Items.Insert(0, new ListItem(" Seleccione bloque", "0"));
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
        
        protected void btnListarReserva_Click(object sender, EventArgs e)
        {
            LlenarGridViewReservas();
            
        }

        protected void btnAgendarReserva_Click(object sender, EventArgs e)
        {
            Reserva();
        }
    }
}