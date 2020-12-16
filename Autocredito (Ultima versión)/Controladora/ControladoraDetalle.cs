using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraDetalle
    {

        private static ControladoraDetalle _instancia;

        private ControladoraDetalle() { }

        // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

        /* private controladora_Articulos()
         {
             oSingleton = Modelo.SingletonContexto.obtener_instancia();
         }*/
        public static ControladoraDetalle obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraDetalle();
            }
            return _instancia;
        }


        public System.Collections.IEnumerable Listar()
        {
            var Pedidos = from DetalleCompra in Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.ToList()

                          select new { Id = DetalleCompra.Id, Articulo = DetalleCompra.Requerimiento.Articulo.Descripcion, Cantidad = DetalleCompra.Cantidad, Estado = DetalleCompra.Requerimiento.Estado };

            return Pedidos.ToList();
        }
        public List<detalle> Filtrar(int Descripcion)
        {
            var Pedidos = from DetalleCompra in Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.ToList()
                          where DetalleCompra.Orden_Compra.Id.Equals(Descripcion)
                          select new detalle { Id = DetalleCompra.Id, Articulo = DetalleCompra.Requerimiento.Articulo.Descripcion, Cantidad = DetalleCompra.Cantidad, Estado = DetalleCompra.Requerimiento.Estado, Id_Req = DetalleCompra.Requerimiento.Id_Req, Id_Art = DetalleCompra.Requerimiento.Articulo.Id};
           
                return Pedidos.ToList();
            
               
            
            
            
        }

        public Modelo.DetalleCompra OBTENER(int codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.Find(codigo);
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

        public void Eliminar(Modelo.DetalleCompra art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.Remove(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
        public void Eliminar_Multiple(int art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.RemoveRange(SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.Where(u => (u.Orden_Compra.Id == art)));
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
        public void Agregar(Modelo.DetalleCompra art)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.Add(art);
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
