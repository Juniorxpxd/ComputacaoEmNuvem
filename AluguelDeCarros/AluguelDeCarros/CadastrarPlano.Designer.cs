namespace AluguelDeCarros
{
    partial class CadastrarPlano
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlano = new System.Windows.Forms.Label();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::AluguelDeCarros.Properties.Resources.resumo_de_fundo_com_um_desenho_geometrico_1048_1450;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblPlano);
            this.groupBox1.Controls.Add(this.txtPlano);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Planos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.BackColor = System.Drawing.Color.Transparent;
            this.lblPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlano.Location = new System.Drawing.Point(6, 42);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(59, 20);
            this.lblPlano.TabIndex = 2;
            this.lblPlano.Text = "Plano:";
            this.lblPlano.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(71, 39);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(100, 26);
            this.txtPlano.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(201, 202);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 29);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastrarPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AluguelDeCarros.Properties.Resources.resumo_de_fundo_com_um_desenho_geometrico_1048_1450;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarPlano";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.Button button1;
    }
}