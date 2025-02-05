using System;
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


    }
}
