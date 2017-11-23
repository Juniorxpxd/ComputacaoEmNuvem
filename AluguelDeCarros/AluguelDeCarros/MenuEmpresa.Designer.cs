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
            this.btnCarros = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpEmpresa = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.grpEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCadCliente.Location = new System.Drawing.Point(314, 28);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(139, 51);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = false;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadCarro
            // 
            this.btnCadCarro.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCarro.ForeColor = System.Drawing.Color.Black;
            this.btnCadCarro.Location = new System.Drawing.Point(6, 28);
            this.btnCadCarro.Name = "btnCadCarro";
            this.btnCadCarro.Size = new System.Drawing.Size(139, 51);
            this.btnCadCarro.TabIndex = 1;
            this.btnCadCarro.Text = "Cadastrar Carro";
            this.btnCadCarro.UseVisualStyleBackColor = false;
            this.btnCadCarro.Click += new System.EventHandler(this.btnCadCarro_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.BackColor = System.Drawing.SystemColors.Window;
            this.btnCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarros.ForeColor = System.Drawing.Color.Black;
            this.btnCarros.Location = new System.Drawing.Point(6, 129);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(139, 51);
            this.btnCarros.TabIndex = 4;
            this.btnCarros.Text = "Lista de Carros";
            this.btnCarros.UseVisualStyleBackColor = false;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(314, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "Lista de Clientes";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Window;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = global::AluguelDeCarros.Properties.Resources.Delete_icon;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(161, 226);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(139, 51);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Fechar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpEmpresa
            // 
            this.grpEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.grpEmpresa.Controls.Add(this.button5);
            this.grpEmpresa.Controls.Add(this.btnCadCarro);
            this.grpEmpresa.Controls.Add(this.button4);
            this.grpEmpresa.Controls.Add(this.btnSair);
            this.grpEmpresa.Controls.Add(this.btnCadCliente);
            this.grpEmpresa.Controls.Add(this.btnCarros);
            this.grpEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmpresa.ForeColor = System.Drawing.Color.White;
            this.grpEmpresa.Location = new System.Drawing.Point(12, 12);
            this.grpEmpresa.Name = "grpEmpresa";
            this.grpEmpresa.Size = new System.Drawing.Size(460, 294);
            this.grpEmpresa.TabIndex = 7;
            this.grpEmpresa.TabStop = false;
            this.grpEmpresa.Text = "Menu da Empresa";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(161, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 51);
            this.button5.TabIndex = 7;
            this.button5.Text = "Perfil";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AluguelDeCarros.Properties.Resources.Carros_Antigos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 314);
            this.Controls.Add(this.grpEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu da Empresa";
            this.grpEmpresa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadCarro;
        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpEmpresa;
        private System.Windows.Forms.Button button5;
    }
}

