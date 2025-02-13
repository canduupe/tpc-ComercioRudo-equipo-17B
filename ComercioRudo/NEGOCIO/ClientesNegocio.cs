using DOMINIO;
using System;
using System.Collections.Generic;
using System.Data;
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
                    aux.Apellido = (string)datos.Lector["Apellido"];
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

        public void Agregar(Clientes cliente)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spAgregarCli");
                datos.setearParametro("@Nombre", cliente.Nombre);
                datos.setearParametro("@Apellido", cliente.Apelldio);
                datos.setearParametro("@DNI", cliente.DNI);

                datos.realizarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
