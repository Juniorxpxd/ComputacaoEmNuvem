namespace AluguelDeCarros
{
    partial class MenuPrincipal
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnLoginEmpresa = new System.Windows.Forms.Button();
            this.btnPlanos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Window;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(377, 377);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 34);
            this.btnSair.TabIndex = 38;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCliente.Location = new System.Drawing.Point(152, 295);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(193, 64);
            this.btnCliente.TabIndex = 37;
            this.btnCliente.Text = "Login Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnLoginEmpresa
            // 
            this.btnLoginEmpresa.BackColor = System.Drawing.SystemColors.Window;
            this.btnLoginEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLoginEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoginEmpresa.Location = new System.Drawing.Point(152, 207);
            this.btnLoginEmpresa.Name = "btnLoginEmpresa";
            this.btnLoginEmpresa.Size = new System.Drawing.Size(193, 64);
            this.btnLoginEmpresa.TabIndex = 36;
            this.btnLoginEmpresa.Text = "Login Empresa";
            this.btnLoginEmpresa.UseVisualStyleBackColor = false;
            this.btnLoginEmpresa.Click += new System.EventHandler(this.btnLoginEmpresa_Click);
            // 
            // btnPlanos
            // 
            this.btnPlanos.BackColor = System.Drawing.SystemColors.Window;
            this.btnPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlanos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPlanos.Location = new System.Drawing.Point(169, 151);
            this.btnPlanos.Name = "btnPlanos";
            this.btnPlanos.Size = new System.Drawing.Size(160, 36);
            this.btnPlanos.TabIndex = 39;
            this.btnPlanos.Text = "Planos";
            this.btnPlanos.UseVisualStyleBackColor = false;
            this.btnPlanos.Click += new System.EventHandler(this.btnPlanos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AluguelDeCarros.Properties.Resources.popcorntime_icon;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 130);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 42);
            this.label3.TabIndex = 43;
            this.label3.Text = "Menu Principal";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AluguelDeCarros.Properties.Resources.fantasy_hd_background_18457_18924_hd_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlanos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnLoginEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnLoginEmpresa;
        private System.Windows.Forms.Button btnPlanos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}