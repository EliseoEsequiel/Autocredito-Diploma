namespace Autocred
{
    partial class Grupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupos));
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.btn_Modified = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvGrupos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(191, 115);
            this.dgvGrupos.Name = "dgvGrupos";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGrupos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupos.Size = new System.Drawing.Size(218, 216);
            this.dgvGrupos.TabIndex = 0;
            this.dgvGrupos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellContentDoubleClick);
            // 
            // btn_Modified
            // 
            this.btn_Modified.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Modified.FlatAppearance.BorderSize = 0;
            this.btn_Modified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modified.Image = global::Autocred.Properties.Resources.Grupoedit__1_;
            this.btn_Modified.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Modified.Location = new System.Drawing.Point(421, 184);
            this.btn_Modified.Name = "btn_Modified";
            this.btn_Modified.Size = new System.Drawing.Size(60, 72);
            this.btn_Modified.TabIndex = 7;
            this.btn_Modified.Text = "Modified";
            this.btn_Modified.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Modified.UseVisualStyleBackColor = true;
            this.btn_Modified.Click += new System.EventHandler(this.btn_Modified_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Autocred.Properties.Resources.deletegroup__1_;
            this.button2.Location = new System.Drawing.Point(421, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 78);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Autocred.Properties.Resources.Actions_user_group_new_icon;
            this.button1.Location = new System.Drawing.Point(421, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(218, 25);
            this.label1.MaximumSize = new System.Drawing.Size(200, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Gestionar Grupos";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(337, 77);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(30, 20);
            this.btnBUSCAR.TabIndex = 38;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(254, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 37;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(313, 337);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(70, 60);
            this.btnCANCELAR.TabIndex = 49;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("btnGUARDAR.Image")));
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(231, 337);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(67, 60);
            this.btnGUARDAR.TabIndex = 48;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(668, 482);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Modified);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "Grupos";
            this.Text = "Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Button btn_Modified;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBUSCAR;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnCANCELAR;
        public System.Windows.Forms.Button btnGUARDAR;
    }
}