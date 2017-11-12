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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(342, 33);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(139, 51);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadCarro
            // 
            this.btnCadCarro.Location = new System.Drawing.Point(138, 33);
            this.btnCadCarro.Name = "btnCadCarro";
            this.btnCadCarro.Size = new System.Drawing.Size(139, 51);
            this.btnCadCarro.TabIndex = 1;
            this.btnCadCarro.Text = "Cadastrar Carro";
            this.btnCadCarro.UseVisualStyleBackColor = true;
            this.btnCadCarro.Click += new System.EventHandler(this.btnCadCarro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar/Excluir Carro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Editar/Excluir Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Listar Carro";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(342, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "Listar Cliente";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(242, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AluguelDeCarros.Properties.Resources.images__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 315);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

