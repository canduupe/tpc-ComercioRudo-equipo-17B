using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using Microsoft.Ajax.Utilities;
using NEGOCIO;


namespace ComercioRudo
{
    public partial class AgregarCategoria : System.Web.UI.Page
    {
        public bool confirmarEli { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            confirmarEli = false;
            try
            {
                string id = Request.QueryString["IdCategoria"] != null ? Request.QueryString["IdCategoria"].ToString() : "";
                if (id != "" && !IsPostBack)
                {
                    CategoriasNegocio neg = new CategoriasNegocio();
                    Categorias seleccionada = (neg.Buscar(id))[0]; 

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

                Categorias categorias = new Categorias();
                CategoriasNegocio negocio = new CategoriasNegocio();

                categorias.Nombre = txtNombre.Text;

                if (Request.QueryString["IdCategoria"] != null)
                {
                    categorias.IdCategoria = int.Parse(Request.QueryString["IdCategoria"].ToString());
                    negocio.Modificar(categorias);
                }
                else
                {
                    negocio.Agregar(categorias);

                }

                Response.Redirect("ListaCategorias.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaCategorias.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmarEli = true;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                CategoriasNegocio negocio = new CategoriasNegocio();
                negocio.Eliminar(int.Parse(Request.QueryString["IdCategoria"].ToString()));
                Response.Redirect("ListaCategorias.aspx", false);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}