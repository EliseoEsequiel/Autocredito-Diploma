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
    public partial class formComun : Form
    {
        public formComun()
        {
            InitializeComponent();
        }

        private void btn_Req_Click(object sender, EventArgs e)
        {
            Form Requerimientos = new Requerimientos();
            Requerimientos.Show();
        }

        private void cmdEXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
