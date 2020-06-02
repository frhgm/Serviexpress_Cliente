using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

namespace Front
{
    public partial class ReservarHora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGridViewHorariosAtencion();
            LlenarBloque();
        }
        
        private void LlenarGridViewHorariosAtencion()
        {
            List<Reserva> Reservas = ReservaLN.getInstance().Listar();
            grdHorariosAtencion.DataSource = Reservas;
            
            grdHorariosAtencion.DataBind();
        }

        private void LlenarBloque()
        {
            List<BloqueHora> Bloques = BloqueLN.getInstance().Listar();
            grdBloque.DataSource = Bloques;
            
            grdBloque.DataBind();
        }

        protected void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReservaExitosa.aspx");
        }
    }
}