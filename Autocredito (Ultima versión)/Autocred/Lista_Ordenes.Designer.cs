namespace Autocred
{
    partial class Lista_Ordenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Ordenes));
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxfiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBAJAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnALTAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvOrdenes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(174, 76);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(372, 350);
            this.dgvOrdenes.TabIndex = 2;
            this.dgvOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.MaximumSize = new System.Drawing.Size(200, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "Gestionar Compras";
            // 
            // textBoxfiltro
            // 
            this.textBoxfiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxfiltro.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxfiltro.Location = new System.Drawing.Point(293, 50);
            this.textBoxfiltro.Name = "textBoxfiltro";
            this.textBoxfiltro.Size = new System.Drawing.Size(122, 20);
            this.textBoxfiltro.TabIndex = 41;
            this.textBoxfiltro.Text = "Proveedor";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Autocred.Properties.Resources.Actions_view_refresh_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(581, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 67);
            this.button1.TabIndex = 47;
            this.button1.Text = "&Refrescar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBAJAS
            // 
            this.btnBAJAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBAJAS.FlatAppearance.BorderSize = 0;
            this.btnBAJAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBAJAS.Image = global::Autocred.Properties.Resources.shop_delete__1___1_;
            this.btnBAJAS.Location = new System.Drawing.Point(565, 168);
            this.btnBAJAS.Name = "btnBAJAS";
            this.btnBAJAS.Size = new System.Drawing.Size(91, 89);
            this.btnBAJAS.TabIndex = 45;
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
            this.btnMODIFICACIONES.Image = global::Autocred.Properties.Resources.shop_edit__1___1_;
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(565, 263);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 90);
            this.btnMODIFICACIONES.TabIndex = 46;
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
            this.btnALTAS.Image = global::Autocred.Properties.Resources.shop_add__3___1_;
            this.btnALTAS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnALTAS.Location = new System.Drawing.Point(552, 84);
            this.btnALTAS.Name = "btnALTAS";
            this.btnALTAS.Size = new System.Drawing.Size(104, 87);
            this.btnALTAS.TabIndex = 44;
            this.btnALTAS.Text = "&Agregar";
            this.btnALTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnALTAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnALTAS.UseVisualStyleBackColor = true;
            this.btnALTAS.Click += new System.EventHandler(this.btnALTAS_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(421, 50);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(30, 20);
            this.btnBUSCAR.TabIndex = 42;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // Lista_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBAJAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnALTAS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.textBoxfiltro);
            this.Controls.Add(this.dgvOrdenes);
            this.Name = "Lista_Ordenes";
            this.Text = "Lista_Ordenes";
            this.Load += new System.EventHandler(this.Lista_Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox textBoxfiltro;
        private System.Windows.Forms.Button btnBAJAS;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnALTAS;
        private System.Windows.Forms.Button button1;
    }
}