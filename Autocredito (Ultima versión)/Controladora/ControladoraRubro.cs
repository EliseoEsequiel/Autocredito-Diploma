using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraRubro
    {
        private static ControladoraRubro _instancia;

        private ControladoraRubro() { }

        // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

        /* private controladora_Articulos()
         {
             oSingleton = Modelo.SingletonContexto.obtener_instancia();
         }*/
        public static ControladoraRubro obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraRubro();
            }
            return _instancia;
        }


        public List<Modelo.Rubro> Listar_Rubro()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.RubroSet.ToList();
        }

        public Modelo.Rubro OBTENER_Rubro(int codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.RubroSet.Find(codigo);
        }

        public void modificarRubro(Modelo.Rubro oRubro)
        {
            //oModelo = Modelo.SingletonContexto.obtener_instancia();
            /* Modelo.SingletonContexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
             oMODELO_SEGURIDAD.SaveChanges();*/
            //Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.(oArticulos);

            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oRubro).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }

        public void Eliminar(Modelo.Rubro art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.RubroSet.Remove(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
        public Modelo.Rubro Recuperar(Int32 Id)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.RubroSet.Find(Id);
        }

        public bool VALIDA_NOMBRE_Rubro(string nombre_Rubro)
        {
            Modelo.Rubro oRubro = Modelo.SingletonContexto.obtener_instancia().Contexto.RubroSet.FirstOrDefault(u => (u.Descripcion == nombre_Rubro));
            if (oRubro == null)
                return false;
            else
                return true;
        }
        public void Agregar_Rubro(Modelo.Rubro art)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.RubroSet.Add(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }



        public System.Collections.IEnumerable Filtrar(string Descripcion)
        {
            var rubro = from Rubro in Modelo.SingletonContexto.obtener_instancia().Contexto.RubroSet.ToList()
                          where Rubro.Descripcion.Contains(Descripcion)
                          select new { Id = Rubro.Id, Descripcion = Rubro.Descripcion };

            return rubro.ToList();
        }



    }
}

