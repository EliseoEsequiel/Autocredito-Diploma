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
    public partial class Articulos : Form
    {

        //Controladora.controladora_Articulos cArticulos;
        public Articulos()
        {
            InitializeComponent();
            cArticulos = Controladora.controladora_Articulos.obtener_instancia();
            ARMA_GRILLA();
        }
        public Articulos(string Accion)
        {
            InitializeComponent();
            cArticulos = Controladora.controladora_Articulos.obtener_instancia();
            ARMA_GRILLA();
        }
        Controladora.controladora_Articulos cArticulos;
        Modelo.Articulo oARTICULO;
        public Modelo.Articulo ArticuloSelec

        {
            get { return oARTICULO; }
        }

        public void ARMA_GRILLA()
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = cArticulos.OBTENER_Articulos();
            this.dgvArticulos.Columns["Id"].Visible = false;        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void dgvArticulos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad");
                return;
            }
            oARTICULO = cArticulos.Recuperar(Convert.ToInt32(dgvArticulos.CurrentRow.Cells[0].Value));

            this.DialogResult = DialogResult.OK;

        }

        private void Articulos_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            Articulo FrmArticulo = new Articulo(new Modelo.Articulo(), "A");
            DialogResult dr = FrmArticulo.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            Modelo.Articulo oArticulo = cArticulos.OBTENER_ARTICULO(Convert.ToInt32(dgvArticulos.CurrentRow.Cells[0].Value));

            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar el artículo " + oArticulo.Id + "?", "ELIMINAR ARTICULO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                if (cArticulos.ValidarFk(Convert.ToInt32(dgvArticulos.CurrentRow.Cells[0].Value)))
                {
                    // MessageBox.Show("El requerimiento no se puede eliminar porque se encuentra en una orden de compra");

                    DialogResult drr = MessageBox.Show("El pedido tiene una orden asociada, desea eliminar de todas formas el pedido " + oArticulo.Id + "?", "ELIMINAR USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drr == System.Windows.Forms.DialogResult.Yes)
                        oArticulo.Borrado = true;
                    cArticulos.modificarArticulos(oArticulo);
                    ARMA_GRILLA();

                    //return;

                }
                else
                    cArticulos.Eliminar(oArticulo);
                ARMA_GRILLA();
            }
            //DialogResult dr = MessageBox.Show("¿Confirma que desea anular el Articulo " + oArticulo.Descripcion + "?", "ELIMINAR Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == System.Windows.Forms.DialogResult.Yes)
            //{

            //    cArticulos.Eliminar(oArticulo);
            //    ARMA_GRILLA();
            //}
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            Articulo formUSUARIO = new Articulo(cArticulos.OBTENER_ARTICULO(Convert.ToInt32(dgvArticulos.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {

        }
    }
    }

