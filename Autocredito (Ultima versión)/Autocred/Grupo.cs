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
    public partial class Grupo : Form
    {
       
        Controladora.ControladoraGrupos cGrupos;
        Modelo.Grupo oGrupo;
        string ACCION;
        public Grupo(Modelo.Grupo miGrupo, string miACCION)
        {
            InitializeComponent(); 
            cGrupos = Controladora.ControladoraGrupos.obtener_instancia();
            oGrupo = miGrupo;
            ACCION = miACCION;
            if (ACCION != "A")
            {

                
                textBoxDesc.Text = oGrupo.Descripcion;
               




            }
        }

       

       

      

       

       

       

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDesc.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para el acceso al sistema", "ATENCION!!");
                return;
            }

            oGrupo.Descripcion = textBoxDesc.Text;





            if (ACCION == "A")
            {

                

                cGrupos.AgregarGrupo(oGrupo);

            }
            else
            {

                cGrupos.modificarGrupos(oGrupo);


            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
