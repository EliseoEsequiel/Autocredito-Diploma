using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class controladoraLogin
    {

        private static controladoraLogin _instancia;



        private controladoraLogin() { }

        // Modelo.ModeloDatosContainer1 oModelo;
       // Modelo.SingletonContexto oSingleton;

        /* private controladora_Articulos()
         {
             oSingleton = Modelo.SingletonContexto.obtener_instancia();
         }*/
        public static controladoraLogin obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new controladoraLogin();
            }
            return _instancia;
        }

        public static string EncriptarClave(string clave)
        {
            byte[] passBytes = Encoding.Unicode.GetBytes(clave);
            SHA1 sha = SHA1.Create();
            byte[] hash = sha.ComputeHash(passBytes);
            string hashString = Encoding.Unicode.GetString(hash);
            return hashString;
        }//Utiliza SHA1 para encriptar la clave de usuario


        public Modelo.Usuario VALIDAR_USUARIO(string usuario, string password)
        {
            Modelo.Usuario oUSUARIO = Modelo.SingletonContexto.obtener_instancia().Contexto.UsuarioSet.FirstOrDefault(U => U.Alias == usuario);
            if (oUSUARIO == null)
            {
                throw new Exception("No se ha encontrado el usuario ingresado");
               
            }
            if (oUSUARIO.Pass != EncriptarClave(password))
            {
                throw new Exception("La contraseña ingresada es incorrecta");
            }



           
            return oUSUARIO;
        }






    }
}
