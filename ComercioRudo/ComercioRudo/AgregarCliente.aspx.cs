using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;

namespace ComercioRudo
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes nuevo = new Clientes(); 
                ClientesNegocio negocio = new ClientesNegocio();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.DNI = txtDni.Text;

                negocio.Agregar(nuevo);
                Response.Redirect("ListaCliente.aspx", false);  
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);

                throw;
            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaCliente.aspx", false );
        }
    }
}