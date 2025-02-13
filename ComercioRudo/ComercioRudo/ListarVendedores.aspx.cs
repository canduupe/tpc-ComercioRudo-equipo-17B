using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace ComercioRudo
{
    public partial class ListarVendedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VendedoresNegocio negocio = new VendedoresNegocio();
            dgvListarVend.DataSource = negocio.listarConSP();
            dgvListarVend.DataBind();   

        }

        protected void btnAgregarVend_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMvendedores.aspx", false);
        }

        protected void dgvListarVend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}