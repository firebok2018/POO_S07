namespace Encriptacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncritpar = new System.Windows.Forms.Button();
            this.txtTExt = new System.Windows.Forms.TextBox();
            this.txtEncript = new System.Windows.Forms.TextBox();
            this.Te = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncritpar
            // 
            this.btnEncritpar.Location = new System.Drawing.Point(108, 200);
            this.btnEncritpar.Name = "btnEncritpar";
            this.btnEncritpar.Size = new System.Drawing.Size(75, 23);
            this.btnEncritpar.TabIndex = 0;
            this.btnEncritpar.Text = "Encriptar";
            this.btnEncritpar.UseVisualStyleBackColor = true;
            this.btnEncritpar.Click += new System.EventHandler(this.btnEncritpar_Click);
            // 
            // txtTExt
            // 
            this.txtTExt.Location = new System.Drawing.Point(59, 55);
            this.txtTExt.Name = "txtTExt";
            this.txtTExt.Size = new System.Drawing.Size(187, 20);
            this.txtTExt.TabIndex = 1;
            // 
            // txtEncript
            // 
            this.txtEncript.Location = new System.Drawing.Point(3, 110);
            this.txtEncript.Name = "txtEncript";
            this.txtEncript.Size = new System.Drawing.Size(280, 20);
            this.txtEncript.TabIndex = 2;
            // 
            // Te
            // 
            this.Te.AutoSize = true;
            this.Te.Location = new System.Drawing.Point(92, 39);
            this.Te.Name = "Te";
            this.Te.Size = new System.Drawing.Size(30, 13);
            this.Te.TabIndex = 3;
            this.Te.Text = "texto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Code";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Te);
            this.Controls.Add(this.txtEncript);
            this.Controls.Add(this.txtTExt);
            this.Controls.Add(this.btnEncritpar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEncritpar;
        private System.Windows.Forms.TextBox txtTExt;
        private System.Windows.Forms.TextBox txtEncript;
        private System.Windows.Forms.Label Te;
        private System.Windows.Forms.Label label1;
    }
}

