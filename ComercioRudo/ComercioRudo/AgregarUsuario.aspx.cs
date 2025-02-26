using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using DOMINIO;
using Microsoft.Ajax.Utilities;

namespace ComercioRudo
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        public bool confirmarEli { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            confirmarEli = false;

            string id = Request.QueryString["IdUsuario"] != null ? Request.QueryString["IdUsuario"].ToString() : "";
            if (id != "" && !IsPostBack)
            {
                UsuariosNegocio negocio = new UsuariosNegocio();
                Usuarios seleccionado = (negocio.Buscar(id))[0];

                txtUsuario.Text = seleccionado.Usuario;
                txtContraseña.Text = seleccionado.Contraseña;
                txtTipoUsuario.Text = seleccionado.tipoUsuario.ToString();

            }


        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            UsuariosNegocio negocio = new UsuariosNegocio();
            try
            {
                usuarios.Usuario = txtUsuario.Text;
                usuarios.Contraseña = txtContraseña.Text;
                usuarios.tipoUsuario = int.Parse(txtTipoUsuario.Text);

                if (Request.QueryString["IdUsuario"] != null)
                {
                    usuarios.IdUsuario = int.Parse(Request.QueryString["IdUsuario"].ToString());
                    negocio.Modificar(usuarios);
                }
                else
                {
                    negocio.Agregar(usuarios);

                }

                Response.Redirect("ListaUsuarios.aspx", false);
            }

            catch (Exception ex)
            {
                Session.Add("error", ex);

                throw;
            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaUsuarios.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmarEli = true;

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                UsuariosNegocio negocio = new UsuariosNegocio();
                if (chkConfirm.Checked)
                {
                    negocio.elimnar(int.Parse(Request.QueryString["IdUsuario"].ToString()));
                    Response.Redirect("ListaUsuarios.aspx", false);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnInac_Click(object sender, EventArgs e)
        {
            try
            {
                UsuariosNegocio negocio = new UsuariosNegocio();
                negocio.ElimnarLog(int.Parse(Request.QueryString["IdUsuario"].ToString()));
                Response.Redirect("ListaUsuarios.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}