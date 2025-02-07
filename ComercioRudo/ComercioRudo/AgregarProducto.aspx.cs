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
    public partial class AgregarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Productos productos = new Productos();
                ProductosNegocio negocio = new ProductosNegocio();

                productos.Nombre = txtNombre.Text;
                productos.IdCategoria = int.Parse(txtCate.Text);
                productos.IdMarca = int.Parse(txtMarca.Text);

                negocio.Agregar(productos);
                Response.Redirect("ListaProductos.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaProductos.aspx", false);
        }
    }
}