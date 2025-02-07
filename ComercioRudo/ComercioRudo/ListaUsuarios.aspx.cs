using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace ComercioRudo
{
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          UsuariosNegocio usuariosNegocio = new UsuariosNegocio();
          dgvListaUsu.DataSource = usuariosNegocio.listarConSP();
          dgvListaUsu.DataBind(); 
        }

        protected void btnAgregarUsu_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarUsuario.aspx", false);    
        }
    }
}