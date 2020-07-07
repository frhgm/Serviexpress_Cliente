using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class detalleServicios : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReservarHora.aspx");
        }
    }
}