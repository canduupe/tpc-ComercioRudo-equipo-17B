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
                datos.setearParametro("@Apellido", cliente.Apellido);
                datos.setearParametro("@DNI", cliente.DNI);

                datos.realizarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Clientes> Buscar(string id = "")
        {
            AccesoDatos datos = new AccesoDatos();
            List<Clientes> lista = new List<Clientes>();
            try
            {
                string consulta = "select IdCliente, Nombre, Apellido, DNI from Clientes ";
                if (id != "")
                {
                    consulta += "where IdCliente = " + id;
                }

                datos.setearConsulta(consulta);
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

        public void Modificar(Clientes cli)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearProcedimiento("spModCliente");
                datos.setearParametro("@id", cli.IdCliente);
                datos.setearParametro("@Nombre", cli.Nombre);
                datos.setearParametro("@Apellido", cli.Apellido);
                datos.setearParametro("@DNI", cli.DNI);

                datos.realizarAccion();



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
