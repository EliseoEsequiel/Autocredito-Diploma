namespace Autocred
{
    partial class Remito
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.btn_AddProv = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxfiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(261, 342);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(38, 20);
            this.btn_Exit.TabIndex = 25;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(206, 342);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(49, 20);
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(28, 186);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDetalleCompra.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(354, 150);
            this.dgvDetalleCompra.TabIndex = 21;
            this.dgvDetalleCompra.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvDetalleCompra_ColumnAdded);
            this.dgvDetalleCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetalleCompra_KeyDown);
            // 
            // btn_AddProv
            // 
            this.btn_AddProv.Location = new System.Drawing.Point(344, 65);
            this.btn_AddProv.Name = "btn_AddProv";
            this.btn_AddProv.Size = new System.Drawing.Size(38, 20);
            this.btn_AddProv.TabIndex = 20;
            this.btn_AddProv.Text = "Q";
            this.btn_AddProv.UseVisualStyleBackColor = true;
            this.btn_AddProv.Click += new System.EventHandler(this.btn_AddProv_Click);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(245, 97);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(137, 20);
            this.Fecha.TabIndex = 19;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(87, 97);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(97, 20);
            this.textBoxId.TabIndex = 18;
            // 
            // textBoxfiltro
            // 
            this.textBoxfiltro.Location = new System.Drawing.Point(87, 65);
            this.textBoxfiltro.Name = "textBoxfiltro";
            this.textBoxfiltro.Size = new System.Drawing.Size(251, 20);
            this.textBoxfiltro.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nª Orden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(203, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(147, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 43);
            this.label5.TabIndex = 26;
            this.label5.Text = "Remito";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(422, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.btn_AddProv);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxfiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Remito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remito";
            this.Load += new System.EventHandler(this.Remito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        public System.Windows.Forms.Button btn_AddProv;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxfiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}