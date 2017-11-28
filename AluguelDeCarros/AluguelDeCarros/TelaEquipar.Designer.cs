namespace AluguelDeCarros
{
    partial class TelaEquipar
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
            this.gpEquipar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPreço = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEquipar = new System.Windows.Forms.Button();
            this.cCDplayer = new System.Windows.Forms.CheckBox();
            this.cPortacopo = new System.Windows.Forms.CheckBox();
            this.cSuporteCelular = new System.Windows.Forms.CheckBox();
            this.ckitferramenta = new System.Windows.Forms.CheckBox();
            this.cDVDAutomotivo = new System.Windows.Forms.CheckBox();
            this.cGPS = new System.Windows.Forms.CheckBox();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.txtReciboDevolver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpEquipar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEquipar
            // 
            this.gpEquipar.BackgroundImage = global::AluguelDeCarros.Properties.Resources.resumo_de_fundo_com_um_desenho_geometrico_1048_1450;
            this.gpEquipar.Controls.Add(this.label1);
            this.gpEquipar.Controls.Add(this.txtReciboDevolver);
            this.gpEquipar.Controls.Add(this.button1);
            this.gpEquipar.Controls.Add(this.btnCalcular);
            this.gpEquipar.Controls.Add(this.lblPreço);
            this.gpEquipar.Controls.Add(this.txtValorTotal);
            this.gpEquipar.Controls.Add(this.btnVoltar);
            this.gpEquipar.Controls.Add(this.btnEquipar);
            this.gpEquipar.Controls.Add(this.cCDplayer);
            this.gpEquipar.Controls.Add(this.cPortacopo);
            this.gpEquipar.Controls.Add(this.cSuporteCelular);
            this.gpEquipar.Controls.Add(this.ckitferramenta);
            this.gpEquipar.Controls.Add(this.cDVDAutomotivo);
            this.gpEquipar.Controls.Add(this.cGPS);
            this.gpEquipar.Controls.Add(this.lblRecibo);
            this.gpEquipar.Controls.Add(this.txtRecibo);
            this.gpEquipar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEquipar.Location = new System.Drawing.Point(12, 12);
            this.gpEquipar.Name = "gpEquipar";
            this.gpEquipar.Size = new System.Drawing.Size(934, 370);
            this.gpEquipar.TabIndex = 0;
            this.gpEquipar.TabStop = false;
            this.gpEquipar.Text = "Equipar Carro ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Devolver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(224, 281);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 26);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.BackColor = System.Drawing.Color.Transparent;
            this.lblPreço.Location = new System.Drawing.Point(32, 284);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(56, 20);
            this.lblPreço.TabIndex = 12;
            this.lblPreço.Text = "Valor:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(108, 281);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 26);
            this.txtValorTotal.TabIndex = 11;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(38, 327);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 37);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEquipar
            // 
            this.btnEquipar.Location = new System.Drawing.Point(433, 327);
            this.btnEquipar.Name = "btnEquipar";
            this.btnEquipar.Size = new System.Drawing.Size(88, 37);
            this.btnEquipar.TabIndex = 9;
            this.btnEquipar.Text = "Equipar";
            this.btnEquipar.UseVisualStyleBackColor = true;
            this.btnEquipar.Click += new System.EventHandler(this.btnEquipar_Click);
            // 
            // cCDplayer
            // 
            this.cCDplayer.AutoSize = true;
            this.cCDplayer.BackColor = System.Drawing.Color.Transparent;
            this.cCDplayer.Location = new System.Drawing.Point(330, 155);
            this.cCDplayer.Name = "cCDplayer";
            this.cCDplayer.Size = new System.Drawing.Size(191, 24);
            this.cCDplayer.TabIndex = 8;
            this.cCDplayer.Text = "CD Player - R$30,00";
            this.cCDplayer.UseVisualStyleBackColor = false;
            // 
            // cPortacopo
            // 
            this.cPortacopo.AutoSize = true;
            this.cPortacopo.BackColor = System.Drawing.Color.Transparent;
            this.cPortacopo.Location = new System.Drawing.Point(36, 218);
            this.cPortacopo.Name = "cPortacopo";
            this.cPortacopo.Size = new System.Drawing.Size(289, 24);
            this.cPortacopo.TabIndex = 7;
            this.cPortacopo.Text = "Bolsa Porta Acessório - R$15,00";
            this.cPortacopo.UseVisualStyleBackColor = false;
            // 
            // cSuporteCelular
            // 
            this.cSuporteCelular.AutoSize = true;
            this.cSuporteCelular.BackColor = System.Drawing.Color.Transparent;
            this.cSuporteCelular.Location = new System.Drawing.Point(36, 185);
            this.cSuporteCelular.Name = "cSuporteCelular";
            this.cSuporteCelular.Size = new System.Drawing.Size(278, 24);
            this.cSuporteCelular.TabIndex = 6;
            this.cSuporteCelular.Text = "Suporte para Celular - R$10,00";
            this.cSuporteCelular.UseVisualStyleBackColor = false;
            // 
            // ckitferramenta
            // 
            this.ckitferramenta.AutoSize = true;
            this.ckitferramenta.BackColor = System.Drawing.Color.Transparent;
            this.ckitferramenta.Location = new System.Drawing.Point(36, 155);
            this.ckitferramenta.Name = "ckitferramenta";
            this.ckitferramenta.Size = new System.Drawing.Size(256, 24);
            this.ckitferramenta.TabIndex = 5;
            this.ckitferramenta.Text = "Kit de Ferramenta - R$70,00";
            this.ckitferramenta.UseVisualStyleBackColor = false;
            // 
            // cDVDAutomotivo
            // 
            this.cDVDAutomotivo.AutoSize = true;
            this.cDVDAutomotivo.BackColor = System.Drawing.Color.Transparent;
            this.cDVDAutomotivo.Location = new System.Drawing.Point(36, 122);
            this.cDVDAutomotivo.Name = "cDVDAutomotivo";
            this.cDVDAutomotivo.Size = new System.Drawing.Size(245, 24);
            this.cDVDAutomotivo.TabIndex = 4;
            this.cDVDAutomotivo.Text = "DVD Automotivo - R$50,00";
            this.cDVDAutomotivo.UseVisualStyleBackColor = false;
            // 
            // cGPS
            // 
            this.cGPS.AutoSize = true;
            this.cGPS.BackColor = System.Drawing.Color.Transparent;
            this.cGPS.Location = new System.Drawing.Point(330, 122);
            this.cGPS.Name = "cGPS";
            this.cGPS.Size = new System.Drawing.Size(149, 24);
            this.cGPS.TabIndex = 3;
            this.cGPS.Text = "GPS - R$60,00";
            this.cGPS.UseVisualStyleBackColor = false;
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.BackColor = System.Drawing.Color.Transparent;
            this.lblRecibo.Location = new System.Drawing.Point(32, 44);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(70, 20);
            this.lblRecibo.TabIndex = 1;
            this.lblRecibo.Text = "Recibo:";
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(108, 41);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(186, 26);
            this.txtRecibo.TabIndex = 0;
            // 
            // txtReciboDevolver
            // 
            this.txtReciboDevolver.Location = new System.Drawing.Point(719, 41);
            this.txtReciboDevolver.Name = "txtReciboDevolver";
            this.txtReciboDevolver.Size = new System.Drawing.Size(186, 26);
            this.txtReciboDevolver.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(643, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Recibo:";
            // 
            // TelaEquipar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AluguelDeCarros.Properties.Resources.Parrot_RNB6_1;
            this.ClientSize = new System.Drawing.Size(958, 394);
            this.Controls.Add(this.gpEquipar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaEquipar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Equipar";
            this.gpEquipar.ResumeLayout(false);
            this.gpEquipar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEquipar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEquipar;
        private System.Windows.Forms.CheckBox cCDplayer;
        private System.Windows.Forms.CheckBox cPortacopo;
        private System.Windows.Forms.CheckBox cSuporteCelular;
        private System.Windows.Forms.CheckBox ckitferramenta;
        private System.Windows.Forms.CheckBox cDVDAutomotivo;
        private System.Windows.Forms.CheckBox cGPS;
        private System.Windows.Forms.Label lblRecibo;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReciboDevolver;
    }
}