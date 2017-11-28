namespace AluguelDeCarros
{
    partial class TelaCarrosCliente
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
            this.Empresaa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsultarCarro = new System.Windows.Forms.Button();
            this.Disponibilidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtInicialCarro = new System.Windows.Forms.TextBox();
            this.lblIniciais = new System.Windows.Forms.Label();
            this.lstCarros = new System.Windows.Forms.ListView();
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCarros = new System.Windows.Forms.TabPage();
            this.tbDados = new System.Windows.Forms.TabControl();
            this.grpCarros = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tbCarros.SuspendLayout();
            this.tbDados.SuspendLayout();
            this.grpCarros.SuspendLayout();
            this.SuspendLayout();
            // 
            // Empresaa
            // 
            this.Empresaa.Text = "Empresa";
            this.Empresaa.Width = 136;
            // 
            // btnConsultarCarro
            // 
            this.btnConsultarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCarro.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarCarro.Location = new System.Drawing.Point(776, 14);
            this.btnConsultarCarro.Name = "btnConsultarCarro";
            this.btnConsultarCarro.Size = new System.Drawing.Size(82, 25);
            this.btnConsultarCarro.TabIndex = 1;
            this.btnConsultarCarro.Text = "&OK";
            this.btnConsultarCarro.UseVisualStyleBackColor = true;
            this.btnConsultarCarro.Click += new System.EventHandler(this.btnConsultarCarro_Click);
            // 
            // Disponibilidade
            // 
            this.Disponibilidade.Text = "Disponibilidade";
            this.Disponibilidade.Width = 108;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço - Diária";
            this.Preco.Width = 115;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            this.Ano.Width = 52;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 140;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 119;
            // 
            // Placa
            // 
            this.Placa.Text = "Placa";
            this.Placa.Width = 73;
            // 
            // txtInicialCarro
            // 
            this.txtInicialCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicialCarro.Location = new System.Drawing.Point(159, 14);
            this.txtInicialCarro.MaxLength = 50;
            this.txtInicialCarro.Name = "txtInicialCarro";
            this.txtInicialCarro.Size = new System.Drawing.Size(611, 24);
            this.txtInicialCarro.TabIndex = 0;
            // 
            // lblIniciais
            // 
            this.lblIniciais.AutoSize = true;
            this.lblIniciais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciais.ForeColor = System.Drawing.Color.Black;
            this.lblIniciais.Location = new System.Drawing.Point(16, 18);
            this.lblIniciais.Name = "lblIniciais";
            this.lblIniciais.Size = new System.Drawing.Size(100, 16);
            this.lblIniciais.TabIndex = 3;
            this.lblIniciais.Text = "Nome do Carro";
            // 
            // lstCarros
            // 
            this.lstCarros.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstCarros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Placa,
            this.Marca,
            this.Nome,
            this.Ano,
            this.Preco,
            this.Disponibilidade,
            this.Cidade,
            this.Empresaa});
            this.lstCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarros.FullRowSelect = true;
            this.lstCarros.Location = new System.Drawing.Point(9, 45);
            this.lstCarros.MultiSelect = false;
            this.lstCarros.Name = "lstCarros";
            this.lstCarros.Size = new System.Drawing.Size(863, 355);
            this.lstCarros.TabIndex = 2;
            this.lstCarros.UseCompatibleStateImageBehavior = false;
            this.lstCarros.View = System.Windows.Forms.View.Details;
            this.lstCarros.SelectedIndexChanged += new System.EventHandler(this.lstCarros_SelectedIndexChanged);
            this.lstCarros.BindingContextChanged += new System.EventHandler(this.lstCarros_BindingContextChanged);
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            this.Cidade.Width = 116;
            // 
            // tbCarros
            // 
            this.tbCarros.Controls.Add(this.txtInicialCarro);
            this.tbCarros.Controls.Add(this.lblIniciais);
            this.tbCarros.Controls.Add(this.lstCarros);
            this.tbCarros.Controls.Add(this.btnConsultarCarro);
            this.tbCarros.Location = new System.Drawing.Point(4, 33);
            this.tbCarros.Name = "tbCarros";
            this.tbCarros.Padding = new System.Windows.Forms.Padding(3);
            this.tbCarros.Size = new System.Drawing.Size(878, 406);
            this.tbCarros.TabIndex = 1;
            this.tbCarros.Text = "Carros";
            this.tbCarros.UseVisualStyleBackColor = true;
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.tbCarros);
            this.tbDados.Location = new System.Drawing.Point(6, 28);
            this.tbDados.Name = "tbDados";
            this.tbDados.SelectedIndex = 0;
            this.tbDados.Size = new System.Drawing.Size(886, 443);
            this.tbDados.TabIndex = 4;
            // 
            // grpCarros
            // 
            this.grpCarros.BackColor = System.Drawing.Color.Transparent;
            this.grpCarros.Controls.Add(this.tbDados);
            this.grpCarros.Controls.Add(this.btnFechar);
            this.grpCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarros.ForeColor = System.Drawing.Color.White;
            this.grpCarros.Location = new System.Drawing.Point(12, 12);
            this.grpCarros.Name = "grpCarros";
            this.grpCarros.Size = new System.Drawing.Size(898, 533);
            this.grpCarros.TabIndex = 5;
            this.grpCarros.TabStop = false;
            this.grpCarros.Text = "Lista de Carros";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Window;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.Image = global::AluguelDeCarros.Properties.Resources.Delete_icon;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(365, 477);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(131, 51);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // TelaCarrosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AluguelDeCarros.Properties.Resources._303066;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 548);
            this.Controls.Add(this.grpCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCarrosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCarrosCliente";
            this.tbCarros.ResumeLayout(false);
            this.tbCarros.PerformLayout();
            this.tbDados.ResumeLayout(false);
            this.grpCarros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Empresaa;
        private System.Windows.Forms.Button btnConsultarCarro;
        private System.Windows.Forms.ColumnHeader Disponibilidade;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Placa;
        private System.Windows.Forms.TextBox txtInicialCarro;
        private System.Windows.Forms.Label lblIniciais;
        private System.Windows.Forms.ListView lstCarros;
        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.TabPage tbCarros;
        private System.Windows.Forms.TabControl tbDados;
        private System.Windows.Forms.GroupBox grpCarros;
        private System.Windows.Forms.Button btnFechar;
    }
}