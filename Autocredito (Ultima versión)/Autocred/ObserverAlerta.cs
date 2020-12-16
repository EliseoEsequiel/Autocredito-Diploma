using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autocred
{


    public class observador : IObserver
    {


        public Int32 Stock_Min;
        public Int32 Stock;



        public void update(Int32 stock, Int32 stockMin)
        {


            Stock = stock;
            Stock_Min = stockMin;
            // Comprobamos que los valores no exceden los limites
            ComprobarStock();



        }



        // Metodo que comprueba los niveles de aceite
        public void ComprobarStock()
        {
            if (Stock <= Stock_Min)
            {
                EnviarAlerta();

            }

            if (Stock > Stock_Min)
            {
                 throw new Exception("Stock Actualizado");
            }

        }



        // Metodo que envie la alerta
        private void EnviarAlerta()
        {
            // Este metodo podria enviar una alerta a la centralita del vehiculo que, por ejemplo,
            // forzaria a su detencion
            throw new Exception("Atención!! Stock Minimo");
        }
    }





    public class sujeto : ISubject
    {



        #region Estado

        // Atributos que modelan el estado
        //TextBox stock;


        #endregion

        // Listado de observers
        List<IObserver> suscriptores = new List<IObserver>();

        #region Properties





        #endregion

        #region Metodos de la interfaz ISubject

        // Constructor que creara un medidor con los valores iniciales de las presiones


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
        public void NotificarObservers(Int32 stock, Int32 stockMin)
        {


            foreach (IObserver ob in suscriptores)
            {
                // Invocamos el metodo Update de cada observer, pasandole el array con el estado
                // del subject como parametro.
                // Cada observer ya hara lo que estime necesario con esa informacion.
                ob.update(stock, stockMin);
            }

            #endregion
        }
    }
}
