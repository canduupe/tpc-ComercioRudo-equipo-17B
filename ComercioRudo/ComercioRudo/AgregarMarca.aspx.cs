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
        public bool confirmarEli { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            confirmarEli = false;

            try
            {
                string id = Request.QueryString["IdMarca"] != null ? Request.QueryString["IdMarca"].ToString() : "";
                if (id != "" && !IsPostBack)
                {
                    MarcasNegocio neg = new MarcasNegocio();
                    //List<Marcas> lista = neg.Buscar(id);
                    //Marcas seleccionada = lista[0];
                    Marcas seleccionada = (neg.Buscar(id))[0];

                    txtNombre.Text = seleccionada.Nombre;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Marcas marcas = new Marcas();
                MarcasNegocio negocio = new MarcasNegocio();

                marcas.Nombre = txtNombre.Text;

                if (Request.QueryString["IdMarca"] != null)
                {
                    marcas.IdMarca = int.Parse(Request.QueryString["IdMarca"].ToString());
                    negocio.Modificar(marcas);
                }
                else
                {
                    negocio.Agregar(marcas);

                }

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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmarEli = true;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                MarcasNegocio negocio = new MarcasNegocio();
                negocio.Eliminar(int.Parse(Request.QueryString["IdMarca"].ToString()));
                Response.Redirect("ListarMarcas.aspx", false);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}