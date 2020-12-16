namespace Autocred
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.btnBAJAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnALTAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(244, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "Razon Social";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(95, 144);
            this.dgvProveedores.Name = "dgvProveedores";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.Size = new System.Drawing.Size(443, 229);
            this.dgvProveedores.TabIndex = 36;
            this.dgvProveedores.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvProveedores_ColumnAdded);
            this.dgvProveedores.DoubleClick += new System.EventHandler(this.dgvProveedores_DoubleClick);
            // 
            // labeltitulo
            // 
            this.labeltitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labeltitulo.BackColor = System.Drawing.Color.Transparent;
            this.labeltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labeltitulo.Location = new System.Drawing.Point(184, 39);
            this.labeltitulo.MaximumSize = new System.Drawing.Size(500, 300);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(250, 50);
            this.labeltitulo.TabIndex = 42;
            this.labeltitulo.Text = "Gestionar Proveedores";
            // 
            // btnBAJAS
            // 
            this.btnBAJAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBAJAS.FlatAppearance.BorderSize = 0;
            this.btnBAJAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBAJAS.Image = global::Autocred.Properties.Resources.deleteuserbusnes__1_;
            this.btnBAJAS.Location = new System.Drawing.Point(557, 299);
            this.btnBAJAS.Name = "btnBAJAS";
            this.btnBAJAS.Size = new System.Drawing.Size(91, 84);
            this.btnBAJAS.TabIndex = 40;
            this.btnBAJAS.Text = "&Eliminar";
            this.btnBAJAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBAJAS.UseVisualStyleBackColor = true;
            this.btnBAJAS.Click += new System.EventHandler(this.btnBAJAS_Click);
            // 
            // btnMODIFICACIONES
            // 
            this.btnMODIFICACIONES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMODIFICACIONES.FlatAppearance.BorderSize = 0;
            this.btnMODIFICACIONES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMODIFICACIONES.Image = global::Autocred.Properties.Resources.edituserbisnes__1_;
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(557, 223);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 70);
            this.btnMODIFICACIONES.TabIndex = 41;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // btnALTAS
            // 
            this.btnALTAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnALTAS.FlatAppearance.BorderSize = 0;
            this.btnALTAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnALTAS.Image = global::Autocred.Properties.Resources.userbissnesadd__1_;
            this.btnALTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnALTAS.Location = new System.Drawing.Point(557, 144);
            this.btnALTAS.Name = "btnALTAS";
            this.btnALTAS.Size = new System.Drawing.Size(93, 73);
            this.btnALTAS.TabIndex = 39;
            this.btnALTAS.Text = "&Agregar";
            this.btnALTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnALTAS.UseVisualStyleBackColor = true;
            this.btnALTAS.Click += new System.EventHandler(this.btnALTAS_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(349, 108);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(30, 20);
            this.btnBUSCAR.TabIndex = 38;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(480, 327);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(58, 46);
            this.btnCANCELAR.TabIndex = 48;
            this.btnCANCELAR.Text = "Exit";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(668, 482);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.btnBAJAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnALTAS);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvProveedores);
            this.Name = "Proveedores";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBAJAS;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnALTAS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label labeltitulo;
        public System.Windows.Forms.Button btnCANCELAR;
        public System.Windows.Forms.DataGridView dgvProveedores;
    }
}