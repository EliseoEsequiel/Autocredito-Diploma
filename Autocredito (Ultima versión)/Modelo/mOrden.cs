using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Orden_Compra
    {

       // public Int32 Id { get; set; }

        public void Agregar(DetalleCompra detalle)
            {
                Modelo.DetalleCompra detalle_find = Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.ToList().Find(x => x.Requerimiento == detalle.Requerimiento);

                if (detalle != null)
                {

                    Modelo.SingletonContexto.obtener_instancia().Contexto.DetalleCompraSet.Add(detalle);

                   
                }
            }
        }
    }

