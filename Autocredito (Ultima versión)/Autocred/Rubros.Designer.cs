namespace Autocred
{
    partial class Rubros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rubros));
            this.dgvRubros = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnBAJAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnALTAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRubros
            // 
            this.dgvRubros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvRubros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRubros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubros.Location = new System.Drawing.Point(306, 126);
            this.dgvRubros.Name = "dgvRubros";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRubros.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRubros.Size = new System.Drawing.Size(152, 191);
            this.dgvRubros.TabIndex = 0;
            this.dgvRubros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubros_CellContentDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(330, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(301, 42);
            this.label1.MaximumSize = new System.Drawing.Size(200, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Gestionar Rubros";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(388, 323);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(70, 60);
            this.btnCANCELAR.TabIndex = 47;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click_1);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("btnGUARDAR.Image")));
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(306, 323);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(67, 60);
            this.btnGUARDAR.TabIndex = 46;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnBAJAS
            // 
            this.btnBAJAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBAJAS.FlatAppearance.BorderSize = 0;
            this.btnBAJAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBAJAS.Image = ((System.Drawing.Image)(resources.GetObject("btnBAJAS.Image")));
            this.btnBAJAS.Location = new System.Drawing.Point(464, 192);
            this.btnBAJAS.Name = "btnBAJAS";
            this.btnBAJAS.Size = new System.Drawing.Size(91, 60);
            this.btnBAJAS.TabIndex = 34;
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
            this.btnMODIFICACIONES.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICACIONES.Image")));
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(464, 257);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 35;
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
            this.btnALTAS.Image = ((System.Drawing.Image)(resources.GetObject("btnALTAS.Image")));
            this.btnALTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnALTAS.Location = new System.Drawing.Point(464, 126);
            this.btnALTAS.Name = "btnALTAS";
            this.btnALTAS.Size = new System.Drawing.Size(93, 60);
            this.btnALTAS.TabIndex = 33;
            this.btnALTAS.Text = "&Agregar";
            this.btnALTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnALTAS.UseVisualStyleBackColor = true;
            this.btnALTAS.Click += new System.EventHandler(this.btnALTAS_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(413, 84);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(30, 20);
            this.btnBUSCAR.TabIndex = 32;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // Rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(870, 609);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBAJAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnALTAS);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvRubros);
            this.Name = "Rubros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rubros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCANCELAR;
        public System.Windows.Forms.Button btnGUARDAR;
        public System.Windows.Forms.DataGridView dgvRubros;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnBUSCAR;
        public System.Windows.Forms.Button btnBAJAS;
        public System.Windows.Forms.Button btnMODIFICACIONES;
        public System.Windows.Forms.Button btnALTAS;
    }
}