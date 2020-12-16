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
    public partial class Lista_Ordenes : Form
    {
        Controladora.ControladoraOrdenes cOrden;
        Controladora.ControladoraDetalle cDetalle;
        Modelo.Orden_Compra oCompra;
        public Lista_Ordenes()
        {
            InitializeComponent();
            cOrden = Controladora.ControladoraOrdenes.obtener_instancia();
            cDetalle = Controladora.ControladoraDetalle.obtener_instancia();
            ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            dgvOrdenes.DataSource = null;
            dgvOrdenes.DataSource = cOrden.Listar();
            this.dgvOrdenes.Columns["Id"].Visible = false;
        }

        private void btn_Add_Orden_Click(object sender, EventArgs e)
        {
            
        }

        private void Lista_Ordenes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
         
            dgvOrdenes.DataSource = null;
            dgvOrdenes.DataSource = cOrden.Filtrar(textBoxfiltro.Text);
            this.dgvOrdenes.Columns["Id"].Visible = false;
        
    }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }

            New_Orden compraDetalle = new New_Orden(cOrden.OBTENER(Convert.ToInt32(dgvOrdenes.CurrentRow.Cells[0].Value)), "M");
            compraDetalle.FormBorderStyle = FormBorderStyle.None;
            //compraDetalle.btn_AddProv.Enabled = false;
            DialogResult dr = compraDetalle.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            New_Orden compraDetalle = new New_Orden(new Modelo.Orden_Compra(), "A");
            compraDetalle.FormBorderStyle = FormBorderStyle.None;
            compraDetalle.Add_Item.Enabled = false;
            DialogResult dr = compraDetalle.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden de la lista", "ATENCION!!");
                return;
            }
            Modelo.Orden_Compra orden = cOrden.OBTENER(Convert.ToInt32(dgvOrdenes.CurrentRow.Cells[0].Value));

            DialogResult dr = MessageBox.Show("¿Confirma que desea anular la oden de compra para " + orden.Proveedor.Razon_Social + "?", "ELIMINAR ORDEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {

                if (orden.Estados.Descripcion != "En curso")
                {
                    MessageBox.Show("La orden no se puede eliminar porque posee un remito");
                    return;

                }
                else

                cDetalle.Eliminar_Multiple(orden.Id);
                cOrden.Eliminar(orden);
                ARMA_GRILLA();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
