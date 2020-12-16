using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class controladora_Articulos
    {
        
        private static controladora_Articulos _instancia;

        private controladora_Articulos() { }

       // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

       /* private controladora_Articulos()
        {
            oSingleton = Modelo.SingletonContexto.obtener_instancia();
        }*/
        public static controladora_Articulos obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new controladora_Articulos();
            }
            return _instancia;
        }


        public List<Modelo.Articulo> Listar_Articulos()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.ToList();
        }

        public Modelo.Articulo OBTENER_ARTICULO(int codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.Find(codigo);
        }

        public void modificarArticulos(Modelo.Articulo oArticulos)
        {
            //oModelo = Modelo.SingletonContexto.obtener_instancia();
            /* Modelo.SingletonContexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
             oMODELO_SEGURIDAD.SaveChanges();*/
            //Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.(oArticulos);

            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }

        public void Eliminar(Modelo.Articulo art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.Remove(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
        public Modelo.Articulo Recuperar(Int32 Id)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.Find(Id);
        }

        public bool VALIDA_NOMBRE_Articulo(string nombre_Articulo)
        {
            Modelo.Articulo oArticulo = Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.FirstOrDefault(u => (u.Descripcion == nombre_Articulo));
            if (oArticulo == null)
                return false;
            else
                return true;
        }
        public void Agregar_Articulo(Modelo.Articulo art)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.Add(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public bool ValidarFk(Int32 id_Req)
        {
            Modelo.Requerimiento oArticulo = Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.FirstOrDefault(u => (u.Articulo.Id == id_Req));
            if (oArticulo == null)
                return false;
            else
                return true;
        }

        public System.Collections.IEnumerable OBTENER_Articulos()
        {
            var articulos = from Articulos in Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.ToList()
                            where (Articulos.Borrado == false)
                            select new { Id = Articulos.Id, Descripción = Articulos.Descripcion, Stock_Actual = Articulos.Stock, Stock_Minimo= Articulos.Stock_Min, Rubro = Articulos.Rubro.Descripcion };
            return articulos.ToList();
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
