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
    public partial class Remito : Form
    {
        Modelo.Proveedor oProveedor;
        Modelo.Remitos oRemito;
        Modelo.Articulo oArt;
        Controladora.controladora_Articulos cArt;
        Modelo.Orden_Compra orden;
        Controladora.ControladoraDetalle cDetalleCompra;
        Modelo.DetalleCompra detalle;
        Controladora.ControladoraOrdenes cOrden;
        Modelo.Comentarios oComentario;
        Controladora.controladora_Comentarios cComentario;
        Controladora.ControladoraEstado cEstado;
        Modelo.Requerimiento Requerimiento;
        Controladora.ControladoraProveedor cProveedor;
        Controladora.ControladoraRemitos cRemito;
        Controladora.Controladora_Req cReq;
        string ACCION;
        public Remito(Modelo.Remitos miOrden, string miACCION)
        {
            InitializeComponent();
            cDetalleCompra = Controladora.ControladoraDetalle.obtener_instancia();
            cRemito = Controladora.ControladoraRemitos.obtener_instancia();
            cComentario = Controladora.controladora_Comentarios.obtener_instancia();
            cArt = Controladora.controladora_Articulos.obtener_instancia();
            cEstado = Controladora.ControladoraEstado.obtener_instancia();
            cReq = Controladora.Controladora_Req.obtener_instancia();
            cProveedor = Controladora.ControladoraProveedor.obtener_instancia();
            cOrden = Controladora.ControladoraOrdenes.obtener_instancia();
            oRemito = miOrden;
            ACCION = miACCION;
            if (ACCION != "A")
            {


                textBoxfiltro.Text = oRemito.Orden_Compra.Proveedor.Razon_Social.ToString();
                textBoxfiltro.Enabled = false;

                Fecha.Text = oRemito.Fecha.ToString();
                Fecha.ReadOnly = true;

                //orden = cOrden.Asociar(textBoxfiltro.Text);
                textBoxId.Text = oRemito.Orden_Compra.Id.ToString();

                textBoxId.ReadOnly = true;
                Filtrar();
                //dgvDetalleCompra_SelectionChanged();




            }
        }

        private void Filtrar()
        {
            dgvDetalleCompra.DataSource = null;

           
            dgvDetalleCompra.DataSource = cDetalleCompra.Filtrar(oRemito.Orden_Compra.Id);
          // dgvDetalleCompra.Columns[3].ReadOnly = false;
            this.dgvDetalleCompra.Columns["Id"].Visible = false;
            this.dgvDetalleCompra.Columns["Id_Req"].Visible = false;
            this.dgvDetalleCompra.Columns["Id_Art"].Visible = false;

        }

        private void btn_AddProv_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();

            frm.Size = new Size(500, 450);

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.labeltitulo.Text = "Elegir Proveedor";
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oProveedor = frm.ProvSelec;
                if (cProveedor.ValidarFk(oProveedor.Id))
                {
                    if (cOrden.Asociar(oProveedor.Razon_Social).Estados.Descripcion == "En curso")
                    {
                        textBoxfiltro.Text = oProveedor.Razon_Social.ToString();
                        Fecha.Text = hoy.ToShortDateString();
                        orden = cOrden.Asociar(textBoxfiltro.Text);
                        textBoxId.Text = orden.Id.ToString();
                        oRemito.Fecha = Convert.ToDateTime(Fecha.Text);
                        oRemito.Orden_Compra = orden;
                        cRemito.Agregar(oRemito);
                        Filtrar();
                    }
                    else
                    {
                        MessageBox.Show("La Orden para " + oProveedor.Razon_Social + " ya  se cerro y posee su remito correspondiente");
                        return;
                    }

                }
                else
                    MessageBox.Show("No hay ninguna orden para " + oProveedor.Razon_Social);
                return;
                   
                
            }
            
        }
        DateTime hoy = DateTime.Now;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow F in dgvDetalleCompra.Rows)
            {
                int cod;
                Estado = Convert.ToBoolean(F.Cells["Estado"].Value);
                if (Estado == true)
                {
                    cod = Convert.ToInt32(F.Cells[4].Value);
                    Requerimiento = cReq.OBTENER(cod);
                    Requerimiento.Estado = true;
                    cReq.modificarRequerimiento(Requerimiento);
                }
            }*/
            bool Estado;
            foreach (DataGridViewRow F in dgvDetalleCompra.Rows)
            {
                int cod;
                int cantidad;
                int resultado;
                Estado = Convert.ToBoolean(F.Cells["Estado"].Value);
                if (Estado == true)
                {
                    cod = Convert.ToInt32(F.Cells["Id_Req"].Value);
                    cantidad = Convert.ToInt32(F.Cells[1].Value);
                    oArt = cArt.OBTENER_ARTICULO(Convert.ToInt32(F.Cells["Id_Art"].Value));
                    Requerimiento = cReq.OBTENER(cod);

                    if (ACCION == "M")
                    {
                        oArt.Stock = (oArt.Stock - Convert.ToInt32(cDetalleCompra.OBTENER(Convert.ToInt32(F.Cells["Id"].Value)).Cantidad)) + cantidad;
                        oArt.Pendientes = oArt.Pendientes - cantidad;
                        //cReq.modificarRequerimiento(Requerimiento);
                        //cArt.modificarArticulos(oArt);
                    }
                    if (ACCION == "A")
                    {
                        oArt.Stock = oArt.Stock + cantidad;
                        oArt.Pendientes = oArt.Pendientes - cantidad;
                       // cReq.modificarRequerimiento(Requerimiento);
                       // cArt.modificarArticulos(oArt);
                    }
                    Requerimiento.Estado = Estado;
                    if (Requerimiento.Cantidad > cantidad)
                    {

                        Modelo.Comentarios oComentario = new Modelo.Comentarios();
                        resultado = Requerimiento.Cantidad - cantidad;
                        Requerimiento.Cantidad = cantidad;
                        oComentario.Faltantes = resultado;
                        oComentario.Articulo = Requerimiento.Articulo;
                        oComentario.Estado = false;
                        oComentario.Descripcion = "Faltan "+resultado+" unidad/es del articulo "+Requerimiento.Articulo.Descripcion;
                        cComentario.Agregar(oComentario);
                        cReq.modificarRequerimiento(Requerimiento);
                        cArt.modificarArticulos(oArt);
                    }
                    else
                    Requerimiento.Cantidad = cantidad;
                    cReq.modificarRequerimiento(Requerimiento);
                    cArt.modificarArticulos(oArt);

                }
                else
                {
                    cod = Convert.ToInt32(F.Cells[4].Value);
                    Requerimiento = cReq.OBTENER(cod);
                    Requerimiento.Estado = Estado;
                    Modelo.Comentarios oComentario = new Modelo.Comentarios();
                    cantidad = Convert.ToInt32(F.Cells[1].Value);
                    
                    
                    oComentario.Faltantes = cantidad;
                    oComentario.Articulo = Requerimiento.Articulo;
                    oComentario.Estado = false;
                    oComentario.Descripcion = "Faltan " + cantidad + " unidad/es del articulo " + Requerimiento.Articulo.Descripcion;
                    cComentario.Agregar(oComentario);
                    //Requerimiento.Cantidad = Convert.ToInt32(F.Cells[1].Value);
                    cReq.modificarRequerimiento(Requerimiento);
                }                
            }
            
            
            

            Int32 Contador = 0;
            Int32 ContadorPositivo = 0;
            Int32 ContadorNegativo = 0;
            
            foreach (DataGridViewRow F in dgvDetalleCompra.Rows)
            {
                Int32 Llego;
                Contador = Contador + 1;
                //Llego = Convert.ToInt32(F.Cells[1].Value);
                // bool Estado;
                Estado = Convert.ToBoolean(F.Cells["Estado"].Value);
                if (Estado == true)
                {
                    ContadorPositivo = ContadorPositivo + 1;
                }

                if (Estado == false)
                {
                    ContadorNegativo = ContadorNegativo + 1;
                }
            }           

            if (Contador == ContadorPositivo){
                //Llego = Convert.ToInt32(F.Cells[1].Value);
                if (ACCION == "A")
                {
                   
                   
                    orden = cOrden.Asociar(textBoxfiltro.Text);
                    orden.Estados = cEstado.OBTENER_Estado(3);
                    cOrden.modificar(orden);
                    MessageBox.Show("Orden cerrada");
                }
                else
                {
                    orden = oRemito.Orden_Compra;
                    orden.Estados = cEstado.OBTENER_Estado(3);
                    cOrden.modificar(orden);
                    MessageBox.Show("Orden cerrada");
                }

               
            }
            else if (Contador == ContadorNegativo)
            {
                if (ACCION == "A")
                {

                    OrdenDeCompra_Estados frm = new OrdenDeCompra_Estados("Buscar");
                    //frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Show();
                    orden = cOrden.Asociar(textBoxfiltro.Text);
                    orden.Estados = cEstado.OBTENER_Estado(1);
                    cOrden.modificar(orden);
                    //MessageBox.Show("Orden abierta");
                }
                else
                {

                    //OrdenDeCompra_Estados frm = new OrdenDeCompra_Estados();
                    //frm.FormBorderStyle = FormBorderStyle.None;
                    //frm.Show();

                    OrdenDeCompra_Estados frm = new OrdenDeCompra_Estados("Buscar");
                    frm.Size = new Size(646, 382);
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    orden = oRemito.Orden_Compra;
                    DialogResult dr = frm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        orden.Estados = frm.ArticuloSelec;
                    }
                       
                    //orden.Estados = cEstado.OBTENER_Estado(1);
                    cOrden.modificar(orden);
                    //MessageBox.Show("Orden abierta");
                }
                  
            }
            else
            {
                if (ACCION == "A")
                {
                    orden = cOrden.Asociar(textBoxfiltro.Text);
                    orden.Estados = cEstado.OBTENER_Estado(2);
                    cOrden.modificar(orden);
                    MessageBox.Show("Orden abierta");
                }

                else
                {
                    orden = oRemito.Orden_Compra;
                    orden.Estados = cEstado.OBTENER_Estado(2);
                    cOrden.modificar(orden);
                    MessageBox.Show("Orden Parcial");
                }

                
            }
           

            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Remito_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn c in dgvDetalleCompra.Columns)
                if (c.Name != "Estado" && c.Name != "Cantidad") c.ReadOnly = true;
           
        }

        /*private void dgvDetalleCompra_SelectionChanged(object sender, EventArgs e)
        {
        

            dgvDetalleCompra.CurrentCell = dgvDetalleCompra.CurrentRow.Cells["Estado"];
           // dgvDetalleCompra.CurrentCell = dgvDetalleCompra.CurrentRow.Cells["Cantidad"];

            dgvDetalleCompra.BeginEdit(true);

            
        }*/

        private void dgvDetalleCompra_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dgvDetalleCompra_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Comentarios comentarios = new Comentarios();
        //    comentarios.Show();
        //}
    }
        
   
}

