using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;



namespace ComercioRudo
{
    public partial class ABMadmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

                negocio.Agregar(usuarios, administrador);
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
    }
}