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
    public partial class Rubros : Form
    {
        Controladora.ControladoraRubro cRubro;
        Modelo.Rubro oRubro;
        public Rubros()
        {
            InitializeComponent();
            cRubro = Controladora.ControladoraRubro.obtener_instancia();
            ARMA_GRILLA();
            btnGUARDAR.Visible = false;
            btnCANCELAR.Visible = false;
        
        }
        public Rubros(string Accion)
        {
            InitializeComponent();
            cRubro = Controladora.ControladoraRubro.obtener_instancia();
            ARMA_GRILLA();
            
        }

        public void ARMA_GRILLA()
        {
            dgvRubros.DataSource = null;
            dgvRubros.DataSource = cRubro.Listar_Rubro();
            this.dgvRubros.Columns["Id"].Visible = false;
            this.dgvRubros.Columns["Articulo"].Visible = false;
            this.dgvRubros.Columns["Proveedor"].Visible = false;
        }

        public Modelo.Rubro GrupoSelec

        {
            get { return oRubro; }
        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            frmRubro FrmArticulo = new frmRubro(new Modelo.Rubro(), "A");
            DialogResult dr = FrmArticulo.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvRubros.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            frmRubro formUSUARIO = new frmRubro(cRubro.OBTENER_Rubro(Convert.ToInt32(dgvRubros.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvRubros.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Rubro de la lista", "ATENCION!!");
                return;
            }
            Modelo.Rubro oRubro = cRubro.OBTENER_Rubro(Convert.ToInt32(dgvRubros.CurrentRow.Cells[0].Value));

            DialogResult dr = MessageBox.Show("¿Confirma que desea anular el Rubro " + oRubro.Descripcion + "?", "ELIMINAR Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {

                cRubro.Eliminar(oRubro);
                ARMA_GRILLA();
            }
        }

        public void Filtrar()
        {
            dgvRubros.DataSource = null;
            dgvRubros.DataSource = cRubro.Filtrar(textBox1.Text);
            //this.dgvRequerimientos.Columns["Articulo"].Visible = false;
        }
        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgvRubros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCANCELAR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (dgvRubros.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Rubro");
                return;
            }
            oRubro = (Modelo.Rubro)dgvRubros.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
        }
    }
}
