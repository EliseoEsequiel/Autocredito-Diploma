using FontAwesome.Sharp;
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
    public partial class Form_Princ : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        Modelo.Usuario oUser;
        int count = 0;
        public Form_Princ(Modelo.Usuario USER)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelSideMenu.Controls.Add(leftBorderBtn);
            hideSubMenu();
            oUser = USER;
            labelContador.Visible = false;
            foreach (var comentario in Modelo.SingletonContexto.obtener_instancia().Contexto.ComentariosSet)
            {
                
                if (comentario.Estado == false)
                {
                    //count++;

                    Form_Alert frm = new Form_Alert(comentario.Articulo, comentario);
                    Nota = comentario.Descripcion;
                    frm.showAlert(Nota, Form_Alert.enmType.Success);
                    //his.pasar_datos();
                }
            }
            Contar();
            if (oUser.Grupo.Descripcion == "Deposito")
            {
                btnHelp.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                panel2.Visible = false;



            }

            if (oUser.Grupo.Descripcion == "Compras")
            {
                btn_Remito.Visible = false;
               button3.Visible = false;
                panel2.Visible = false;

            }

        }


        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //public void Alert(string msg, Form_Alert.enmType type)
        //{
        //    Form_Alert frm = new Form_Alert();
        //    frm.showAlert(msg, type);
        //}
        public void Contar()
        {
            if (count > 0)
            {
                labelContador.Visible = true;
                labelContador.Text = count.ToString();
            }
           
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //iconCurrentChildForm.IconChar = IconChar.Home;
            //iconCurrentChildForm.IconColor = Color.MediumPurple;
            //lblTitleChildForm.Text = "Home";
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            //panelToolsSubMenu.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btn_Orden_Click(object sender, EventArgs e)
        {
            openChildForm(new Lista_Ordenes());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        string Nota;
        private void btn_Req_Click(object sender, EventArgs e)
        {

            openChildForm(new Requerimientos());       
            //your codes
            //..
            hideSubMenu();
        }

        private void btn_Art_Click(object sender, EventArgs e)
        {
            openChildForm(new Articulos());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void Form_Princ_Load(object sender, EventArgs e)
        {

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            openChildForm(new ControlStock());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUsuarios());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void cmdEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Rubros());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Proveedores());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Grupos());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Width == 250)
            {
                panelSideMenu.Width = 75;

            }
            else
                panelSideMenu.Width = 250;           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else{
                this.WindowState = FormWindowState.Normal;
            }
           


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color2);
            Reset();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btn_Remito_Click(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }

        private void btn_GestRemitos_Click(object sender, EventArgs e)
        {
            openChildForm(new Remitos());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Estados());
            //..
            //your codes
            //..
            hideSubMenu();
        }
    }
}
