﻿using System;
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
        public bool confirmarEli { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            confirmarEli = false;
            string id = Request.QueryString["IdProducto"] != null ? Request.QueryString["IdProducto"].ToString() : "";
            if (id != "" && !IsPostBack)
            {
                ProductosNegocio negocio = new ProductosNegocio();
                Productos seleccionado = (negocio.Buscar(id))[0];


                txtNombre.Text = seleccionado.Nombre;
                txtMarca.Text = seleccionado.IdMarca.ToString();
                txtCate.Text = seleccionado.IdCategoria.ToString();


            }
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

                if (Request.QueryString["IdProducto"] != null)
                {
                    productos.IdProducto = int.Parse(Request.QueryString["IdProducto"].ToString());
                    negocio.Modificar(productos);
                }
                else
                {
                    negocio.Agregar(productos);

                }

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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmarEli = true;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ProductosNegocio negocio = new ProductosNegocio();
                negocio.Eliminar(int.Parse(Request.QueryString["IdProducto"].ToString()));
                Response.Redirect("ListaProductos.aspx", false);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}