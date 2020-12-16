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
    public partial class Remitos : Form
    {
        Controladora.ControladoraRemitos cRemitos;
        Modelo.Remitos oRemito;
        public Remitos()
        {
            InitializeComponent();
            cRemitos = Controladora.ControladoraRemitos.obtener_instancia();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvRemitos.DataSource = null;
            dgvRemitos.DataSource = cRemitos.Listar();
            this.dgvRemitos.Columns["Id"].Visible = false;
        }
        private void btnALTAS_Click(object sender, EventArgs e)
        {
            Remito compraDetalle = new Remito(new Modelo.Remitos(), "A");
            compraDetalle.FormBorderStyle = FormBorderStyle.Sizable;
            
            //compraDetalle.Add_Item.Enabled = false;
            DialogResult dr = compraDetalle.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvRemitos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }

            Remito compraDetalle = new Remito(cRemitos.OBTENER(Convert.ToInt32(dgvRemitos.CurrentRow.Cells[0].Value)), "M");
            compraDetalle.FormBorderStyle = FormBorderStyle.Sizable;
            compraDetalle.btn_AddProv.Enabled = false;
           
            DialogResult dr = compraDetalle.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ARMA_GRILLA();
        //}

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvRemitos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden de la lista", "ATENCION!!");
                return;
            }
            Modelo.Remitos orden = cRemitos.OBTENER(Convert.ToInt32(dgvRemitos.CurrentRow.Cells[0].Value));

            DialogResult dr = MessageBox.Show("¿Confirma que desea anular la oden de compra para " + orden.Orden_Compra.Proveedor.Razon_Social + "?", "ELIMINAR ORDEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                cRemitos.Eliminar(orden);
                ARMA_GRILLA();
            }
        }

        private void dgvRemitos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
