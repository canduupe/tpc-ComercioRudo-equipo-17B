using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class ClientesNegocio
    {
        public List<Clientes> listarConSP()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Clientes> lista = new List<Clientes>();

            try
            {
                datos.setearProcedimiento("spListarClientes");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Clientes aux = new Clientes();

                    aux.IdCliente = (int)datos.Lector["IdCliente"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apelldio = (string)datos.Lector["Apellido"];
                    aux.DNI = (string)datos.Lector["DNI"];

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
