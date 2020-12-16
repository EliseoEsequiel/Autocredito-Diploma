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
    public partial class Estados : Form
    {
        Controladora.ControladoraEstado cEstado;
        public Estados()
        {
            InitializeComponent();
            cEstado = Controladora.ControladoraEstado.obtener_instancia();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvRubros.DataSource = null;
            dgvRubros.DataSource = cEstado.Listar();
            this.dgvRubros.Columns["Id"].Visible = false;
            this.dgvRubros.Columns["Orden_Compra"].Visible = false;
        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {

            Estado FrmArticulo = new Estado(new Modelo.Estados(), "A");
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
            Estado formUSUARIO = new Estado(cEstado.OBTENER_Estado(Convert.ToInt32(dgvRubros.CurrentRow.Cells[0].Value)), "M");
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
            Modelo.Estados oRubro = cEstado.OBTENER_Estado(Convert.ToInt32(dgvRubros.CurrentRow.Cells[0].Value));

            DialogResult dr = MessageBox.Show("¿Confirma que desea anular el Estado " + oRubro.Descripcion + "?", "ELIMINAR Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {

                cEstado.Eliminar(oRubro);
                ARMA_GRILLA();
            }
        }
    }
}
