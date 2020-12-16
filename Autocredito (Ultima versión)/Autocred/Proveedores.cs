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
    public partial class Proveedores : Form
    {
        Controladora.ControladoraProveedor cProveedor;
        Modelo.Proveedor oProveedor;
        public Proveedores()
        {
            InitializeComponent();
            cProveedor = Controladora.ControladoraProveedor.obtener_instancia();
            ARMA_GRILLA();
            btnCANCELAR.Visible = false;
        }

        public void ARMA_GRILLA()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = cProveedor.Obtener_Proveedores();
            this.dgvProveedores.Columns["Id"].Visible = false;



        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            Proveedor Frm = new Proveedor(new Modelo.Proveedor(), "A");
            Frm.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = Frm.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            Proveedor Frm = new Proveedor(cProveedor.OBTENER_PROVEEDOR(Convert.ToInt32(dgvProveedores.CurrentRow.Cells[0].Value)), "M");
            Frm.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = Frm.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Rubro de la lista", "ATENCION!!");
                return;
            }
            Modelo.Proveedor oProveedor = cProveedor.OBTENER_PROVEEDOR(Convert.ToInt32(dgvProveedores.CurrentRow.Cells[0].Value));

            DialogResult dr = MessageBox.Show("¿Confirma que desea anular el Proveedor " + oProveedor.Razon_Social + "?", "ELIMINAR Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {

                cProveedor.Eliminar(oProveedor);
                ARMA_GRILLA();
            }
        }

             public void Filtrar()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = cProveedor.Filtrar(textBox1.Text);
            //this.dgvRequerimientos.Columns["Articulo"].Visible = false;
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgvProveedores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Proveedor");
                return;
            }
            oProveedor = cProveedor.Recuperar(Convert.ToInt32(dgvProveedores.CurrentRow.Cells[0].Value));

            this.DialogResult = DialogResult.OK;
        }
        public Modelo.Proveedor ProvSelec

        {
            get { return oProveedor; }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

