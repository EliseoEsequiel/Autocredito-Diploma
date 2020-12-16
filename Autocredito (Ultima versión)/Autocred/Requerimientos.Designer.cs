namespace Autocred
{
    partial class Requerimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requerimientos));
            this.dgvRequerimientos = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnBAJAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnALTAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequerimientos
            // 
            this.dgvRequerimientos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvRequerimientos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRequerimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequerimientos.Location = new System.Drawing.Point(95, 76);
            this.dgvRequerimientos.Name = "dgvRequerimientos";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRequerimientos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequerimientos.Size = new System.Drawing.Size(403, 303);
            this.dgvRequerimientos.TabIndex = 0;
            this.dgvRequerimientos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequerimientos_CellContentDoubleClick);
            this.dgvRequerimientos.DoubleClick += new System.EventHandler(this.dgvRequerimientos_DoubleClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.Location = new System.Drawing.Point(622, 8);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(34, 31);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Exit";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(223, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(223, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.MaximumSize = new System.Drawing.Size(200, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "Gestionar Pedidos";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(351, 50);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(30, 20);
            this.btnBUSCAR.TabIndex = 39;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnBAJAS
            // 
            this.btnBAJAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBAJAS.FlatAppearance.BorderSize = 0;
            this.btnBAJAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBAJAS.Image = global::Autocred.Properties.Resources.icon_folder_remove;
            this.btnBAJAS.Location = new System.Drawing.Point(518, 264);
            this.btnBAJAS.Name = "btnBAJAS";
            this.btnBAJAS.Size = new System.Drawing.Size(91, 76);
            this.btnBAJAS.TabIndex = 37;
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
            this.btnMODIFICACIONES.Image = global::Autocred.Properties.Resources.icon_folder_edit;
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(518, 176);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 71);
            this.btnMODIFICACIONES.TabIndex = 38;
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
            this.btnALTAS.Image = global::Autocred.Properties.Resources.icon_folder_add;
            this.btnALTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnALTAS.Location = new System.Drawing.Point(518, 91);
            this.btnALTAS.Name = "btnALTAS";
            this.btnALTAS.Size = new System.Drawing.Size(91, 70);
            this.btnALTAS.TabIndex = 36;
            this.btnALTAS.Text = "&Agregar";
            this.btnALTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnALTAS.UseVisualStyleBackColor = true;
            this.btnALTAS.Click += new System.EventHandler(this.btnALTAS_Click);
            // 
            // Requerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(668, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnBAJAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnALTAS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgvRequerimientos);
            this.Name = "Requerimientos";
            this.Text = "Requerimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequerimientos;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBAJAS;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnALTAS;
        public System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label label1;
    }
}