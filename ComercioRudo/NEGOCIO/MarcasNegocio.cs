using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class MarcasNegocio
    {
        public List<Marcas> listarConSP()
        {
            List<Marcas> lista = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearProcedimiento("spListarMarcas");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();

                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
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
