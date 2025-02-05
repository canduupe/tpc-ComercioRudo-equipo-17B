using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace ComercioRudo
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductosNegocio nef = new ProductosNegocio();
            dgvListaProduc.DataSource = nef.listarConSP();
            dgvListaProduc.DataBind();  


        }
    }
}