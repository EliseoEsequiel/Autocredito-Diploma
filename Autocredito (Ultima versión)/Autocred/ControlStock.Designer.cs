namespace Autocred
{
    partial class ControlStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlStock));
            this.rdb_Suma = new System.Windows.Forms.RadioButton();
            this.rdb_Resta = new System.Windows.Forms.RadioButton();
            this.textbox_Cant = new System.Windows.Forms.TextBox();
            this.textbox_Art = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_Suma
            // 
            this.rdb_Suma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_Suma.Location = new System.Drawing.Point(328, 285);
            this.rdb_Suma.Name = "rdb_Suma";
            this.rdb_Suma.Size = new System.Drawing.Size(121, 25);
            this.rdb_Suma.TabIndex = 0;
            this.rdb_Suma.Text = "Aumentar Stock";
            this.rdb_Suma.UseVisualStyleBackColor = true;
            // 
            // rdb_Resta
            // 
            this.rdb_Resta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_Resta.Location = new System.Drawing.Point(328, 316);
            this.rdb_Resta.Name = "rdb_Resta";
            this.rdb_Resta.Size = new System.Drawing.Size(98, 17);
            this.rdb_Resta.TabIndex = 1;
            this.rdb_Resta.TabStop = true;
            this.rdb_Resta.Text = "Disminuir Stock";
            this.rdb_Resta.UseVisualStyleBackColor = true;
            // 
            // textbox_Cant
            // 
            this.textbox_Cant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_Cant.Location = new System.Drawing.Point(329, 234);
            this.textbox_Cant.Name = "textbox_Cant";
            this.textbox_Cant.Size = new System.Drawing.Size(121, 20);
            this.textbox_Cant.TabIndex = 2;
            this.textbox_Cant.TextChanged += new System.EventHandler(this.textbox_Cant_TextChanged);
            this.textbox_Cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Cant_KeyPress);
            // 
            // textbox_Art
            // 
            this.textbox_Art.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_Art.Location = new System.Drawing.Point(329, 189);
            this.textbox_Art.Name = "textbox_Art";
            this.textbox_Art.ReadOnly = true;
            this.textbox_Art.Size = new System.Drawing.Size(121, 20);
            this.textbox_Art.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artículo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(327, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Actualizar Stock";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(456, 189);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(31, 20);
            this.btnBUSCAR.TabIndex = 39;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // ControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 482);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_Art);
            this.Controls.Add(this.textbox_Cant);
            this.Controls.Add(this.rdb_Resta);
            this.Controls.Add(this.rdb_Suma);
            this.Name = "ControlStock";
            this.Text = "ControlStock";
            this.Load += new System.EventHandler(this.ControlStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Suma;
        private System.Windows.Forms.RadioButton rdb_Resta;
        private System.Windows.Forms.TextBox textbox_Cant;
        private System.Windows.Forms.TextBox textbox_Art;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBUSCAR;
    }
}