using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autocred
{
    public partial class Estado : Form
    {
        Modelo.Estados oEstado;
        Controladora.ControladoraEstado cEstado;
        string ACCION;

        public Estado(Modelo.Estados miEstado, string miACCION)
        {
            InitializeComponent();
            cEstado = Controladora.ControladoraEstado.obtener_instancia();

            oEstado = miEstado;
            ACCION = miACCION;
            if (ACCION != "A")
            {

                textBoxDesc.Text = oEstado.Descripcion;





            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDesc.Text))
            {
                MessageBox.Show("Debe ingresar Descripciòn", "ATENCION!!");
                return;
            }




            oEstado.Descripcion = textBoxDesc.Text;





            if (ACCION != "A")
            {


                cEstado.modificar(oEstado);


            }
            else
            {
                if (cEstado.VALIDA_Descripcion(textBoxDesc.Text))
                {
                    MessageBox.Show("El nombre de Articulo  ya se encuentra asignado a otro Articulo", "ATENCION!!");
                    return;
                }

                cEstado.Agregar(oEstado);



            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
