﻿using System;
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
    public partial class Comentarios : Form
    {
        public Comentarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
