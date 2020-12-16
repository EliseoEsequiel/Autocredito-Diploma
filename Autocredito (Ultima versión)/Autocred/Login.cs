using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Autocred
{
    public partial class Login : Form
    {
        Controladora.controladoraLogin cLOGIN;
        Modelo.Usuario oUSUARIO;

        public Login()
        {
            cLOGIN = Controladora.controladoraLogin.obtener_instancia();
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        int Contador = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            lblMENSAJE_LOGIN.Text = "";
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                lblMENSAJE_LOGIN.Text = "Debe ingresar el nombre de usuario";
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblMENSAJE_LOGIN.Text = "Debe ingresar la contraseña del usuario";
                return;
            }
            /*oUSUARIO = cLOGIN.VALIDAR_USUARIO(textBox1.Text, textBox2.Text);


            if(oUSUARIO.Rol == "Admin")
            {
                Form_Princ Principal = new Form_Princ();
                Principal.Show();
            }

            if (oUSUARIO.Rol == "Deposito")
            {
                FormDeposito Deposito = new FormDeposito();
                Deposito.Show();
            }

            if (oUSUARIO.Rol == "Comun")
            {
                formComun Comun = new formComun();
                Comun.Show();
            }*/
            if (Contador < 3)
            {
                try
                {
                    oUSUARIO = cLOGIN.VALIDAR_USUARIO(txtUsuario.Text, txtPassword.Text);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    if (oUSUARIO.Grupo.Descripcion == "Admin")
                    {
                        Form_Princ Principal = new Form_Princ(oUSUARIO);
                        this.Hide();
                        
                        Principal.Show();

                        
                    }

                    if (oUSUARIO.Grupo.Descripcion == "Deposito")
                    {
                        Form_Princ Principal = new Form_Princ(oUSUARIO);
                        this.Hide();

                        Principal.Show();



                    }

                    if (oUSUARIO.Grupo.Descripcion == "Compras")
                    {
                        Form_Princ Principal = new Form_Princ(oUSUARIO);
                        this.Hide();

                        Principal.Show();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Contador++;

                }
            }
            //else
            if (Contador == 3)
            {
                txtPassword.Visible = false;
                MessageBox.Show("USUARIO BLOQUEADO, POR FAVOR CONTACTESE CON EL ADMINISTRADOR");
                btnAceptar.Enabled = false;
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}