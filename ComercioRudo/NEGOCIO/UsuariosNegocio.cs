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

                    aux.Id = (int)datos.Lector["Id"];
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



    }
}
