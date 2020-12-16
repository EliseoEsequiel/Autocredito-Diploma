using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;

namespace Autocred
{
   
    public partial class New_Item : Form
    {
        Controladora.controladora_Articulos cArticulos;
        Controladora.Controladora_Req cReq;
        Modelo.Requerimiento oRequerimiento;
        Modelo.Articulo oArticulo;

        string ACCION;
        Int32 PedidoMaximo;
        public New_Item(Modelo.Requerimiento miReq, string miACCION)
        {

            InitializeComponent();
            cReq = Controladora.Controladora_Req.obtener_instancia();
            cArticulos = Controladora.controladora_Articulos.obtener_instancia();
            oRequerimiento = miReq;
            ACCION = miACCION;
            if (ACCION != "A")
            {

                textbox_Desc.Text = oRequerimiento.Articulo.Descripcion;
                textBox_Cant.Text = oRequerimiento.Cantidad.ToString();
                //btn_AddReq.Enabled = false;
                PedidoMaximo = oRequerimiento.Articulo.Pedido_Max;





            }
        }
        public New_Item()
        {
            InitializeComponent();
            //oArticulo = unArticulo;
            cArticulos = Controladora.controladora_Articulos.obtener_instancia();
            cReq = Controladora.Controladora_Req.obtener_instancia();
           
            
        }

        EmployeeClass objEmployee = new EmployeeClass
        {
            Id_Articulo = "",
            Descripcion = "",
            Cantidad = "",

            Orignal = new EmployeeClassClone
            {
                Id_Articulo = "",
                Descripcion = "",
                Cantidad = ""
            }
        };
        private void New_Item_Load(object sender, EventArgs e)
        {
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            textbox_Id.Text = objEmployee.Id_Articulo;
            textbox_Desc.Text = objEmployee.Descripcion;
            textBox_Cant.Text = objEmployee.Cantidad;
        }



        private void btn_AddReq_Click(object sender, EventArgs e)
        {
           
            /* Form Articulos = new Articulos("BUSCAR");
             DialogResult dr = Articulos.ShowDialog();
             if (dr == DialogResult.OK)
             {

                 oArticulo = cArticulos.OBTENER_ARTICULOS();
                 textbox_Desc.SelectedItem = OArticulos;
             }
             Articulos.Show();*/
        }
        public Int32 sumaPendientes;
        public Int32 PendientesActuales;
        public Int32 TotalPendientes;
        public string Requerimiento;
        public Int32 Stock;
        public Int32 PedidosActuales;


        private void btn_SaveItem_Click(object sender, EventArgs e)
        {
            
        }

           
           

        
                   
                   
              











           
        

        private void btn_Limpiar_Click(object sender, EventArgs e)
                
        {
            objEmployee.Revert();
            DisplayDetails();
        }



        private void textBox_Cant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void New_Item_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (textbox_Desc.Text == "")
            {

                MessageBox.Show("Debe Ingresar un artìculo");
                return;
            }
            if (textBox_Cant.Text == "")
            {

                MessageBox.Show("Debe Ingresar una cantidad");
                return;
            }

            //Modelo.Requerimiento    oRequerimiento = new Modelo.Requerimiento();
            sumaPendientes = Convert.ToInt32(textBox_Cant.Text);



            //oArticulo.Pendientes = Convert.ToInt32(textBox_Cant.Text);

            if (ACCION == "A")
            {



                if (cReq.VALIDA_NOMBRE_Articulo(textbox_Desc.Text) )
                {
                   if (cReq.Asociar(textbox_Desc.Text).Estado == false)
                {
                    
                        MessageBox.Show("El nombre de Articulo ya se encuentra asignado a otro Articulo", "ATENCION!!");
                        return;
                    

                }
                   
                }
                Stock = oArticulo.Stock;
                if (Stock <= oArticulo.Stock_Min && Convert.ToInt32(textBox_Cant.Text) <= oArticulo.Pedido_Max)
                {
                    Modelo.Requerimiento requerimiento = new Modelo.Requerimiento();
                    oArticulo.Pendientes = Convert.ToInt32(textBox_Cant.Text) + oArticulo.Pendientes;
                   // oArticulo.Estado = false;
                    cArticulos.modificarArticulos(oArticulo);


                    //odelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.Attach(oArticulo);

                    oArticulo.Requerimiento.Add(oRequerimiento);

                    requerimiento.Articulo = oArticulo;
                    oRequerimiento.Cantidad = Convert.ToInt32(textBox_Cant.Text);


                    oRequerimiento.Fecha = DateTime.Now;
                    oRequerimiento.Estado = false;
                    cReq.Agregar_Requerimiento(oRequerimiento);
                    Controladora.controladora_Articulos.obtener_instancia().modificarArticulos(oArticulo);
                    MessageBox.Show("Solicitud Realizada");
                    this.DialogResult = DialogResult.OK;
                }

                else
                {
                    MessageBox.Show("Error!! Cantidad incorrecta");
                }



            }
            else
            {

                if (sumaPendientes > PedidoMaximo)
                {
                    MessageBox.Show("La cantidad Ingresada supera los pedidos Maximos");
                    return;

                }
                else
                {
                    oRequerimiento.Cantidad = Convert.ToInt32(textBox_Cant.Text);
                    cReq.modificarRequerimiento(oRequerimiento);
                }
                //cArticulos.modificarArticulos(oArticulo);
                //oUSUARIO.Grupo.Id = Convert.ToInt32(txtIdGrupo.Text);
                //cGrupos.modificarGrupos(oGrupo);


            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Articulos frm = new Articulos("Buscar");
            frm.Size = new Size(646, 382);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormBorderStyle = FormBorderStyle.None;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oArticulo = frm.ArticuloSelec;
                textbox_Desc.Text = oArticulo.Descripcion;
                textbox_Id.Text = oArticulo.Id.ToString();


            }
        }
    }
}
