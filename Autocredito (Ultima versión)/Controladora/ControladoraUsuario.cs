using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraUsuario
    {
        private static ControladoraUsuario _instancia;

        private ControladoraUsuario() { }

        // Modelo.ModeloDatosContainer1 oModelo;
        //Modelo.SingletonContexto oSingleton;


        public static ControladoraUsuario obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraUsuario();
            }
            return _instancia;
        }


        public List<Modelo.Usuario> Listar_Usuarios()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.UsuarioSet.ToList();
        }

        public void AgregarUsuario(Modelo.Usuario oUsuario)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.UsuarioSet.Add(oUsuario);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar(Modelo.Usuario oUsuario)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.UsuarioSet.Remove(oUsuario);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }

        public bool VALIDA_NOMBRE_USUARIO(string nombre_usuario)
        {
            Modelo.Usuario oUSUARIO = Modelo.SingletonContexto.obtener_instancia().Contexto.UsuarioSet.FirstOrDefault(u => (u.Alias == nombre_usuario));
            if (oUSUARIO == null)
                return false;
            else
                return true;
        }


        public Modelo.Usuario OBTENER_USUARIO(int codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.UsuarioSet.Find(codigo);
        }

        public void modificarUsuario(Modelo.Usuario oUsuario)
        {
            //oModelo = Modelo.SingletonContexto.obtener_instancia();
            /* Modelo.SingletonContexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
             oMODELO_SEGURIDAD.SaveChanges();*/
            //Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.(oArticulos);

            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }


        public System.Collections.IEnumerable ObtenerUsuarios()
        {
            var usuarios = from usuario in Modelo.SingletonContexto.obtener_instancia().Contexto.UsuarioSet.ToList()

                           select new { Id =usuario.Id, Alias = usuario.Alias,Nombre = usuario.Nombre, Apellido= usuario.Apellido,  Permiso = usuario.Grupo.Descripcion };

            return usuarios.ToList();
        }
    }
}
