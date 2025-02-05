using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class VendedoresNegocio
    {
        public List<Vendedor> listarConSP()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Vendedor> lista = new List<Vendedor>();

            try
            {
                datos.setearProcedimiento("spListarVendedores");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Vendedor aux = new Vendedor();

                    aux.IdVendedor = (int)datos.Lector["IdVendedor"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.IdUsuario = (int)datos.Lector["IdUsuario"];

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
