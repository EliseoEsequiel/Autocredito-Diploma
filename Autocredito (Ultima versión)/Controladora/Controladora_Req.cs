using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Controladora_Req
    {
        private static Controladora_Req _instancia;

        private Controladora_Req() { }

        public static Controladora_Req obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new Controladora_Req();
            }
            return _instancia;
        }

        public List<Modelo.Requerimiento> Listar_Requerimientos()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.ToList();
        }

        public void Agregar_Requerimiento(Modelo.Requerimiento req)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.Add(req);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar(Modelo.Requerimiento req)
        {
           
                Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.Remove(req);
                Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
            
        }
        public Modelo.Requerimiento Recuperar(Int32 Id)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.Find(Id);
        }

        public Modelo.Requerimiento OBTENER(Int32 codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.Find(codigo);
        }
        public System.Collections.IEnumerable OBTENER_Requerimientos()
        {
            var requerimientos = from Requerimiento in Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.ToList()
                                 where (Requerimiento.Estado == false && Requerimiento.Borrado == false)
                                 select new { NªPedido = Requerimiento.Id_Req,  Articulo = Requerimiento.Articulo.Descripcion,Cantidad = Requerimiento.Cantidad,Fecha = Requerimiento.Fecha };
            
            return requerimientos.ToList();
        }

        public System.Collections.IEnumerable Filtrar(string Descripcion)
        {
            var Pedidos = from Requerimiento in Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.ToList()
                          where Requerimiento.Articulo.Descripcion.Contains(Descripcion)
                          select new { NªPedido = Requerimiento.Id_Req, Cantidad = Requerimiento.Cantidad, Fecha = Requerimiento.Fecha, Articulo = Requerimiento.Articulo.Descripcion }; 

            return Pedidos.ToList();
        }

        public Modelo.Requerimiento Asociar(string Art)
        {
            var Pedidos = from Requerimientos in Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.ToList()
                          where Requerimientos.Articulo.Descripcion.Contains(Art)
                         
                          select Requerimientos;

            return Pedidos.LastOrDefault();
            // return Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.Where(o => o.Proveedor.Razon_Social == Proveedor).FirstOrDefault();
        }

        public bool VALIDA_NOMBRE_Articulo(string nombre_Articulo)
        {
            Modelo.Requerimiento oArticulo = Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.ToList().LastOrDefault(u => u.Articulo.Descripcion.Contains(nombre_Articulo));
            if (oArticulo == null)
                return false;
            else
                return true;
        }

        public bool ValidarFk(Int32 id_Req)
        {
            Modelo.DetalleCompra oArticulo = Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.FirstOrDefault(u => (u.Requerimiento.Id_Req == id_Req));
            if (oArticulo == null)
                return false;
            else
                return true;
        }

        public virtual void modificarRequerimiento (Modelo.Requerimiento oReq)
        {
           

            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oReq).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
    }
}