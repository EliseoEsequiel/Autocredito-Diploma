namespace Autocred
{
    partial class New_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Item));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_Desc = new System.Windows.Forms.TextBox();
            this.textBox_Cant = new System.Windows.Forms.TextBox();
            this.textbox_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cant_Solic";
            // 
            // textbox_Desc
            // 
            this.textbox_Desc.Location = new System.Drawing.Point(124, 113);
            this.textbox_Desc.Name = "textbox_Desc";
            this.textbox_Desc.ReadOnly = true;
            this.textbox_Desc.Size = new System.Drawing.Size(151, 20);
            this.textbox_Desc.TabIndex = 15;
            // 
            // textBox_Cant
            // 
            this.textBox_Cant.Location = new System.Drawing.Point(124, 148);
            this.textBox_Cant.Name = "textBox_Cant";
            this.textBox_Cant.Size = new System.Drawing.Size(151, 20);
            this.textBox_Cant.TabIndex = 16;
            this.textBox_Cant.TextChanged += new System.EventHandler(this.textBox_Cant_TextChanged);
            this.textBox_Cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cant_KeyPress);
            // 
            // textbox_Id
            // 
            this.textbox_Id.Location = new System.Drawing.Point(124, 83);
            this.textbox_Id.Name = "textbox_Id";
            this.textbox_Id.ReadOnly = true;
            this.textbox_Id.Size = new System.Drawing.Size(151, 20);
            this.textbox_Id.TabIndex = 17;
            this.textbox_Id.TextChanged += new System.EventHandler(this.textbox_Id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id Articulo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "Requerimiento";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(281, 110);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(30, 20);
            this.btnBUSCAR.TabIndex = 48;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(241, 216);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(70, 62);
            this.btnCANCELAR.TabIndex = 47;
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
            this.btnGUARDAR.Location = new System.Drawing.Point(47, 216);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(70, 62);
            this.btnGUARDAR.TabIndex = 46;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Image = global::Autocred.Properties.Resources.icono_limpiar_png_6;
            this.btn_Limpiar.Location = new System.Drawing.Point(138, 216);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(81, 62);
            this.btn_Limpiar.TabIndex = 19;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // New_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 304);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_Id);
            this.Controls.Add(this.textBox_Cant);
            this.Controls.Add(this.textbox_Desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Item";
            this.Load += new System.EventHandler(this.New_Item_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_Desc;
        private System.Windows.Forms.TextBox textBox_Cant;
        private System.Windows.Forms.TextBox textbox_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnBUSCAR;
    }
}