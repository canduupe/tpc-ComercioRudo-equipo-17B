﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class ProductosNegocio
    {

        public List<Productos> listarConSP()
        {
            List<Productos> lista = new List<Productos>();  
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spListarProductos");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Productos aux = new Productos();

                    aux.IdProducto = (int)datos.Lector["IdProducto"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Activo = (int)datos.Lector["Activa"];

                    lista.Add(aux); 

                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void Agregar(Productos productos)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spAgregarProductos");
                datos.setearParametro("@Nombre", productos.Nombre);
                datos.setearParametro("@IdMarca", productos.IdMarca);
                datos.setearParametro("@IdCategoria", productos.IdCategoria);

                datos.realizarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<Productos> Buscar(string id = "")
        {
            AccesoDatos datos = new AccesoDatos();
            List<Productos> lista = new List<Productos>();
            try
            {
                string consulta = " select IdProducto, Nombre, IdCategoria, IdMarca, Activa from Productos ";
                if (id != "")
                {
                    consulta += "where IdProducto = " + id;
                }

                datos.setearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Productos aux = new Productos();
                    aux.IdProducto = (int)datos.Lector["IdProducto"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];


                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void Modificar(Productos productos)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearProcedimiento("spModProducto");
                datos.setearParametro("@IdProducto", productos.IdProducto);
                datos.setearParametro("@Nombre", productos.Nombre);
                datos.setearParametro("@IdCategoria", productos.IdCategoria);
                datos.setearParametro("@IdMarca", productos.IdMarca);


                datos.realizarAccion();



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearProcedimiento("spEliProduc");
                datos.setearParametro("@Id", id);
                datos.realizarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
