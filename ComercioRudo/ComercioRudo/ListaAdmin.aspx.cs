using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace ComercioRudo
{
    public partial class ListaAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AdmistradoresNegocio negocio = new AdmistradoresNegocio();
            dgvListaAdmin.DataSource = negocio.listarConSP();
            dgvListaAdmin.DataBind();

        }
    }
}