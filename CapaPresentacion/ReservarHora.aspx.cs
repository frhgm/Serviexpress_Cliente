using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;
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
        private string rut;
        private string verificador;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarServicios();
                panelMensajes.CssClass = "alert-info alert text-center";
                mensaje =
                    "Recuerde ingresar el rut con el que se registro, ya que lo llamaremos para confirmar su reserva";
                lblMensaje.Text = mensaje;
            }
        }
        /*
        private bool BuscarCliente()
        {
            int rut = Convert.ToInt32(txtRut.Text);   
            string connectionstring = "Data Source=(local);Initial Catalog=SERVIEXPRESS;Integrated Security=True";
            var encontrado = false;
            using(SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT rut_cliente from ficha_cliente WHERE rut_cliente = " + rut + ";", conn);
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    encontrado = true;
                }
                conn.Close();
            }

            return encontrado;
        }
        
    */
       
       public string Rut_Recortado()
       {
           rut = txtRut.Text;
           verificador = rut.Remove(0,rut.Length - 1);
           rut = rut.Remove(rut.Length - 1);
           string resultado = "";
           if (verificador.Equals("k"))
           {
               resultado =  rut + 0;
           }
           else
           {
               resultado = rut  + verificador;
           }

           return resultado;
       }
       
       string cs = ConfigurationManager.ConnectionStrings["SERVIEXPRESSConnectionString"].ConnectionString;

       //SqlConnection conexion = Conexion.getInstance().ConexionBD();
       
       //Method for DataBinding  
       protected void ListarReservas()
       {
           int rut = 0;
           if (txtRut.Text.Equals(string.Empty)) //REVISAR QUE HAYA INGRESADO RUT
           {
               panelMensajes.CssClass = "alert-warning alert text-center";
               mensaje = "Debe ingresar su rut para buscar reservas";
               lblMensaje.Text = mensaje;
           }
           else
           {
               panelMensajes.CssClass = "";
               rut = Convert.ToInt32(txtRut.Text);
               lblMensaje.Text = "";
               
               DataTable dt = new DataTable();  
               SqlConnection con = new SqlConnection(cs);
               rut = Convert.ToInt32(Rut_Recortado());
               string select = "SELECT r.n_reserva, r.fecha, b.hora_inicio, b.hora_final FROM reserva r join bloque_hora b on r.bloque_hora_id_horario = b.id_horario where r.ficha_cliente_rut_cliente = " + rut + " AND r.estado_reserva = 1;";
               SqlDataAdapter adapt = new SqlDataAdapter(select,con);  
               con.Open();  
               adapt.Fill(dt);  
               con.Close();  
               if(dt.Rows.Count>0)  
               {  
                   gridReservas.DataSource = dt;  
                   gridReservas.DataBind();  
               } 
               
           }
           
       }   
       /*
        private void LlenarGridViewReservas()
        {
            var rut = 0;

            if (txtRut.Text.Equals(string.Empty)) //REVISAR QUE HAYA INGRESADO RUT
            {
                panelMensajes.CssClass = "alert-warning alert text-center";
                mensaje = "Debe ingresar su rut para buscar reservas";
                lblMensaje.Text = mensaje;
            }
            else
            {
                panelMensajes.CssClass = "";
                rut = Convert.ToInt32(txtRut.Text);
                lblMensaje.Text = mensaje;
                var reservas = ReservaLN.getInstance().Listar(rut);
                gridReservas.DataSource = reservas;
                gridReservas.DataBind();
            }
        }
*/

        private Reserva RecuperarDatos() //RECUPERAR DATOS
        {
            Reserva objReserva = new Reserva();

            objReserva.Fecha = Convert.ToDateTime(dpFechaReserva.Text);
            objReserva.Patente = txtPatente.Text;
            objReserva.Marca = txtMarca.Text;
            objReserva.Modelo = txtModelo.Text;
            objReserva.Anno = Convert.ToInt32(txtAnno.Text);
            objReserva.Descripcion = txtDescripcion.Text;
            objReserva.Cliente.Rut = Convert.ToInt32(Rut_Recortado());
            objReserva.Servicio.Codigo_Servicio = Convert.ToInt32(ddlServicio.SelectedValue);
            objReserva.Empleado.Rut = Convert.ToInt32(ddlEmpleado.SelectedValue);
            objReserva.BloqueHora.Id_Horario = Convert.ToInt32(ddlBloque.SelectedValue);

            //define si esta vigente
            objReserva.Estado = true;

            return objReserva;
        }
        /*
        [WebMethod]
        public bool BuscarCliente(int rut)
        {
            return ClienteLN.getInstance().BuscarCliente(rut);
        }
        */
        private void LlenarEmpleados()
        {
            var Lista = EmpleadoLN.getInstance().ListarEmpleados();

            ddlEmpleado.DataSource = Lista;
            ddlEmpleado.DataValueField = "Rut";
            ddlEmpleado.DataTextField = "Nombre";
            ddlEmpleado.DataBind();
            ddlEmpleado.Items.Insert(0, new ListItem(" Luego un empleado", "0"));
        }

        private void LlenarServicios()
        {
            var Lista = ServicioLN.getInstance().ListarServicios();

            ddlServicio.DataSource = Lista;
            ddlServicio.DataValueField = "Codigo_Servicio";
            ddlServicio.DataTextField = "Nombre";
            ddlServicio.DataBind();
            ddlServicio.Items.Insert(0, new ListItem(" Primero seleccione un servicio"));
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
            ddlBloque.Items.Insert(0, new ListItem(" Y por ultimo un bloque horario"));
        }


        private void Reserva()
        {
            // Registro del cliente
            var objReserva = RecuperarDatos();


            // enviar a la capa de logica de negocio
            var response = ReservaLN.getInstance().AgendarReserva(objReserva);
            if (response)
            {
                /*
                detallesReserva.InnerText = "Fecha: " + GetEntity().Fecha.Date + "\nRut empleado: " +
                                            GetEntity().Rut_Empleado + "Servicio: " + GetEntity().Codigo_Servicio +
                                            "Horario: " + GetEntity().Hora_Inicio;
                                            */
                panelMensajes.CssClass = "";
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
                    panelMensajes.CssClass = "";
                    panelMensajes.CssClass = "alert-success alert text-center";
                    mensaje = "Reserva " + reserva + " cancelada correctamente";
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
            ListarReservas();
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
        protected void SeleccionServicio(object sender, EventArgs e)
        {
            LlenarEmpleados();
        }

        //busca si se ha cambiado la seleccion de servicio y actualiza ddlBloque
        protected void SeleccionEmpleado(object sender, EventArgs e)
        {
            LlenarBloque();
        }

        
    }
}