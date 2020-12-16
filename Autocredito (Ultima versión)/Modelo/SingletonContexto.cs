using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SingletonContexto
    {
        private static SingletonContexto _instancia;
        private static ModeloNuevoContainer _contexto;

        private SingletonContexto() { }

        public static SingletonContexto obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new SingletonContexto();
                _contexto = new ModeloNuevoContainer();
            }
            return _instancia;
        }

        public ModeloNuevoContainer Contexto
        {
            get { return _contexto; }
        }

       
    }
}