using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
//using Controladora;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autocred
{
    public partial class New_Orden : Form
    {
        Modelo.Orden_Compra oOrden;
        Modelo.Orden_Compra Orden = new Modelo.Orden_Compra();
        Controladora.ControladoraOrdenes cOrden;
        Controladora.Controladora_Req cReq;
        Modelo.DetalleCompra oDetalle;
        Controladora.ControladoraDetalle cDetalleCompra;
        Modelo.Requerimiento oReq;
        Modelo.Estados oEstado;
        Modelo.Proveedor oProveedor;
        Controladora.ControladoraEstado cEstado;
        string ACCION;
        public New_Orden(Modelo.Orden_Compra miOrden, string miACCION)
        {
            InitializeComponent();
            btn_Imprimir.Visible = false;
            cOrden = Controladora.ControladoraOrdenes.obtener_instancia();
            cDetalleCompra = Controladora.ControladoraDetalle.obtener_instancia();
            cReq = Controladora.Controladora_Req.obtener_instancia();
            cEstado = Controladora.ControladoraEstado.obtener_instancia();

           
            

            oOrden = miOrden;
            ACCION = miACCION;
            if (ACCION != "A")
            {

                textBoxfiltro.Text = oOrden.Proveedor.Razon_Social.ToString();
                textBoxId.Text = oOrden.Id.ToString();
                dtp_FechaLimite.Value = oOrden.Fecha_Limite.Value;
                Fecha.Text = oOrden.Ultima_Modificacion.ToString();
                if (oOrden.Fecha_Limite.Value < DateTime.Now)
                {
                    Add_Item.Visible = false;
                    Delete_Item.Visible = false;
                }
                Filtrar();




            }
        }

        private void Filtrar()
        {
            dgvDetalleCompra.DataSource = null;
            

            dgvDetalleCompra.DataSource = cDetalleCompra.Filtrar(oOrden.Id);
            this.dgvDetalleCompra.Columns["Id"].Visible = false;
            this.dgvDetalleCompra.Columns["Estado"].Visible = false;
            this.dgvDetalleCompra.Columns["Id_Req"].Visible = false;

        } 
        
        private void ArmarGrilla()
        {
            dgvDetalleCompra.DataSource = null;

            dgvDetalleCompra.DataSource = cDetalleCompra.Listar();
            this.dgvDetalleCompra.Columns["Id"].Visible = false;
            this.dgvDetalleCompra.Columns["Estado"].Visible = false;
           // this.dgvDetalleCompra.Columns["Id_Req"].Visible = false;
        }





        DateTime hoy = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            if (frm.dgvProveedores.Rows.Count == 0)
            {
                MessageBox.Show("ATENCIÒN, aun No hay proveedores cargados en el sistema");
                return;
            }

            frm.Size = new Size(500, 450);
            //ofrm.btnCANCELAR.Visible = true;
           
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.btnCANCELAR.Visible = true;
            frm.labeltitulo.Text = "Elegir Proveedor";
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oProveedor = frm.ProvSelec;
                
                if(cOrden.VALIDA_NOMBRE_Proveedor(oProveedor.Razon_Social))
                {
                    if (cOrden.Ultimo(oProveedor.Razon_Social).Estados.Descripcion == "En curso")
                    {

                        MessageBox.Show("Ya hay un Orden para este proveedor");
                        return;

                    }
                   
                }
                
                    if (ACCION == "A")
                {
                    textBoxfiltro.Text = oProveedor.Razon_Social.ToString();
                    Fecha.Text = hoy.ToShortDateString();
                    oOrden.Proveedor = oProveedor;
                    oOrden.Ultima_Modificacion = Convert.ToDateTime(Fecha.Text);
                    oOrden.Estados = cEstado.OBTENER_Estado(1);
                    cOrden.Agregar(oOrden);
                    textBoxId.Text = oOrden.Id.ToString();
                    Add_Item.Enabled = true;
                }
                else
                    textBoxfiltro.Text = oProveedor.Razon_Social.ToString();
                Fecha.Text = hoy.ToShortDateString();
                oOrden.Proveedor = oProveedor;
                oOrden.Ultima_Modificacion = Convert.ToDateTime(Fecha.Text);
                oOrden.Estados = oOrden.Estados;
                cOrden.modificar(oOrden);
                textBoxId.Text = oOrden.Id.ToString();


            }
          



            //Filtrar();
        }

        private void Add_Item_Click(object sender, EventArgs e)
        {
            Requerimientos Frm = new Requerimientos();
            DialogResult dr = Frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                 oReq= Frm.ReqSelec;
                if (ACCION == "M")
                {
                    if (oReq.Articulo.Rubro.Descripcion == oOrden.Proveedor.Rubro.Descripcion)
                    {
                        if (cReq.ValidarFk(oReq.Id_Req) == false)
                        {
                            Modelo.DetalleCompra detalle = new Modelo.DetalleCompra();
                            detalle.Requerimiento = oReq;
                            detalle.Cantidad = oReq.Cantidad.ToString();
                            detalle.Orden_Compra = oOrden;
                            Orden.Agregar(detalle);
                            cDetalleCompra.Agregar(detalle);
                            Filtrar();
                        }
                        else
                            MessageBox.Show("El pedido ya se realizo");
                        return;

                        

                    }
                    else
                    {
                        MessageBox.Show("El pedido corresponde a otro rubro");
                        return;
                    }

                }
                else
                {
                    if (oReq.Articulo.Rubro.Descripcion == oProveedor.Rubro.Descripcion)
                    {
                        if (cReq.ValidarFk(oReq.Id_Req) == false)
                        {
                            Modelo.DetalleCompra detalle = new Modelo.DetalleCompra();
                            detalle.Requerimiento = oReq;
                            detalle.Cantidad = oReq.Cantidad.ToString();
                            detalle.Orden_Compra = oOrden;
                            Orden.Agregar(detalle);
                            cDetalleCompra.Agregar(detalle);
                            Filtrar();
                        }
                        else
                            MessageBox.Show("El pedido ya se realizo");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El pedido corresponde a otro rubro");
                        return;
                    }
                }
               
               

            }
           

            Filtrar();

            
        }

        private void ARMA_DETALLE()
        {
            dgvDetalleCompra.DataSource = null;
            dgvDetalleCompra.DataSource = cDetalleCompra.Listar();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ACCION == "M")
            {
                oOrden.Ultima_Modificacion = Convert.ToDateTime(Fecha.Text);
                oOrden.Fecha_Limite = Convert.ToDateTime(dtp_FechaLimite.Value);
                cOrden.modificar(oOrden);
            }
            else
            {
                oOrden.Fecha_Limite = Convert.ToDateTime(dtp_FechaLimite.Value);
                cOrden.modificar(oOrden);
            }

           
            MessageBox.Show("Orden Guardada");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Lista_Ordenes Frm = new Lista_Ordenes();
            if (ACCION == "M")
            {
                if (dgvDetalleCompra.Rows.Count == 0)
                {
                    

                    MessageBox.Show("La orden se elimino por no tener ningun item de compra");
                    cOrden.Eliminar(oOrden);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                }
            }
            if (ACCION == "A")
            {
                if (dgvDetalleCompra.Rows.Count == 0)
                {   if (textBoxfiltro.Text == "")
                    {
                        this.Close();
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    cOrden.Eliminar(oOrden);

                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
           
            this.Close();
            //Frm.ARMA_GRILLA();
        }

        private void Delete_Item_Click(object sender, EventArgs e)
        {
            if (dgvDetalleCompra.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Rubro de la lista", "ATENCION!!");
                return;
            }
            Modelo.DetalleCompra oDetalle = cDetalleCompra.OBTENER(Convert.ToInt32(dgvDetalleCompra.CurrentRow.Cells[0].Value));

            DialogResult dr = MessageBox.Show("¿Confirma que desea anular el Proveedor " + oDetalle.Requerimiento.Articulo.Descripcion + "?", "ELIMINAR Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {

                cDetalleCompra.Eliminar(oDetalle);
                Filtrar();
                
            }
        }

        private void New_Orden_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Orden De Compra";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Autocredito";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvDetalleCompra);
        }

        private void Imprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
           
        }
    }
}
