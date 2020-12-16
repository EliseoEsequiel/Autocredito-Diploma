using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocred
{
    public class MedidorSensores : ISubject
    {
        #region Estado

        // Atributos que modelan el estado
        private int stock;
      

        #endregion

        // Listado de observers
        IList suscriptores;

        #region Properties

        public int Stock
        {
            get { return this.stock; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            set
            {
                if (this.stock != value)
                {
                    this.stock = value;
                    NotificarObservers();
                }
            }
        }

      

        #endregion

        #region Metodos de la interfaz ISubject

        // Constructor que creara un medidor con los valores iniciales de las presiones
        public MedidorSensores(int stock)
        {
            this.suscriptores = new ArrayList();
            this.stock = stock;
            
        }

        // Comprobamos si el observer se encuentra en la lista. En caso contrario,
        // lo incluye en la lista
        public void RegistrarObserver(IObserver o)
        {
            if (!suscriptores.Contains(o))
                suscriptores.Add(o);
        }

        // Comprobamos si el observer se encuentra en la lista. En caso afirmativo,
        // lo elimina de la lista
        public void EliminarObserver(IObserver o)
        {
            if (suscriptores.Contains(o))
                suscriptores.Remove(o);
        }

        // Recorre la lista de observers e invoca su metodo Update()
        public void NotificarObservers()
        {
            // Creamos un array con el estado del Subject
            int[] valores = { this.stock };

            // Recorremos todos los objetos suscritos (observers)
            IObserver observer;
            foreach (Object o in suscriptores)
            {
                // Invocamos el metodo Update de cada observer, pasandole el array con el estado
                // del subject como parametro.
                // Cada observer ya hara lo que estime necesario con esa informacion.
                observer = (IObserver)o;
                observer.update(valores);
            }
        }

        #endregion
    }
}
