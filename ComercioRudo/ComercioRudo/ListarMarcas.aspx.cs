using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using DOMINIO;

namespace ComercioRudo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            dgvListaMarcas.DataSource = negocio.listarConSP();
            dgvListaMarcas.DataBind();
            
        }

        protected void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMarca.aspx", false);
        }

        protected void dgvListaMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdMarca = dgvListaMarcas.SelectedDataKey.Value.ToString();
            Response.Redirect("AgregarMarca.aspx?IdMarca=" + IdMarca);
        }
    }
}