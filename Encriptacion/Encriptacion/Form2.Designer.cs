namespace Encriptacion
{
    partial class Form2
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
            this.txtS = new System.Windows.Forms.TextBox();
            this.btnEncriptat = new System.Windows.Forms.Button();
            this.brnDesencriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(12, 12);
            this.txtS.Multiline = true;
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(256, 426);
            this.txtS.TabIndex = 0;
            // 
            // btnEncriptat
            // 
            this.btnEncriptat.Location = new System.Drawing.Point(332, 32);
            this.btnEncriptat.Name = "btnEncriptat";
            this.btnEncriptat.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptat.TabIndex = 1;
            this.btnEncriptat.Text = "Encriptar";
            this.btnEncriptat.UseVisualStyleBackColor = true;
            this.btnEncriptat.Click += new System.EventHandler(this.btnEncriptat_Click);
            // 
            // brnDesencriptar
            // 
            this.brnDesencriptar.Location = new System.Drawing.Point(332, 84);
            this.brnDesencriptar.Name = "brnDesencriptar";
            this.brnDesencriptar.Size = new System.Drawing.Size(75, 23);
            this.brnDesencriptar.TabIndex = 2;
            this.brnDesencriptar.Text = "DeSencriptar";
            this.brnDesencriptar.UseVisualStyleBackColor = true;
            this.brnDesencriptar.Click += new System.EventHandler(this.brnDesencriptar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.brnDesencriptar);
            this.Controls.Add(this.btnEncriptat);
            this.Controls.Add(this.txtS);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Button btnEncriptat;
        private System.Windows.Forms.Button brnDesencriptar;
    }
}