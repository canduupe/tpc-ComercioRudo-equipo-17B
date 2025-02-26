using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class AdmistradoresNegocio
    {
        public List<Administrador> listarConSP()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Administrador> lista = new List<Administrador>();

            try
            {
                datos.setearProcedimiento("spListarAdministradores");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Administrador aux = new Administrador();

                    aux.Id = (int)datos.Lector["IdAdministrador"];
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

        public void Agregar(Usuarios usu, Administrador admin)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("spAgregarAdmin");
                datos.setearParametro("@Usuario", usu.Usuario);
                datos.setearParametro("@Contraseña", usu.Contraseña);
                datos.setearParametro("@Nombre", admin.Nombre);
                datos.setearParametro("@Apellido", admin.Apellido);

                datos.realizarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Administrador> Buscar(string id)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Administrador> lista = new List<Administrador>();
            try
            {
                string consulta = "select IdAdministrador, Nombre, Apellido from Administrador ";
                if (id != "")
                {
                    consulta += "where IdAdministrador = " + id;
                }

                datos.setearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Administrador aux = new Administrador();
                    aux.Id = (int)datos.Lector["IdAdministrador"];
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

        public void Modificar(Administrador admin)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearProcedimiento("spModAdmin");
                datos.setearParametro("@idAdmin", admin.Id);
                datos.setearParametro("@Nombre", admin.Nombre);
                datos.setearParametro("@Apellido", admin.Apellido);

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
                datos.setearProcedimiento("spEliAdmin");
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
