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
    public partial class FrmUsuarios : Form
    {
        Controladora.ControladoraUsuario cUsuario;
        Modelo.Usuario oUsuario;

        public FrmUsuarios()
        {
            cUsuario = Controladora.ControladoraUsuario.obtener_instancia();
           
            
            InitializeComponent();

           
            ARMA_GRILLA();

        }

        
        public void ARMA_GRILLA()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = cUsuario.ObtenerUsuarios();
            this.dgvUsuarios.Columns["Id"].Visible = false;
            //this.dgvUsuarios.Columns[1].DefaultCellStyle.BackColor = Color.Transparent;
            //this.dgvUsuarios.Columns["Pass"].Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }

            frmCLAVE_USUARIO formCAMBIAR_CLAVE = new frmCLAVE_USUARIO(cUsuario.OBTENER_USUARIO(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value)));
            formCAMBIAR_CLAVE.StartPosition = FormStartPosition.CenterParent;
            formCAMBIAR_CLAVE.FormBorderStyle = FormBorderStyle.None;

            DialogResult dr = formCAMBIAR_CLAVE.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show("Se ha cambiado la clave.", "CAMBIO DE CLAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            frmUSUARIO formUSUARIO = new frmUSUARIO(cUsuario.OBTENER_USUARIO(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();


        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            frmUSUARIO formUSUARIO = new frmUSUARIO(new Modelo.Usuario(), "A");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            Modelo.Usuario oUSUARIO = cUsuario.OBTENER_USUARIO(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
            
            DialogResult dr = MessageBox.Show("¿Confirma que desea anular la cuenta del usuario " + oUSUARIO.Alias + "?", "ELIMINAR USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                
                cUsuario.Eliminar(oUSUARIO);
                ARMA_GRILLA();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

