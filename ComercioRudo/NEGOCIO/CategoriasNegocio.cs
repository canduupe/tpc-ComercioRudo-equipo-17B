using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class CategoriasNegocio
    {
        public List<Categorias> listarConSP()
        {
            List<Categorias> lista = new List<Categorias>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spListarCategoria");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();

                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Activa = (int)datos.Lector["Activa"];

                    lista.Add(aux);
                        
                }

                return lista;   

            }
            catch (Exception ex)
            {

                throw ex;
            }





        }

        public void Agregar(Categorias categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spAgregarCate");
                datos.setearParametro("@Nombre", categoria.Nombre);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }


    }
}
