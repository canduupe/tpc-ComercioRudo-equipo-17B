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

        public void Agregar(Marcas marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spAgregarMarca");
                datos.setearParametro("@Nombre", marca.Nombre);

                datos.realizarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public List<Marcas> Buscar(string id = "")
        {
            AccesoDatos datos = new AccesoDatos();
            List<Marcas> lista = new List<Marcas>();
            try
            {
                string consulta = "select IdMarca, Nombre, Activa from Marcas ";
                if(id != "")
                {
                    consulta += "where IdMarca = " + id;
                }

                datos.setearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                   lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex; 
            }


        }

        public void Modificar(Marcas marcas)
        {
            AccesoDatos datos = new AccesoDatos();
            
            
            try
            {
                datos.setearProcedimiento("spModMarcaSP");
                datos.setearParametro("@id", marcas.IdMarca);
                datos.setearParametro("@Nombre", marcas.Nombre);

                datos.realizarAccion();



            }
            catch (Exception ex)
            {

                throw ex ;
            }


        }
    }
}
