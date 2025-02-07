﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using DOMINIO;

namespace ComercioRudo
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
           Usuarios usuarios = new Usuarios();
           UsuariosNegocio negocio = new UsuariosNegocio();
            try
            {
                usuarios.Usuario = txtTipoUsuario.Text;
                usuarios.Contraseña = txtContraseña.Text;
                usuarios.tipoUsuario = int.Parse(txtTipoUsuario.Text);

                negocio.Agregar(usuarios);
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
    }
}