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
    public partial class frmRubro : Form
    {
        Modelo.Rubro oRubro;
        Controladora.ControladoraRubro cRubro;

        string ACCION;
        public frmRubro(Modelo.Rubro miubro, string miACCION)
        {

            InitializeComponent();
            cRubro = Controladora.ControladoraRubro.obtener_instancia();

            oRubro = miubro;
            ACCION = miACCION;
            if (ACCION != "A")
            {
               textBoxDesc.Text = oRubro.Descripcion;
            }

        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            //Modelo.Usuario oUSUARIO = new Modelo.Usuario();
            if (string.IsNullOrEmpty(textBoxDesc.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para el acceso al sistema", "ATENCION!!");
                return;
            }

           


            oRubro.Descripcion = textBoxDesc.Text;
           




            if (ACCION != "A")
            {


                cRubro.modificarRubro(oRubro);


            }
            else
            {
                if (cRubro.VALIDA_NOMBRE_Rubro(textBoxDesc.Text))
                {
                    MessageBox.Show("El nombre de Articulo  ya se encuentra asignado a otro Articulo", "ATENCION!!");
                    return;
                }

                cRubro.Agregar_Rubro(oRubro);



            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
