namespace AluguelDeCarros
{
    partial class Devolver
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.lblRecibo);
            this.panel1.Controls.Add(this.txtRecibo);
            this.panel1.Controls.Add(this.btnDevolver);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 138);
            this.panel1.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(109, 82);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.Location = new System.Drawing.Point(49, 24);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(86, 13);
            this.lblRecibo.TabIndex = 2;
            this.lblRecibo.Text = "Informe o recibo:";
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(42, 42);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(100, 20);
            this.txtRecibo.TabIndex = 1;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(3, 82);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 0;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // Devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 153);
            this.Controls.Add(this.panel1);
            this.Name = "Devolver";
            this.Text = "Devolver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblRecibo;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Button btnDevolver;
    }
}