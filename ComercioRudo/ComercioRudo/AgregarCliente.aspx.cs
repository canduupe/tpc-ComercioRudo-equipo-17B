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
        public bool confirmarEli { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.QueryString["IdCliente"] != null ? Request.QueryString["IdCliente"].ToString() : "";
                if(id != "" && !IsPostBack)
                {
                    ClientesNegocio neg = new ClientesNegocio();
                    Clientes sleccionado = (neg.Buscar(id))[0];

                    txtApellido.Text = sleccionado.Apellido;
                    txtNombre.Text = sleccionado.Nombre;
                    txtDni.Text = sleccionado.DNI;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

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

                if (Request.QueryString["IdCliente"] != null)
                {
                    nuevo.IdCliente = int.Parse(Request.QueryString["IdCliente"].ToString());
                    negocio.Modificar(nuevo);
                }
                else
                {
                negocio.Agregar(nuevo);

                }

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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmarEli = true;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesNegocio negocio = new ClientesNegocio();
                negocio.Eliminar(int.Parse(Request.QueryString["IdCliente"].ToString()));
                Response.Redirect("ListaCliente.aspx", false);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}