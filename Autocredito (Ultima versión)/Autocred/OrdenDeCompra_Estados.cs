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
    public partial class OrdenDeCompra_Estados : Form
    {
        Controladora.ControladoraEstado cEstado;
        Modelo.Estados oEstado;
        string Accion;
        public OrdenDeCompra_Estados(string miACCION)
        {
            InitializeComponent();
            cEstado = Controladora.ControladoraEstado.obtener_instancia();
            ARMA_GRILLA();
            Accion = miACCION;


        }
        public Modelo.Estados ArticuloSelec

        {
            get { return oEstado; }
        }

        public void ARMA_GRILLA()
        {
            dgvPendiente.DataSource = null;
            dgvPendiente.DataSource = cEstado.OBTENER_Estados();
            this.dgvPendiente.Columns["Id"].Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb_Pendiente.Checked == true)
            {
               // oEstado = cEstado.OBTENER_Estado()
            }
        }

        private void dgvPendiente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPendiente.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad");
                return;
            }
            oEstado = cEstado.OBTENER_Estado(Convert.ToInt32(dgvPendiente.CurrentRow.Cells[0].Value));

            this.DialogResult = DialogResult.OK;

        }
    }
}
