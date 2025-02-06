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
    public partial class AgregarMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Marcas marcas = new Marcas();
                MarcasNegocio negocio = new MarcasNegocio();

                marcas.Nombre = txtNombre.Text;

                negocio.Agregar(marcas);
                Response.Redirect("ListarMarcas.aspx", false);


            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }



        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
           Response.Redirect("ListarMarcas.aspx", false);
        }
    }
}