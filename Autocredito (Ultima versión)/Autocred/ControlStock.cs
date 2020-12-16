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
    public partial class ControlStock : Form
    {
        Controladora.controladora_Articulos cArticulos;
        Modelo.Articulo oArticulo;
        sujeto sujeto = new sujeto();
        public ControlStock()
        {
            InitializeComponent();
            observador observador = new observador();
            sujeto.RegistrarObserver(observador);
            cArticulos = Controladora.controladora_Articulos.obtener_instancia();
        }

        private void btn_Art_Click(object sender, EventArgs e)
        {
           
        }

        public Int32 Stock_Actual;
        public Int32 Cantidad_Ingresada;
        public Int32 Pendientes_Actuales;
        public Int32 Nuevo_Stock;


        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox_Art.Text == "")
            {

                MessageBox.Show("Debe Ingresar un artìculo");
                return;
            }
            if (textbox_Cant.Text == "")
            {

                MessageBox.Show("Debe Ingresar una cantidad");
                return;
            }

           

            Cantidad_Ingresada = Convert.ToInt32(textbox_Cant.Text);
            Stock_Actual = oArticulo.Stock;



           

            if ( rdb_Suma.Checked == true)
            {
                Nuevo_Stock = Cantidad_Ingresada + Stock_Actual;
                oArticulo.Stock = Nuevo_Stock;
                cArticulos.modificarArticulos(oArticulo);
                MessageBox.Show("Stock Actualizado");
            }

            else if (rdb_Resta.Checked == true)
            {
                Nuevo_Stock = Stock_Actual - Cantidad_Ingresada;
                
                if (Nuevo_Stock < 0)
                {
                    MessageBox.Show("No hay stock");
                    return;
                }

                oArticulo.Stock = Nuevo_Stock;
                

                cArticulos.modificarArticulos(oArticulo);

                try
                {
                    sujeto.NotificarObservers(Nuevo_Stock, oArticulo.Stock_Min);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               

            }


        }

        private void textbox_Cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textbox_Cant_TextChanged(object sender, EventArgs e)
        {

        }

        private void ControlStock_Load(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Articulos frm = new Articulos("Buscar");
            frm.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oArticulo = frm.ArticuloSelec;
                textbox_Art.Text = oArticulo.Descripcion;
                //cmbPROVEEDOR.SelectedItem = oPROVEEDOR;
            }
        }
    }
}
