namespace AluguelDeCarros
{
    partial class MenuEmpresa
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
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadCarro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(35, 43);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(139, 51);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadCarro
            // 
            this.btnCadCarro.Location = new System.Drawing.Point(311, 43);
            this.btnCadCarro.Name = "btnCadCarro";
            this.btnCadCarro.Size = new System.Drawing.Size(139, 51);
            this.btnCadCarro.TabIndex = 1;
            this.btnCadCarro.Text = "Cadastrar Carro";
            this.btnCadCarro.UseVisualStyleBackColor = true;
            this.btnCadCarro.Click += new System.EventHandler(this.btnCadCarro_Click);
            // 
            // MenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 131);
            this.Controls.Add(this.btnCadCarro);
            this.Controls.Add(this.btnCadCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu da Empresa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadCarro;
    }
}

