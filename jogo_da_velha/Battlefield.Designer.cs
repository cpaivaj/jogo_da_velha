﻿namespace jogo_da_velha
{
    partial class Battlefield
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEsqSup = new System.Windows.Forms.Button();
            this.btnMidMid = new System.Windows.Forms.Button();
            this.btnEsqMid = new System.Windows.Forms.Button();
            this.btnDirMid = new System.Windows.Forms.Button();
            this.btnDirSup = new System.Windows.Forms.Button();
            this.btnMidSup = new System.Windows.Forms.Button();
            this.btnMidInf = new System.Windows.Forms.Button();
            this.btnDirInf = new System.Windows.Forms.Button();
            this.btnEsqInf = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEsqSup
            // 
            this.btnEsqSup.Enabled = false;
            this.btnEsqSup.Location = new System.Drawing.Point(326, 126);
            this.btnEsqSup.Name = "btnEsqSup";
            this.btnEsqSup.Size = new System.Drawing.Size(75, 75);
            this.btnEsqSup.TabIndex = 0;
            this.btnEsqSup.UseVisualStyleBackColor = true;
            this.btnEsqSup.Click += new System.EventHandler(this.btnEsqSup_Click);
            // 
            // btnMidMid
            // 
            this.btnMidMid.Enabled = false;
            this.btnMidMid.Location = new System.Drawing.Point(407, 207);
            this.btnMidMid.Name = "btnMidMid";
            this.btnMidMid.Size = new System.Drawing.Size(75, 75);
            this.btnMidMid.TabIndex = 1;
            this.btnMidMid.UseVisualStyleBackColor = true;
            this.btnMidMid.Click += new System.EventHandler(this.btnMidMid_Click);
            // 
            // btnEsqMid
            // 
            this.btnEsqMid.Enabled = false;
            this.btnEsqMid.Location = new System.Drawing.Point(326, 207);
            this.btnEsqMid.Name = "btnEsqMid";
            this.btnEsqMid.Size = new System.Drawing.Size(75, 75);
            this.btnEsqMid.TabIndex = 2;
            this.btnEsqMid.UseVisualStyleBackColor = true;
            this.btnEsqMid.Click += new System.EventHandler(this.btnEsqMid_Click);
            // 
            // btnDirMid
            // 
            this.btnDirMid.Enabled = false;
            this.btnDirMid.Location = new System.Drawing.Point(488, 207);
            this.btnDirMid.Name = "btnDirMid";
            this.btnDirMid.Size = new System.Drawing.Size(75, 75);
            this.btnDirMid.TabIndex = 3;
            this.btnDirMid.UseVisualStyleBackColor = true;
            this.btnDirMid.Click += new System.EventHandler(this.btnDirMid_Click);
            // 
            // btnDirSup
            // 
            this.btnDirSup.Enabled = false;
            this.btnDirSup.Location = new System.Drawing.Point(488, 126);
            this.btnDirSup.Name = "btnDirSup";
            this.btnDirSup.Size = new System.Drawing.Size(75, 75);
            this.btnDirSup.TabIndex = 4;
            this.btnDirSup.UseVisualStyleBackColor = true;
            this.btnDirSup.Click += new System.EventHandler(this.btnDirSup_Click);
            // 
            // btnMidSup
            // 
            this.btnMidSup.Enabled = false;
            this.btnMidSup.Location = new System.Drawing.Point(407, 126);
            this.btnMidSup.Name = "btnMidSup";
            this.btnMidSup.Size = new System.Drawing.Size(75, 75);
            this.btnMidSup.TabIndex = 5;
            this.btnMidSup.UseVisualStyleBackColor = true;
            this.btnMidSup.Click += new System.EventHandler(this.btnMidSup_Click);
            // 
            // btnMidInf
            // 
            this.btnMidInf.Enabled = false;
            this.btnMidInf.Location = new System.Drawing.Point(407, 288);
            this.btnMidInf.Name = "btnMidInf";
            this.btnMidInf.Size = new System.Drawing.Size(75, 75);
            this.btnMidInf.TabIndex = 6;
            this.btnMidInf.UseVisualStyleBackColor = true;
            this.btnMidInf.Click += new System.EventHandler(this.btnMidInf_Click);
            // 
            // btnDirInf
            // 
            this.btnDirInf.Enabled = false;
            this.btnDirInf.Location = new System.Drawing.Point(488, 288);
            this.btnDirInf.Name = "btnDirInf";
            this.btnDirInf.Size = new System.Drawing.Size(75, 75);
            this.btnDirInf.TabIndex = 7;
            this.btnDirInf.UseVisualStyleBackColor = true;
            this.btnDirInf.Click += new System.EventHandler(this.btnDirInf_Click);
            // 
            // btnEsqInf
            // 
            this.btnEsqInf.Enabled = false;
            this.btnEsqInf.Location = new System.Drawing.Point(326, 288);
            this.btnEsqInf.Name = "btnEsqInf";
            this.btnEsqInf.Size = new System.Drawing.Size(75, 75);
            this.btnEsqInf.TabIndex = 8;
            this.btnEsqInf.UseVisualStyleBackColor = true;
            this.btnEsqInf.Click += new System.EventHandler(this.btnEsqInf_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(394, 420);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 46);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 508);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnEsqInf);
            this.Controls.Add(this.btnDirInf);
            this.Controls.Add(this.btnMidInf);
            this.Controls.Add(this.btnMidSup);
            this.Controls.Add(this.btnDirSup);
            this.Controls.Add(this.btnDirMid);
            this.Controls.Add(this.btnEsqMid);
            this.Controls.Add(this.btnMidMid);
            this.Controls.Add(this.btnEsqSup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEsqSup;
        private System.Windows.Forms.Button btnMidMid;
        private System.Windows.Forms.Button btnEsqMid;
        private System.Windows.Forms.Button btnDirMid;
        private System.Windows.Forms.Button btnDirSup;
        private System.Windows.Forms.Button btnMidSup;
        private System.Windows.Forms.Button btnMidInf;
        private System.Windows.Forms.Button btnDirInf;
        private System.Windows.Forms.Button btnEsqInf;
        private System.Windows.Forms.Button btnStart;
    }
}
