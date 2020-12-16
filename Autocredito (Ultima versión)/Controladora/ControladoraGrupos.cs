using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraGrupos
    {
        private static ControladoraGrupos _instancia;

        private ControladoraGrupos() { }

        // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

        /* private controladora_Articulos()
         {
             oSingleton = Modelo.SingletonContexto.obtener_instancia();
         }*/
        public static ControladoraGrupos obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraGrupos();
            }
            return _instancia;
        }

        public Modelo.Grupo OBTENER_GRUPO(int codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.GrupoSet.Find(codigo);
        }

        public List<Modelo.Grupo> Listar_Grupos()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.GrupoSet.ToList();
        }


        public void AgregarGrupo(Modelo.Grupo oGrupo)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.GrupoSet.Add(oGrupo);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
        public bool VALIDA_NOMBRE_Grupo(string nombre_usuario)
        {
            Modelo.Grupo oUSUARIO = Modelo.SingletonContexto.obtener_instancia().Contexto.GrupoSet.FirstOrDefault(u => (u.Descripcion == nombre_usuario));
            if (oUSUARIO == null)
                return false;
            else
                return true;
        }
        public void modificarGrupos(Modelo.Grupo oGrupo)
        {
            //oModelo = Modelo.SingletonContexto.obtener_instancia();
            /* Modelo.SingletonContexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
             oMODELO_SEGURIDAD.SaveChanges();*/
            //Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.(oArticulos);

            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oGrupo).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }




        /*public System.Collections.IEnumerable OBTENER_ARTICULOS() //Obtiene por nombre
        {
            var Articulo = from Articulos in oModelo.Articulo.ToList()
                         select Articulos;

            return Articulo.ToList();
        }*/



        /*public System.Collections.IEnumerable OBTENER_ARTICULOS()
        {
            var articulos = from Articulo in oModelo.ArticuloSet.ToList()
                            select Articulo;
            return articulos.ToList();
        }*/

        /*public System.Collections.IEnumerable LISTAR_PERITOS()
        {

            var peritos = from perito in oEmpresa.PERITOS.Include("Denuncias").ToList()
                          select new { CODIGO = perito.CODIGO_PERITO, NOMBRE = perito.nombre_perito, TELEFONO = perito.telefono_perito, ESPECIALIDAD = perito.especialidad };
            return peritos.ToList();
        }*/



    }
}
