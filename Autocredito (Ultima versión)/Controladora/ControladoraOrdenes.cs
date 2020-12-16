using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraOrdenes
    {

        private static ControladoraOrdenes _instancia;

        private ControladoraOrdenes() { }

        // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

        /* private controladora_Articulos()
         {
             oSingleton = Modelo.SingletonContexto.obtener_instancia();
         }*/
        public static ControladoraOrdenes obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraOrdenes();
            }
            return _instancia;
        }


        public System.Collections.IEnumerable Listar()
        {
            var Pedidos = from Ordenes in Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.ToList()
                         
                          select new { Id = Ordenes.Id, Fecha = Ordenes.Ultima_Modificacion, Proveedor = Ordenes.Proveedor.Razon_Social, Rubro = Ordenes.Proveedor.Rubro.Descripcion, Estado = Ordenes.Estados.Descripcion };

            return Pedidos.ToList();
        }

        public Modelo.Orden_Compra Ultimo(string Art)
        {
            var Pedidos = from orden in Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.ToList()
                          where orden.Proveedor.Razon_Social.Contains(Art)

                          select orden;

            return Pedidos.LastOrDefault();
            // return Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.Where(o => o.Proveedor.Razon_Social == Proveedor).FirstOrDefault();
        }
        public System.Collections.IEnumerable Filtrar(string Descripcion)
        {
            var Pedidos = from Ordenes in Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.ToList()
                          where Ordenes.Proveedor.Razon_Social.Contains(Descripcion)
                          select new { Id = Ordenes.Id, Fecha = Ordenes.Ultima_Modificacion, Proveedor = Ordenes.Proveedor.Razon_Social, Rubro = Ordenes.Proveedor.Rubro.Descripcion,Estado = Ordenes.Estados.Descripcion };

            return Pedidos.ToList();
        }

        public Modelo.Orden_Compra OBTENER(int codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.Find(codigo);
        }
        public Modelo.Orden_Compra  Asociar(string Proveedor)
        {
            var Pedidos = from Ordenes in Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.ToList()
                          where Ordenes.Proveedor.Razon_Social.Contains(Proveedor)
                          //where Ordenes.Estados.Descripcion.Contains("En Curso")
                          select Ordenes;

            return Pedidos.LastOrDefault();
           // return Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.Where(o => o.Proveedor.Razon_Social == Proveedor).FirstOrDefault();
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

        public void Eliminar(Modelo.Orden_Compra art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.Remove(art);
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
        public void Agregar(Modelo.Orden_Compra art)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.Add(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }



        



        



    }
}
