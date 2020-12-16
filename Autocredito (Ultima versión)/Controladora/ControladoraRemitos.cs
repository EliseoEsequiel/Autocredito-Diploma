using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraRemitos
    {
        private static ControladoraRemitos _instancia;

        private ControladoraRemitos() { }

        // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

        /* private controladora_Articulos()
         {
             oSingleton = Modelo.SingletonContexto.obtener_instancia();
         }*/
        public static ControladoraRemitos obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraRemitos();
            }
            return _instancia;
        }


        public System.Collections.IEnumerable Listar()
        {
            var Pedidos = from Remitos in Modelo.SingletonContexto.obtener_instancia().Contexto.Remitos.ToList()

                          select new { Id = Remitos.Id, Fecha = Remitos.Fecha, Proveedor = Remitos.Orden_Compra.Proveedor.Razon_Social };

            return Pedidos.ToList();
        }
        /*public System.Collections.IEnumerable Filtrar(string Descripcion)
        {
            var Pedidos = from Ordenes in Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.ToList()
                          where Ordenes.Proveedor.Razon_Social.Contains(Descripcion)
                          select new { Id = Ordenes.Id, Fecha = Ordenes.Ultima_Modificacion, Proveedor = Ordenes.Proveedor.Razon_Social, Rubro = Ordenes.Proveedor.Rubro.Descripcion, Estado = Ordenes.Estados.Descripcion };

            return Pedidos.ToList();
        }*/

        public Modelo.Remitos OBTENER(int codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.Remitos.Find(codigo);
        }
        public bool ValidarFk(Int32 id_Req)
        {
            Modelo.DetalleCompra detalle = Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.FirstOrDefault(u => (u.Orden_Compra.Id == id_Req));
            if (detalle == null)
                return false;
            else
                return true;
        }

        public void modificar(Modelo.Orden_Compra oArticulos)
        {
            //oModelo = Modelo.SingletonContexto.obtener_instancia();
            /* Modelo.SingletonContexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
             oMODELO_SEGURIDAD.SaveChanges();*/
            //Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.(oArticulos);

            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }

        public void Eliminar(Modelo.Remitos art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.Remitos.Remove(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
        public Modelo.Orden_Compra Recuperar(Int32 Id)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.Find(Id);
        }

        public bool VALIDA_NOMBRE_Proveedor(string nombre_Articulo)
        {
            Modelo.Orden_Compra oArticulo = Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.FirstOrDefault(u => (u.Proveedor.Razon_Social == nombre_Articulo));
            if (oArticulo == null)
                return false;
            else
                return true;
        }
        public void Agregar(Modelo.Remitos art)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.Remitos.Add(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }





    }
}

