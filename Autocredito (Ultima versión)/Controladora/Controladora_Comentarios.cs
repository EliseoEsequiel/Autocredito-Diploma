using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class controladora_Comentarios
    {
        
        private static controladora_Comentarios _instancia;

        private controladora_Comentarios() { }

       // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

       /* private controladora_Articulos()
        {
            oSingleton = Modelo.SingletonContexto.obtener_instancia();
        }*/
        public static controladora_Comentarios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new controladora_Comentarios();
            }
            return _instancia;
        }


        public List<Modelo.Comentarios> Listar()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.ComentariosSet.ToList();
        }

        //public Modelo.Articulo OBTENER_ARTICULO(int codigo)
        //{
        //    return Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.Find(codigo);
        //}

       

        public void Eliminar(Modelo.Comentarios art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.ComentariosSet.Remove(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }

        public void Modificar(Modelo.Comentarios oArticulos)
        {
           
            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
        //public Modelo.Articulo Recuperar(Int32 Id)
        //{
        //    return Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.Find(Id);
        //}

        
        public void Agregar(Modelo.Comentarios art)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.ComentariosSet.Add(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }



      



      



    }
}
