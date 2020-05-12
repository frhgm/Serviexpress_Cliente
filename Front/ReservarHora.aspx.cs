using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class ReservarHora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReservaExitosa.aspx");
        }
    }
}