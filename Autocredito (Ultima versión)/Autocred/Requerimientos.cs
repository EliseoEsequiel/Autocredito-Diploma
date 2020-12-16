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
    public partial class Requerimientos : Form
    {
        public Requerimientos(Modelo.DetalleCompra detalle)
        {
            InitializeComponent();
            cReq = Controladora.Controladora_Req.obtener_instancia();
            cArticulos = Controladora.controladora_Articulos.obtener_instancia();

            /*foreach ()
            {

            }*/

            ARMA_GRILLA();
        }

       
        public Requerimientos()
        {
            InitializeComponent();
            cReq = Controladora.Controladora_Req.obtener_instancia();
            cArticulos = Controladora.controladora_Articulos.obtener_instancia();

            ARMA_GRILLA();
        }

        Controladora.Controladora_Req cReq;
        Modelo.Articulo oARTICULO;
        Modelo.Requerimiento oRequerimiento;
        Controladora.controladora_Articulos cArticulos;

        public void ARMA_GRILLA()
        {
            dgvRequerimientos.DataSource = null;
            dgvRequerimientos.DataSource = cReq.OBTENER_Requerimientos();
           // this.dgvRequerimientos.Columns["Id"].Visible = false;
        }

        public void Filtrar()
        {
            dgvRequerimientos.DataSource = null;
            dgvRequerimientos.DataSource = cReq.Filtrar(textBox1.Text);
            //this.dgvRequerimientos.Columns["Id"].Visible = false;
        }

       
       

        private void btn_delete_Click(object sender, EventArgs e)
        {

            this.Close();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        public Modelo.Requerimiento ReqSelec

        {
            get { return oRequerimiento; }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            New_Item newItem = new New_Item(new Modelo.Requerimiento(), "A");
            newItem.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = newItem.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            Modelo.Requerimiento oUSUARIO = cReq.Recuperar(Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells[0].Value));

            DialogResult dr = MessageBox.Show("¿Confirma que desea eliminar el pedido " + oUSUARIO.Id_Req + "?", "ELIMINAR USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                if (cReq.ValidarFk(Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells[0].Value)))
                {
                   // MessageBox.Show("El requerimiento no se puede eliminar porque se encuentra en una orden de compra");

                    DialogResult drr = MessageBox.Show("El pedido tiene una orden asociada, desea eliminar de todas formas el pedido " + oUSUARIO.Id_Req + "?", "ELIMINAR USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drr == System.Windows.Forms.DialogResult.Yes)
                        oUSUARIO.Borrado = true;
                    cReq.modificarRequerimiento(oUSUARIO);
                    ARMA_GRILLA();

                    //return;

                }
                else
                cReq.Eliminar(oUSUARIO);
                ARMA_GRILLA();
            }
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            New_Item newItem = new New_Item(cReq.Recuperar(Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells[0].Value)), "M");
            newItem.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = newItem.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgvRequerimientos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvRequerimientos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un requerimiento");
                return;
            }
            oRequerimiento = cReq.Recuperar(Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells[0].Value));


            this.DialogResult = DialogResult.OK;
        }
    }
}
