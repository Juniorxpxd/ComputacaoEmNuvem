namespace AluguelDeCarros
{
    partial class MenuPrincipalCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalCliente));
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.grpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCadCliente.Location = new System.Drawing.Point(203, 58);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(139, 51);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.Text = "Perfil";
            this.btnCadCliente.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::AluguelDeCarros.Properties.Resources.Delete_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(419, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fechar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(203, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Listar carros";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // grpCliente
            // 
            this.grpCliente.BackColor = System.Drawing.Color.Transparent;
            this.grpCliente.Controls.Add(this.button2);
            this.grpCliente.Controls.Add(this.btnCadCliente);
            this.grpCliente.Controls.Add(this.button1);
            this.grpCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.ForeColor = System.Drawing.Color.White;
            this.grpCliente.Location = new System.Drawing.Point(12, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(565, 288);
            this.grpCliente.TabIndex = 4;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Menu do Cliente";
            // 
            // MenuPrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 312);
            this.Controls.Add(this.grpCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipalCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalCliente";
            this.grpCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpCliente;
    }
}