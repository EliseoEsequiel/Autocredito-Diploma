using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class detalle
    {
        

        public Int32 Id { get; set; }

        
        public string Cantidad { get; set; }
        public string Articulo { get; set; }
        public bool Estado { get; set; }
        //public int Id_Orden { get; set; }

        public Int32 Id_Req { get; set; }
        public int Id_Art { get; set; }
    }
}
