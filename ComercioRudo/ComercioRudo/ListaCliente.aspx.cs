using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace ComercioRudo
{
    public partial class ListaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientesNegocio negocio = new ClientesNegocio();
            dgvListaCli.DataSource = negocio.listarConSP();
            dgvListaCli.DataBind(); 

        }

        protected void btnAgregarCli_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCliente.aspx", false);
        }

        protected void dgvListaCli_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
        }
    }
}