using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocred
{
    public interface EmployeeInt
    {
        string Id_Articulo { get; set; }
        string Descripcion { get; set; }
        string Cantidad { get; set; }
    }
    public class EmployeeClass : EmployeeInt
    {
        private string id_Articulo;
        public string Id_Articulo
        {
            get
            {
                return id_Articulo;
            }
            set
            {
                id_Articulo = value;
            }
        }
        private string descripcion;
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        private string cantidad;
        public string Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
        private EmployeeClassClone orignal = new EmployeeClassClone();
        public EmployeeClassClone Orignal
        {
            get
            {
                return orignal;
            }
            set
            {
                orignal = value;
            }
        }
        public void Revert()
        {
            this.Id_Articulo = Orignal.Id_Articulo;
            this.Descripcion = Orignal.Descripcion;
            this.Cantidad = Orignal.Cantidad;
        }
        
    }
    public class EmployeeClassClone : EmployeeInt
    {
        private string id_Articulo;
        public string Id_Articulo
        {
            get
            {
                return id_Articulo;
            }
            set
            {
                id_Articulo = value;
            }
        }
        private string descripcion;
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        private string cantidad;
        public string Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
    }
}
