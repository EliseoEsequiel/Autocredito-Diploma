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
    public partial class frmUSUARIO : Form
    {
        Modelo.Usuario oUSUARIO;
        Controladora.ControladoraUsuario cUSUARIOS;
        Controladora.ControladoraGrupos cGrupos;
        Modelo.Grupo oGrupo;
        string ACCION;
        //bool checkearA;
        public frmUSUARIO(Modelo.Usuario miUSUARIO, string miACCION)
        {
            InitializeComponent();
            cUSUARIOS = Controladora.ControladoraUsuario.obtener_instancia();
            cGrupos = Controladora.ControladoraGrupos.obtener_instancia();
            oUSUARIO = miUSUARIO;
            ACCION = miACCION;
            if (ACCION != "A")
            {

                txtNOMBRE_USUARIO.Text = oUSUARIO.Alias;
                txtNOMBRE.Text = oUSUARIO.Nombre;
                textBoxApellido.Text = oUSUARIO.Apellido;




            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            //Modelo.Usuario oUSUARIO = new Modelo.Usuario();
            if (string.IsNullOrEmpty(txtNOMBRE_USUARIO.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para el acceso al sistema", "ATENCION!!");
                return;
            }

            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario", "ATENCION!!");
                return;
            }
        


            oUSUARIO.Alias = txtNOMBRE_USUARIO.Text;
            oUSUARIO.Nombre = txtNOMBRE.Text;
            oUSUARIO.Apellido = textBoxApellido.Text;

            


            if (ACCION == "A")
            {
                if (string.IsNullOrEmpty(txtDescripcionGupo.Text))
                {
                    MessageBox.Show("Debe ingresar el grupo para el acceso al sistema", "ATENCION!!");
                    return;
                }
                if (cUSUARIOS.VALIDA_NOMBRE_USUARIO(txtNOMBRE_USUARIO.Text))
                {
                    MessageBox.Show("El nombre de usuario para el acceso al sistema ya se encuentra asignado a otro usuario", "ATENCION!!");
                    return;
                }
                oUSUARIO.Pass = Controladora.controladoraLogin.EncriptarClave(txtNOMBRE_USUARIO.Text);
                oGrupo.Usuario.Add(oUSUARIO);

                cUSUARIOS.AgregarUsuario(oUSUARIO);
                
            }
            else
            {
                oUSUARIO.Grupo = oGrupo; 
                //Modelo.SingletonContexto.obtener_instancia().Contexto.UsuarioSet.Attach(oUSUARIO);
               // oGrupo.Usuario.Add(oUSUARIO);
                cUSUARIOS.modificarUsuario(oUSUARIO);
                //oUSUARIO.Grupo.Id = Convert.ToInt32(txtIdGrupo.Text);
                //cGrupos.modificarGrupos(oGrupo);
              
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmUSUARIO_Load(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
           
                
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Grupos frm = new Grupos("Buscar");

            frm.Size = new Size(355, 445);
            frm.btnCANCELAR.Visible = true;
            frm.btnGUARDAR.Visible = true;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oGrupo = frm.GrupoSelec;
                txtIdGrupo.Text = oGrupo.Id.ToString();
                txtDescripcionGupo.Text = oGrupo.Descripcion;



            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
