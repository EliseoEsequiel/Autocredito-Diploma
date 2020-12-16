namespace Autocred
{
    partial class Remitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remitos));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxfiltro = new System.Windows.Forms.TextBox();
            this.dgvRemitos = new System.Windows.Forms.DataGridView();
            this.btnBAJAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnALTAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(207, 33);
            this.label1.MaximumSize = new System.Drawing.Size(200, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Gestionar Remitos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxfiltro
            // 
            this.textBoxfiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxfiltro.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxfiltro.Location = new System.Drawing.Point(212, 74);
            this.textBoxfiltro.Name = "textBoxfiltro";
            this.textBoxfiltro.Size = new System.Drawing.Size(122, 20);
            this.textBoxfiltro.TabIndex = 49;
            this.textBoxfiltro.Text = "Proveedor";
            // 
            // dgvRemitos
            // 
            this.dgvRemitos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvRemitos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRemitos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemitos.Location = new System.Drawing.Point(93, 100);
            this.dgvRemitos.Name = "dgvRemitos";
            this.dgvRemitos.Size = new System.Drawing.Size(372, 350);
            this.dgvRemitos.TabIndex = 48;
            this.dgvRemitos.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvRemitos_ColumnAdded);
            // 
            // btnBAJAS
            // 
            this.btnBAJAS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBAJAS.FlatAppearance.BorderSize = 0;
            this.btnBAJAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBAJAS.Image = global::Autocred.Properties.Resources.deleterem_opt__2_;
            this.btnBAJAS.Location = new System.Drawing.Point(484, 333);
            this.btnBAJAS.Name = "btnBAJAS";
            this.btnBAJAS.Size = new System.Drawing.Size(91, 117);
            this.btnBAJAS.TabIndex = 53;
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
            this.btnMODIFICACIONES.Image = global::Autocred.Properties.Resources.edit_remito_opt__2_;
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(484, 214);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 123);
            this.btnMODIFICACIONES.TabIndex = 54;
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
            this.btnALTAS.Image = global::Autocred.Properties.Resources.addrem_opt__1_;
            this.btnALTAS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnALTAS.Location = new System.Drawing.Point(484, 100);
            this.btnALTAS.Name = "btnALTAS";
            this.btnALTAS.Size = new System.Drawing.Size(91, 108);
            this.btnALTAS.TabIndex = 52;
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
            this.btnBUSCAR.Location = new System.Drawing.Point(340, 74);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(30, 20);
            this.btnBUSCAR.TabIndex = 50;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            // 
            // Remitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(668, 482);
            this.Controls.Add(this.btnBAJAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnALTAS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.textBoxfiltro);
            this.Controls.Add(this.dgvRemitos);
            this.Name = "Remitos";
            this.Text = "Remitos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBAJAS;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnALTAS;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox textBoxfiltro;
        private System.Windows.Forms.DataGridView dgvRemitos;
    }
}