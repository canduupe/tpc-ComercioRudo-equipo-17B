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
