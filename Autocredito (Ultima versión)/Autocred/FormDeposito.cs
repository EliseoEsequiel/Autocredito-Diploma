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
    public partial class FormDeposito : Form
    {
        public FormDeposito()
        {
            InitializeComponent();
        }

        private void btn_Req_Click(object sender, EventArgs e)
        {
            Form Requerimientos = new Requerimientos();
            Requerimientos.Show();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Form ControlStock = new ControlStock();
            ControlStock.Show();
        }
        private void cmdEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
