using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using Microsoft.Ajax.Utilities;
using NEGOCIO;



namespace ComercioRudo
{
    public partial class ABMadmin : System.Web.UI.Page
    {

        public bool confirmarEli { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            confirmarEli = false;
            string id = Request.QueryString["IdAdmin"] != null ? Request.QueryString["IdAdmin"].ToString() : "";
            if(id != "" && !IsPostBack)
            {
                AdmistradoresNegocio negocio = new AdmistradoresNegocio();
                Administrador seleccionado = (negocio.Buscar(id))[0];

                txtNombre.Text = seleccionado.Nombre;
                txtApellido.Text = seleccionado.Apellido;
                txtUsuario.Enabled = false;
                txtContraseña.Enabled = false;

            }



        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(); 
            Administrador administrador = new Administrador();
            AdmistradoresNegocio negocio = new AdmistradoresNegocio();

            try
            {
                usuarios.Usuario = txtUsuario.Text;
                usuarios.Contraseña = txtContraseña.Text;
                administrador.Nombre = txtNombre.Text;
                administrador.Apellido = txtApellido.Text;

                if (Request.QueryString["IdAdmin"] != null)
                {
                    administrador.Id = int.Parse(Request.QueryString["IdAdmin"].ToString());
                    negocio.Modificar(administrador);
                }
                else
                {
                    negocio.Agregar(usuarios, administrador);
                }


                Response.Redirect("ListaAdmin.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaAdmin.aspx", false);
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                AdmistradoresNegocio negocio = new AdmistradoresNegocio();
                if (chkConfirm.Checked)
                {
                    negocio.Eliminar(int.Parse(Request.QueryString["IdAdmin"].ToString()));
                    Response.Redirect("ListaAdmin.aspx", false);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
           
            confirmarEli = true;

        }
    }
}