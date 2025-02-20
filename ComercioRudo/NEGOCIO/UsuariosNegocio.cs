using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class UsuariosNegocio
    {

        public List<Usuarios> listarConSP()
        {
            List<Usuarios> lista = new List<Usuarios>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spListarUsuarios");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Usuarios aux = new Usuarios();

                    aux.IdUsuario = (int)datos.Lector["Id"];
                    aux.Usuario = (string)datos.Lector["Usuario"];
                    aux.Contraseña = (string)datos.Lector["Contraseña"];
                    aux.tipoUsuario = (int)datos.Lector["TipoUsuario"];

                    lista.Add(aux); 

                }

                return lista;   
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Agregar(Usuarios usu)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spAgregarUsu");
                datos.setearParametro("@Usuario", usu.Usuario);
                datos.setearParametro("@Contraseña", usu.Contraseña);
                datos.setearParametro("@TipoUsuario", usu.tipoUsuario);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Usuarios> Buscar(string id = "") 
        {
            AccesoDatos datos = new AccesoDatos();
            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                string consulta = "select Id, Usuario, Contraseña ,TipoUsuario from Usuarios ";
                if(id != "")
                {
                    consulta += "where Id = " + id;
                }
                datos.setearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Usuarios usu = new Usuarios();
                    usu.IdUsuario = (int)datos.Lector["Id"];
                    usu.Usuario = (string)datos.Lector["Usuario"];
                    usu.Contraseña = (string)datos.Lector["Contraseña"];
                    usu.tipoUsuario = (int)datos.Lector["TipoUsuario"];

                    lista.Add(usu);
                    

                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Modificar(Usuarios usuarios)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("spModUsu");
                datos.setearParametro("@IdUsu", usuarios.IdUsuario);
                datos.setearParametro("@Usuario", usuarios.Usuario);
                datos.setearParametro("@Contraseña", usuarios.Contraseña);
                datos.setearParametro("@tipoUsu", usuarios.tipoUsuario);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
