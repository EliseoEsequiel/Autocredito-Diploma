namespace Autocred
{
    partial class OrdenDeCompra_Estados
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
            this.rdb_Cerrado = new System.Windows.Forms.RadioButton();
            this.rdb_Pendiente = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPendiente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendiente)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_Cerrado
            // 
            this.rdb_Cerrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_Cerrado.Location = new System.Drawing.Point(42, 43);
            this.rdb_Cerrado.Name = "rdb_Cerrado";
            this.rdb_Cerrado.Size = new System.Drawing.Size(151, 17);
            this.rdb_Cerrado.TabIndex = 3;
            this.rdb_Cerrado.TabStop = true;
            this.rdb_Cerrado.Text = "Cerrado con Faltante";
            this.rdb_Cerrado.UseVisualStyleBackColor = true;
            // 
            // rdb_Pendiente
            // 
            this.rdb_Pendiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_Pendiente.Location = new System.Drawing.Point(42, 12);
            this.rdb_Pendiente.Name = "rdb_Pendiente";
            this.rdb_Pendiente.Size = new System.Drawing.Size(186, 25);
            this.rdb_Pendiente.TabIndex = 2;
            this.rdb_Pendiente.Text = "Pendiente Con Faltante";
            this.rdb_Pendiente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPendiente
            // 
            this.dgvPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendiente.Location = new System.Drawing.Point(204, 13);
            this.dgvPendiente.Name = "dgvPendiente";
            this.dgvPendiente.Size = new System.Drawing.Size(147, 80);
            this.dgvPendiente.TabIndex = 5;
            this.dgvPendiente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendiente_CellContentDoubleClick);
            // 
            // OrdenDeCompra_Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 115);
            this.Controls.Add(this.dgvPendiente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdb_Cerrado);
            this.Controls.Add(this.rdb_Pendiente);
            this.Name = "OrdenDeCompra_Estados";
            this.Text = "OrdenDeCompra_Estados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendiente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Cerrado;
        private System.Windows.Forms.RadioButton rdb_Pendiente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPendiente;
    }
}