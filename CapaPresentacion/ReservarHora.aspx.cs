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
        }
        
        private void LlenarGridViewHorariosAtencion()
        {
            if (txtRut.Text.Equals(string.Empty))
            {
                Response.Write("<script>alert('No ha ingresado un rut valido')</script>");
                return;
            }
            int rut = Convert.ToInt32(txtRut.Text);
            List<Reserva> reservas = ReservaLN.getInstance().Listar(rut);
            grdHorariosAtencion.DataSource = reservas;
            grdHorariosAtencion.DataBind();
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
        protected void btnReserva_Click(object sender, EventArgs e)
        {
            LlenarGridViewHorariosAtencion();
        }
    }
}