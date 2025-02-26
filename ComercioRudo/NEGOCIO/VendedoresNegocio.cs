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
                    

                    lista.Add(aux);

                }
            
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Agregar(Usuarios usuarios, Vendedor vendedor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("spAgregarVende");
                datos.setearParametro("@Nombre", vendedor.Nombre);
                datos.setearParametro("@Apellido",vendedor.Apellido);
                datos.setearParametro("@Usuario",usuarios.Usuario);
                datos.setearParametro("@Contraseña", usuarios.Contraseña);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<Vendedor> Buscar(string id = "")
        {
            AccesoDatos datos = new AccesoDatos();
            List<Vendedor> lista = new List<Vendedor>();
            try
            {
                string consulta = "select IdVendedor, Nombre, Apellido from Vendedor ";
                if (id != "")
                {
                    consulta += "where IdVendedor = " + id;
                }

                datos.setearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Vendedor aux = new Vendedor();
                    aux.IdVendedor = (int)datos.Lector["IdVendedor"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    

                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Modificar(Vendedor vendedor)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearProcedimiento("spModVende");
                datos.setearParametro("@id", vendedor.IdVendedor);
                datos.setearParametro("@Nombre", vendedor.Nombre);
                datos.setearParametro("@Apellido", vendedor.Apellido);

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
                datos.setearProcedimiento("spEliVende");
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
