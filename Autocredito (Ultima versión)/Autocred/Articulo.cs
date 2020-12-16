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
    public partial class Articulo : Form

    {

        Modelo.Articulo oArticulo;
        Controladora.controladora_Articulos cArticulo;
        Modelo.Rubro oRubro;
        Controladora.ControladoraRubro cRubro;

        string ACCION;
        public Articulo(Modelo.Articulo miArticulo, string miACCION)
        {
            InitializeComponent();
            cArticulo = Controladora.controladora_Articulos.obtener_instancia();
            cRubro = Controladora.ControladoraRubro.obtener_instancia();

            oArticulo = miArticulo;
            ACCION = miACCION;
            if (ACCION != "A")
            {

                txtNOMBRE_USUARIO.Text = oArticulo.Descripcion;
                txtNOMBRE.Text = oArticulo.Stock.ToString();
                textBoxApellido.Text = oArticulo.Pendientes.ToString();
                textBoxStockMin.Text = oArticulo.Stock_Min.ToString();
                textBoxPedidoMax.Text = oArticulo.Pedido_Max.ToString();




            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            //Modelo.Usuario oUSUARIO = new Modelo.Usuario();
            if (string.IsNullOrEmpty(txtNOMBRE_USUARIO.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para el acceso al sistema", "ATENCION!!");
                return;
            }

            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario", "ATENCION!!");
                return;
            }
          

            oArticulo.Descripcion = txtNOMBRE_USUARIO.Text;
            oArticulo.Stock = Convert.ToInt32(txtNOMBRE.Text);
            oArticulo.Pendientes = Convert.ToInt32(textBoxApellido.Text);
            oArticulo.Stock_Min = Convert.ToInt32(textBoxStockMin.Text);
            oArticulo.Pedido_Max = Convert.ToInt32(textBoxPedidoMax.Text);




            if (ACCION != "A")
            {
                

                cArticulo.modificarArticulos(oArticulo);
                

            }
            else 
            {
                if (cArticulo.VALIDA_NOMBRE_Articulo(txtNOMBRE_USUARIO.Text))
                {
                    MessageBox.Show("El nombre de Articulo  ya se encuentra asignado a otro Articulo", "ATENCION!!");
                    return;
                }

                oRubro.Articulo.Add(oArticulo);
                cArticulo.Agregar_Articulo(oArticulo);



            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Rubros frm = new Rubros();

            frm.Size = new Size(295, 450);
            frm.btnCANCELAR.Visible = true;
            frm.btnGUARDAR.Visible = true;
            frm.btnALTAS.Visible = false;
            frm.btnBAJAS.Visible = false;
            frm.btnMODIFICACIONES.Visible = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oRubro = frm.GrupoSelec;
                txtIdRubro.Text = oRubro.Id.ToString();
                txtDescripcionRubro.Text = oRubro.Descripcion;



            }
        }
    }
}
