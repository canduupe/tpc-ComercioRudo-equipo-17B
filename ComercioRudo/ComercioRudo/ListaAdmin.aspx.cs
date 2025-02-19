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

        protected void btnAgregarAd_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMadmin.aspx", false);
        }

        protected void dgvListaAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvListaAdmin.SelectedDataKey.Value.ToString();
            Response.Redirect("ABMadmin.aspx?IdAdmin=" + id);
        }
    }
}