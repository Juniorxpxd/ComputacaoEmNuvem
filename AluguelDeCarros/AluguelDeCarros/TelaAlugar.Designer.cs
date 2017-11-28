namespace AluguelDeCarros
{
    partial class TelaAlugar
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
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRateApplied = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCarro = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtPortas = new System.Windows.Forms.TextBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtQuilometragem = new System.Windows.Forms.TextBox();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Location = new System.Drawing.Point(412, 242);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(216, 31);
            this.btnPedido.TabIndex = 204;
            this.btnPedido.Text = "Novo Pedido ";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(634, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 31);
            this.btnClose.TabIndex = 205;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.Enabled = false;
            this.txtReceiptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptNumber.Location = new System.Drawing.Point(539, 195);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.Size = new System.Drawing.Size(92, 22);
            this.txtReceiptNumber.TabIndex = 203;
            this.txtReceiptNumber.Text = "0";
            this.txtReceiptNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReceiptNumber.TextChanged += new System.EventHandler(this.txtReceiptNumber_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(409, 197);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(78, 16);
            this.label31.TabIndex = 231;
            this.label31.Text = "Recibo # :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(638, 166);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 23);
            this.btnCalculate.TabIndex = 201;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRateApplied
            // 
            this.txtRateApplied.Enabled = false;
            this.txtRateApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateApplied.Location = new System.Drawing.Point(539, 140);
            this.txtRateApplied.Name = "txtRateApplied";
            this.txtRateApplied.Size = new System.Drawing.Size(92, 22);
            this.txtRateApplied.TabIndex = 198;
            this.txtRateApplied.Text = "0.00";
            this.txtRateApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(407, 143);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(117, 16);
            this.label30.TabIndex = 228;
            this.label30.Text = "Taxa Aplicada :";
            this.label30.Visible = false;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Gray;
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(412, 220);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(318, 19);
            this.label33.TabIndex = 226;
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPedido
            // 
            this.lblPedido.BackColor = System.Drawing.Color.Gray;
            this.lblPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.White;
            this.lblPedido.Location = new System.Drawing.Point(404, 113);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(326, 19);
            this.lblPedido.TabIndex = 227;
            this.lblPedido.Text = "Dados do Pedido";
            this.lblPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Enabled = false;
            this.txtOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.Location = new System.Drawing.Point(539, 167);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(92, 22);
            this.txtOrderTotal.TabIndex = 202;
            this.txtOrderTotal.Text = "0.00";
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(407, 171);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 16);
            this.label24.TabIndex = 230;
            this.label24.Text = "Valor Total :";
            // 
            // txtDays
            // 
            this.txtDays.Enabled = false;
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(505, 88);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(92, 22);
            this.txtDays.TabIndex = 197;
            this.txtDays.Text = "0";
            this.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(407, 88);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 16);
            this.label27.TabIndex = 225;
            this.label27.Text = "Dias :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(505, 61);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(225, 22);
            this.dtpEndDate.TabIndex = 196;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(407, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 16);
            this.label23.TabIndex = 224;
            this.label23.Text = "Data Final :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(505, 32);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(225, 22);
            this.dtpStartDate.TabIndex = 195;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(407, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 16);
            this.label21.TabIndex = 223;
            this.label21.Text = "Data Início";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Gray;
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(405, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(325, 19);
            this.lblData.TabIndex = 222;
            this.lblData.Text = "Datas da Locação";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(114, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 22);
            this.txtNome.TabIndex = 221;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 16);
            this.lblNome.TabIndex = 220;
            this.lblNome.Text = "Nome :";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(114, 61);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(283, 22);
            this.txtMarca.TabIndex = 219;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(9, 64);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(59, 16);
            this.lblMarca.TabIndex = 218;
            this.lblMarca.Text = "Marca :";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(114, 36);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(283, 22);
            this.txtPlaca.TabIndex = 194;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            this.txtPlaca.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 217;
            this.label16.Text = "Placa :";
            // 
            // lblCarro
            // 
            this.lblCarro.BackColor = System.Drawing.Color.Gray;
            this.lblCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarro.ForeColor = System.Drawing.Color.White;
            this.lblCarro.Location = new System.Drawing.Point(12, 9);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(387, 19);
            this.lblCarro.TabIndex = 216;
            this.lblCarro.Text = "Carro";
            this.lblCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAno
            // 
            this.txtAno.Enabled = false;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(114, 120);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(283, 22);
            this.txtAno.TabIndex = 233;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(9, 123);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(43, 16);
            this.lblAno.TabIndex = 232;
            this.lblAno.Text = "Ano :";
            // 
            // txtPortas
            // 
            this.txtPortas.Enabled = false;
            this.txtPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortas.Location = new System.Drawing.Point(114, 149);
            this.txtPortas.Name = "txtPortas";
            this.txtPortas.Size = new System.Drawing.Size(283, 22);
            this.txtPortas.TabIndex = 235;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.BackColor = System.Drawing.Color.Transparent;
            this.lblPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortas.Location = new System.Drawing.Point(9, 149);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(61, 16);
            this.lblPortas.TabIndex = 234;
            this.lblPortas.Text = "Portas :";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(114, 178);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(283, 22);
            this.txtCambio.TabIndex = 237;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(9, 178);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(69, 16);
            this.lblCambio.TabIndex = 236;
            this.lblCambio.Text = "Câmbio :";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(407, 143);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(57, 16);
            this.lblPreco.TabIndex = 238;
            this.lblPreco.Text = "Preço :";
            // 
            // txtQuilometragem
            // 
            this.txtQuilometragem.Enabled = false;
            this.txtQuilometragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuilometragem.Location = new System.Drawing.Point(138, 206);
            this.txtQuilometragem.Name = "txtQuilometragem";
            this.txtQuilometragem.Size = new System.Drawing.Size(259, 22);
            this.txtQuilometragem.TabIndex = 241;
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.BackColor = System.Drawing.Color.Transparent;
            this.lblQuilometragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuilometragem.Location = new System.Drawing.Point(9, 209);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(121, 16);
            this.lblQuilometragem.TabIndex = 240;
            this.lblQuilometragem.Text = "Quilometragem :";
            // 
            // txtCor
            // 
            this.txtCor.Enabled = false;
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(114, 235);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(283, 22);
            this.txtCor.TabIndex = 243;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(9, 238);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(40, 16);
            this.lblCor.TabIndex = 242;
            this.lblCor.Text = "Cor :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(407, 171);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 16);
            this.label26.TabIndex = 229;
            this.label26.Text = "Sub-Total:";
            this.label26.Visible = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(539, 167);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(69, 22);
            this.txtSubTotal.TabIndex = 200;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.Visible = false;
            // 
            // TelaAlugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AluguelDeCarros.Properties.Resources.resumo_de_fundo_com_um_desenho_geometrico_1048_1450;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 279);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtQuilometragem);
            this.Controls.Add(this.lblQuilometragem);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.txtPortas);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtReceiptNumber);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRateApplied);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaAlugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAlugar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtReceiptNumber;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRateApplied;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblPedido;
        public System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtPortas;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtQuilometragem;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}