using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraEstado
    {

        private static ControladoraEstado _instancia;

        private ControladoraEstado() { }

        // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

        /* private controladora_Articulos()
         {
             oSingleton = Modelo.SingletonContexto.obtener_instancia();
         }*/
        public static ControladoraEstado obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraEstado();
            }
            return _instancia;
        }

        public List<Modelo.Estados> Listar()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.EstadosSet.ToList();
        }


        public void Agregar(Modelo.Estados oGrupo)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.EstadosSet.Add(oGrupo);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
        public bool VALIDA_Descripcion(string nombre_usuario)
        {
            Modelo.Estados oUSUARIO = Modelo.SingletonContexto.obtener_instancia().Contexto.EstadosSet.FirstOrDefault(u => (u.Descripcion == nombre_usuario));
            if (oUSUARIO == null)
                return false;
            else
                return true;
        }

        public System.Collections.IEnumerable OBTENER_Estados()
        {
            var Estados = from Estado in Modelo.SingletonContexto.obtener_instancia().Contexto.EstadosSet.ToList()
                            where (Estado.Descripcion != "En curso")
                          where(Estado.Descripcion != "Cerrado")
                            select new { Id = Estado.Id, Descripción = Estado.Descripcion};
            return Estados.ToList();
        }

        public void Eliminar(Modelo.Estados art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.EstadosSet.Remove(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
        public void modificar(Modelo.Estados oGrupo)
        {
            //oModelo = Modelo.SingletonContexto.obtener_instancia();
            /* Modelo.SingletonContexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
             oMODELO_SEGURIDAD.SaveChanges();*/
            //Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.(oArticulos);

            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oGrupo).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
        public Modelo.Estados OBTENER_Estado(Int32 codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.EstadosSet.Find(codigo);
        }

       



    }
}
