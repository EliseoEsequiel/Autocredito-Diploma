//using CustomAlertBoxDemo.Properties;
using Autocred.Properties;
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
    public partial class Form_Alert : Form
    {
        Modelo.Articulo Art;
        Modelo.Comentarios Comentario;
        Controladora.Controladora_Req cReq;
        Controladora.controladora_Comentarios cComentarios;
       

        public Form_Alert(Modelo.Articulo Articulo, Modelo.Comentarios comentario)
        {
            InitializeComponent();
            cReq = Controladora.Controladora_Req.obtener_instancia();
            cComentarios = Controladora.controladora_Comentarios.obtener_instancia();
            Art = Articulo;
            Comentario = comentario;


        }

        //public Form_Alert()
        //{
        //}

        public enum enmAction
        {
            wait,
            start,
            close,
            Frm
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private Form_Alert.enmAction action;

        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 50000;
                    action = enmAction.close;
                    break;
                case Form_Alert.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Form_Alert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
                case enmAction.Frm:
                    timer1.Interval = 1;
                    
                    New_Item Frm = new New_Item();
                    Frm.Show();
                    break;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 1;
            DialogResult dr = MessageBox.Show("Esta seguro de eliminar este comentario","Confirmar?", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                cComentarios.Eliminar(Comentario); 

            }
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //New_Item newItem = new New_Item(new Modelo.Requerimiento(), "A");
            //newItem.FormBorderStyle = FormBorderStyle.None;
            //DialogResult dr = newItem.ShowDialog();
            //if (dr == System.Windows.Forms.DialogResult.OK)
            //    this.Close();
            DialogResult dr = MessageBox.Show("¿Confirma  el pedido de " + Comentario.Faltantes + " unidad del articulo" + Comentario.Articulo.Descripcion + "?", "Confirmar", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Modelo.Requerimiento Requerimiento = new Modelo.Requerimiento();
                Requerimiento.Cantidad = Comentario.Faltantes;
                Requerimiento.Fecha = DateTime.Now;
                Requerimiento.Estado = false;
                Requerimiento.Articulo = Comentario.Articulo;
                Comentario.Estado = true;

                cComentarios.Modificar(Comentario);
               cReq.Agregar_Requerimiento(Requerimiento);            
            }
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {
            
        }

        public void pasar_datos(Modelo.Articulo articulo, Modelo.Comentarios comentario)
        {
           
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            /*this.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width - 300,
                Screen.PrimaryScreen.Bounds.Height
                );*/
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch(type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lblMsg.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
