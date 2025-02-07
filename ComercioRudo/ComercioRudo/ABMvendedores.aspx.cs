using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;


namespace ComercioRudo
{
    public partial class ABMvendedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            Vendedor vendedor = new Vendedor();
            VendedoresNegocio negocio = new VendedoresNegocio();
            try
            {

            usuarios.Usuario = txtUsuario.Text;
            usuarios.Contraseña = txtContraseña.Text;
            vendedor.Nombre = txtNombre.Text;
            vendedor.Apellido = txtApellido.Text;   
                
             negocio.Agregar(usuarios, vendedor);

            Response.Redirect("ListarVendedores.aspx", false);

            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarVendedores.aspx", false);
        }
    }
}