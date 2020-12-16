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
    public partial class frmCLAVE_USUARIO : Form
    {
        Modelo.Usuario oUSUARIO;
        Controladora.ControladoraUsuario cUSUARIOS;
        public frmCLAVE_USUARIO(Modelo.Usuario miUSUARIO)
        {
            InitializeComponent();
            cUSUARIOS = Controladora.ControladoraUsuario.obtener_instancia();
            oUSUARIO = miUSUARIO;

        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPASSWORD.Text))
            {
                MessageBox.Show("Debe ingresar la nueva contraseña del usuario", "ATENCION!!");
                return;
            }
            if (txtPASSWORD.Text != txtPASSWORD2.Text)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "ATENCION!!");
                return;
            }
            oUSUARIO.Pass= Controladora.controladoraLogin.EncriptarClave(txtPASSWORD.Text);

            cUSUARIOS.modificarUsuario(oUSUARIO);
           

            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
