﻿namespace Autocred
{
    partial class formComun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formComun));
            this.btn_Req = new System.Windows.Forms.Button();
            this.cmdEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Req
            // 
            this.btn_Req.Location = new System.Drawing.Point(78, 59);
            this.btn_Req.Name = "btn_Req";
            this.btn_Req.Size = new System.Drawing.Size(115, 23);
            this.btn_Req.TabIndex = 3;
            this.btn_Req.Text = "Requerimientos";
            this.btn_Req.UseVisualStyleBackColor = true;
            this.btn_Req.Click += new System.EventHandler(this.btn_Req_Click);
            // 
            // cmdEXIT
            // 
            this.cmdEXIT.Image = ((System.Drawing.Image)(resources.GetObject("cmdEXIT.Image")));
            this.cmdEXIT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdEXIT.Location = new System.Drawing.Point(227, 101);
            this.cmdEXIT.Name = "cmdEXIT";
            this.cmdEXIT.Size = new System.Drawing.Size(56, 62);
            this.cmdEXIT.TabIndex = 7;
            this.cmdEXIT.Text = "LogOut";
            this.cmdEXIT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdEXIT.UseVisualStyleBackColor = true;
            this.cmdEXIT.Click += new System.EventHandler(this.cmdEXIT_Click);
            // 
            // formComun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.cmdEXIT);
            this.Controls.Add(this.btn_Req);
            this.Name = "formComun";
            this.Text = "frmComun";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Req;
        private System.Windows.Forms.Button cmdEXIT;
    }
}