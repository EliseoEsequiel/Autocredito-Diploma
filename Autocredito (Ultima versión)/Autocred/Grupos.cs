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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
            cGrupos = Controladora.ControladoraGrupos.obtener_instancia();
            ARMA_GRILLA();
        }
        public Grupos(string Accion)
        {
            InitializeComponent();
            cGrupos = Controladora.ControladoraGrupos.obtener_instancia();
            ARMA_GRILLA();
        }
        Controladora.ControladoraGrupos cGrupos;
        Modelo.Grupo oGrupo;
        public Modelo.Grupo GrupoSelec

        {
            get { return oGrupo; }
        }



        public void ARMA_GRILLA()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = cGrupos.Listar_Grupos();
        }

        private void dgvGrupos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grupo formUSUARIO = new Grupo(new Modelo.Grupo(), "A");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btn_Modified_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            Grupo frmGrupo = new Grupo(cGrupos.OBTENER_GRUPO(Convert.ToInt32(dgvGrupos.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = frmGrupo.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad");
                return;
            }
            oGrupo = (Modelo.Grupo)dgvGrupos.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }

