namespace Autocred
{
    partial class New_Orden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Orden));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxfiltro = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.btn_AddProv = new System.Windows.Forms.Button();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.Add_Item = new System.Windows.Forms.Button();
            this.Delete_Item = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_FechaLimite = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Imprimir = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ultima Mod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nª Orden";
            // 
            // textBoxfiltro
            // 
            this.textBoxfiltro.Location = new System.Drawing.Point(74, 37);
            this.textBoxfiltro.Name = "textBoxfiltro";
            this.textBoxfiltro.Size = new System.Drawing.Size(214, 20);
            this.textBoxfiltro.TabIndex = 4;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(74, 69);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(214, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(74, 108);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(214, 20);
            this.Fecha.TabIndex = 6;
            this.Fecha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_AddProv
            // 
            this.btn_AddProv.Location = new System.Drawing.Point(294, 36);
            this.btn_AddProv.Name = "btn_AddProv";
            this.btn_AddProv.Size = new System.Drawing.Size(38, 20);
            this.btn_AddProv.TabIndex = 7;
            this.btn_AddProv.Text = "Q";
            this.btn_AddProv.UseVisualStyleBackColor = true;
            this.btn_AddProv.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(48, 210);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDetalleCompra.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(240, 150);
            this.dgvDetalleCompra.TabIndex = 8;
            // 
            // Add_Item
            // 
            this.Add_Item.Location = new System.Drawing.Point(187, 189);
            this.Add_Item.Name = "Add_Item";
            this.Add_Item.Size = new System.Drawing.Size(38, 20);
            this.Add_Item.TabIndex = 9;
            this.Add_Item.Text = "+";
            this.Add_Item.UseVisualStyleBackColor = true;
            this.Add_Item.Click += new System.EventHandler(this.Add_Item_Click);
            // 
            // Delete_Item
            // 
            this.Delete_Item.Location = new System.Drawing.Point(231, 189);
            this.Delete_Item.Name = "Delete_Item";
            this.Delete_Item.Size = new System.Drawing.Size(38, 20);
            this.Delete_Item.TabIndex = 10;
            this.Delete_Item.Text = "-";
            this.Delete_Item.UseVisualStyleBackColor = true;
            this.Delete_Item.Click += new System.EventHandler(this.Delete_Item_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(153, 366);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(49, 20);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(231, 366);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(38, 20);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(31, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Orden de Compra";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtp_FechaLimite
            // 
            this.dtp_FechaLimite.Location = new System.Drawing.Point(74, 143);
            this.dtp_FechaLimite.Name = "dtp_FechaLimite";
            this.dtp_FechaLimite.Size = new System.Drawing.Size(214, 20);
            this.dtp_FechaLimite.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(7, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha Limite";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(213, 337);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_Imprimir.TabIndex = 30;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Imprimir
            // 
            this.Imprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir_PrintPage);
            // 
            // New_Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(335, 398);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_FechaLimite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Delete_Item);
            this.Controls.Add(this.Add_Item);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.btn_AddProv);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxfiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_Orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Orden";
            this.Load += new System.EventHandler(this.New_Orden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxfiltro;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.Button Delete_Item;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Button btn_AddProv;
        public System.Windows.Forms.Button Add_Item;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_FechaLimite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument Imprimir;
    }
}