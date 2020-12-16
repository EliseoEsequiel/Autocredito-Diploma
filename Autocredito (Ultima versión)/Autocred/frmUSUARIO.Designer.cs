namespace Autocred
{
    partial class frmUSUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUSUARIO));
            this.label9 = new System.Windows.Forms.Label();
            this.txtNOMBRE_USUARIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtDescripcionGupo = new System.Windows.Forms.TextBox();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Alias";
            // 
            // txtNOMBRE_USUARIO
            // 
            this.txtNOMBRE_USUARIO.Location = new System.Drawing.Point(64, 99);
            this.txtNOMBRE_USUARIO.Name = "txtNOMBRE_USUARIO";
            this.txtNOMBRE_USUARIO.Size = new System.Drawing.Size(178, 20);
            this.txtNOMBRE_USUARIO.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(64, 125);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(178, 20);
            this.txtNOMBRE.TabIndex = 13;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("btnGUARDAR.Image")));
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(64, 177);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(79, 62);
            this.btnGUARDAR.TabIndex = 14;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // txtDescripcionGupo
            // 
            this.txtDescripcionGupo.Location = new System.Drawing.Point(64, 73);
            this.txtDescripcionGupo.Name = "txtDescripcionGupo";
            this.txtDescripcionGupo.ReadOnly = true;
            this.txtDescripcionGupo.Size = new System.Drawing.Size(178, 20);
            this.txtDescripcionGupo.TabIndex = 15;
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(64, 47);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.ReadOnly = true;
            this.txtIdGrupo.Size = new System.Drawing.Size(178, 20);
            this.txtIdGrupo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id_Grupo";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(64, 151);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(178, 20);
            this.textBoxApellido.TabIndex = 20;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apellido";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(248, 63);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(30, 20);
            this.btnBUSCAR.TabIndex = 50;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(163, 179);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(79, 62);
            this.btnCANCELAR.TabIndex = 49;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 51;
            this.label11.Text = "Usuario";
            // 
            // frmUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 258);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(this.txtDescripcionGupo);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNOMBRE_USUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNOMBRE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUSUARIO";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUSUARIO";
            this.Load += new System.EventHandler(this.frmUSUARIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNOMBRE_USUARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtDescripcionGupo;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Label label11;
    }
}