using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProveedor
    {
        private static ControladoraProveedor _instancia;

        private ControladoraProveedor() { }

        // Modelo.ModeloDatosContainer1 oModelo;
        Modelo.SingletonContexto oSingleton;

        /* private controladora_Articulos()
         {
             oSingleton = Modelo.SingletonContexto.obtener_instancia();
         }*/
        public static ControladoraProveedor obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraProveedor();
            }
            return _instancia;
        }


        public System.Collections.IEnumerable Listar_Proveedores()
        {
            var prov = from Proveedor in Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.ToList()

                                 select new { Id = Proveedor.Id, Razon_Social = Proveedor.Razon_Social, Email = Proveedor.Email, Rubro = Proveedor.Rubro.Descripcion };

            return prov.ToList();
        }

        public Modelo.Proveedor OBTENER_PROVEEDOR(int codigo)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.Find(codigo);
        }

        public void Modificar(Modelo.Proveedor oProv)
        {
            //oModelo = Modelo.SingletonContexto.obtener_instancia();
            /* Modelo.SingletonContexto.Entry(oArticulos).State = System.Data.Entity.EntityState.Modified;
             oMODELO_SEGURIDAD.SaveChanges();*/
            //Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.(oArticulos);

            Modelo.SingletonContexto.obtener_instancia().Contexto.Entry(oProv).State = System.Data.Entity.EntityState.Modified;
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }

        public void Eliminar(Modelo.Proveedor art)
        {

            Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.Remove(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();

        }
        public Modelo.Proveedor Recuperar(Int32 Id)
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.Find(Id);
        }

        public bool VALIDA_NOMBRE_Proveedor(string nombre_Rubro)
        {
            Modelo.Proveedor oRubro = Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.FirstOrDefault(u => (u.Razon_Social == nombre_Rubro));
            if (oRubro == null)
                return false;
            else
                return true;
        }
        public void Agregar_Proveedor(Modelo.Proveedor art)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.Add(art);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public List<Modelo.Proveedor> Listar()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.ToList();
        }

        public System.Collections.IEnumerable Obtener_Proveedores()
        {
            var proveedor = from Proveedor in Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.ToList()
                            select new { Id = Proveedor.Id, Razon_Social = Proveedor.Razon_Social, Email = Proveedor.Email, Rubro = Proveedor.Rubro.Descripcion };

            return proveedor.ToList();
        }

        public bool ValidarFk(Int32 id_Req)
        {
            Modelo.Orden_Compra oArticulo = Modelo.SingletonContexto.obtener_instancia().Contexto.Orden_CompraSet.FirstOrDefault(u => (u.Proveedor.Id == id_Req));
            if (oArticulo == null)
                return false;
            else
                return true;
        }

        public System.Collections.IEnumerable Filtrar(string Descripcion)
        {
            var proveedor = from Proveedor in Modelo.SingletonContexto.obtener_instancia().Contexto.ProveedorSet.ToList()
                        where Proveedor.Razon_Social.Contains(Descripcion)
                        select new { Id = Proveedor.Id, Razon_Social = Proveedor.Razon_Social };

            return proveedor.ToList();
        }



    }
}

