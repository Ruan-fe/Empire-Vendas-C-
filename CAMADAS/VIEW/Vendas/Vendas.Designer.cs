﻿namespace EmpireVendas
{
    partial class Vendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtValorUni = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSubTotal = new System.Windows.Forms.Label();
            this.btnCalcularDesconto = new System.Windows.Forms.PictureBox();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rdbNomeProduto = new System.Windows.Forms.RadioButton();
            this.rdbIdProduto = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdcCliente = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdTipoVenda = new System.Windows.Forms.TextBox();
            this.cmbTipoVenda = new System.Windows.Forms.ComboBox();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desccategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcularDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdcCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AllowUserToAddRows = false;
            this.dgvItensVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvItensVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItensVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PRODUTO,
            this.quantidade,
            this.valorUni,
            this.valortotal});
            this.dgvItensVenda.EnableHeadersVisualStyles = false;
            this.dgvItensVenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.dgvItensVenda.Location = new System.Drawing.Point(528, 83);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItensVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItensVenda.RowHeadersVisible = false;
            this.dgvItensVenda.RowHeadersWidth = 51;
            this.dgvItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensVenda.Size = new System.Drawing.Size(495, 172);
            this.dgvItensVenda.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID PROD";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // PRODUTO
            // 
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.MinimumWidth = 6;
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 135;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "QTD";
            this.quantidade.MinimumWidth = 6;
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 60;
            // 
            // valorUni
            // 
            this.valorUni.HeaderText = "VALOR U.";
            this.valorUni.MinimumWidth = 6;
            this.valorUni.Name = "valorUni";
            this.valorUni.ReadOnly = true;
            // 
            // valortotal
            // 
            this.valortotal.HeaderText = "VALOR T.";
            this.valortotal.MinimumWidth = 6;
            this.valortotal.Name = "valortotal";
            this.valortotal.ReadOnly = true;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbProduto.Location = new System.Drawing.Point(75, 82);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(346, 32);
            this.cmbProduto.TabIndex = 12;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(75, 131);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(101, 28);
            this.txtQtd.TabIndex = 13;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // txtValorUni
            // 
            this.txtValorUni.Enabled = false;
            this.txtValorUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUni.Location = new System.Drawing.Point(228, 131);
            this.txtValorUni.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(101, 28);
            this.txtValorUni.TabIndex = 14;
            this.txtValorUni.TextChanged += new System.EventHandler(this.txtValorUni_TextChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(390, 131);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(101, 28);
            this.txtValorTotal.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "PRODUTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "QTD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "V. UNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "V. TOTAL";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(75, 174);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInserir.Size = new System.Drawing.Size(416, 35);
            this.btnInserir.TabIndex = 41;
            this.btnInserir.Text = "INSERIR PRODUTO";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(528, 527);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFinalizar.Size = new System.Drawing.Size(495, 50);
            this.btnFinalizar.TabIndex = 42;
            this.btnFinalizar.Text = "FINALIZAR VENDA";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(75, 219);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemover.Size = new System.Drawing.Size(416, 35);
            this.btnRemover.TabIndex = 43;
            this.btnRemover.Text = "REMOVER PRODUTO";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(944, 342);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(79, 28);
            this.txtDesconto.TabIndex = 47;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 42);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.AutoSize = true;
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.White;
            this.txtSubTotal.Location = new System.Drawing.Point(924, 296);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(21, 24);
            this.txtSubTotal.TabIndex = 49;
            this.txtSubTotal.Text = "0";
            // 
            // btnCalcularDesconto
            // 
            this.btnCalcularDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularDesconto.Image")));
            this.btnCalcularDesconto.Location = new System.Drawing.Point(870, 342);
            this.btnCalcularDesconto.Name = "btnCalcularDesconto";
            this.btnCalcularDesconto.Size = new System.Drawing.Size(32, 27);
            this.btnCalcularDesconto.TabIndex = 50;
            this.btnCalcularDesconto.TabStop = false;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbVendedor.Location = new System.Drawing.Point(680, 440);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(310, 28);
            this.cmbVendedor.TabIndex = 52;
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 448);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "VENDEDOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 489);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "CLIENTE";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(626, 440);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(49, 26);
            this.txtVendedor.TabIndex = 55;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(8, 577);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 57;
            this.dtpData.Visible = false;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Enabled = false;
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(426, 85);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(65, 28);
            this.txtIdProduto.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(549, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "SUBTOTAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(879, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 60;
            this.label8.Text = "R$";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.descprodutoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.valor,
            this.id_produto,
            this.desc_produto,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.desccategoriaDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.produtosBindingSource;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.dgvProdutos.Location = new System.Drawing.Point(75, 320);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(416, 243);
            this.dgvProdutos.TabIndex = 62;
            this.dgvProdutos.DoubleClick += new System.EventHandler(this.dgvProdutos_DoubleClick);
            this.dgvProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProdutos_MouseClick);
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Visible = false;
            this.valor.Width = 125;
            // 
            // id_produto
            // 
            this.id_produto.DataPropertyName = "id_produto";
            this.id_produto.HeaderText = "id_produto";
            this.id_produto.MinimumWidth = 6;
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Visible = false;
            this.id_produto.Width = 125;
            // 
            // desc_produto
            // 
            this.desc_produto.DataPropertyName = "desc_produto";
            this.desc_produto.HeaderText = "desc_produto";
            this.desc_produto.MinimumWidth = 6;
            this.desc_produto.Name = "desc_produto";
            this.desc_produto.ReadOnly = true;
            this.desc_produto.Visible = false;
            this.desc_produto.Width = 125;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(75, 290);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(333, 22);
            this.txtBusca.TabIndex = 63;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(413, 290);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFiltrar.Size = new System.Drawing.Size(30, 22);
            this.btnFiltrar.TabIndex = 64;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // rdbNomeProduto
            // 
            this.rdbNomeProduto.AutoSize = true;
            this.rdbNomeProduto.Checked = true;
            this.rdbNomeProduto.Location = new System.Drawing.Point(140, 268);
            this.rdbNomeProduto.Name = "rdbNomeProduto";
            this.rdbNomeProduto.Size = new System.Drawing.Size(108, 17);
            this.rdbNomeProduto.TabIndex = 65;
            this.rdbNomeProduto.TabStop = true;
            this.rdbNomeProduto.Text = "Nome do Produto";
            this.rdbNomeProduto.UseVisualStyleBackColor = true;
            this.rdbNomeProduto.CheckedChanged += new System.EventHandler(this.rdbNomeProduto_CheckedChanged);
            // 
            // rdbIdProduto
            // 
            this.rdbIdProduto.AutoSize = true;
            this.rdbIdProduto.Location = new System.Drawing.Point(284, 268);
            this.rdbIdProduto.Name = "rdbIdProduto";
            this.rdbIdProduto.Size = new System.Drawing.Size(113, 17);
            this.rdbIdProduto.TabIndex = 66;
            this.rdbIdProduto.Text = "Código do Produto";
            this.rdbIdProduto.UseVisualStyleBackColor = true;
            this.rdbIdProduto.CheckedChanged += new System.EventHandler(this.rdbIdProduto_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "BUSCAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(907, 343);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 24);
            this.label9.TabIndex = 69;
            this.label9.Text = "R$";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(449, 286);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(19, 32);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtualizar.TabIndex = 70;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(879, 388);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 24);
            this.label11.TabIndex = 74;
            this.label11.Text = "R$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(549, 391);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 73;
            this.label12.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(924, 388);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(21, 24);
            this.txtTotal.TabIndex = 72;
            this.txtTotal.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(528, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(495, 42);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // btnAdcCliente
            // 
            this.btnAdcCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdcCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcCliente.Image")));
            this.btnAdcCliente.Location = new System.Drawing.Point(996, 481);
            this.btnAdcCliente.Name = "btnAdcCliente";
            this.btnAdcCliente.Size = new System.Drawing.Size(27, 26);
            this.btnAdcCliente.TabIndex = 75;
            this.btnAdcCliente.TabStop = false;
            this.btnAdcCliente.Click += new System.EventHandler(this.btnAdcCliente_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(528, 426);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(531, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "T. DE VENDA";
            // 
            // txtIdTipoVenda
            // 
            this.txtIdTipoVenda.Enabled = false;
            this.txtIdTipoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTipoVenda.Location = new System.Drawing.Point(610, 33);
            this.txtIdTipoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdTipoVenda.Name = "txtIdTipoVenda";
            this.txtIdTipoVenda.Size = new System.Drawing.Size(22, 26);
            this.txtIdTipoVenda.TabIndex = 79;
            // 
            // cmbTipoVenda
            // 
            this.cmbTipoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVenda.FormattingEnabled = true;
            this.cmbTipoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTipoVenda.Location = new System.Drawing.Point(637, 32);
            this.cmbTipoVenda.Name = "cmbTipoVenda";
            this.cmbTipoVenda.Size = new System.Drawing.Size(127, 28);
            this.cmbTipoVenda.TabIndex = 80;
            this.cmbTipoVenda.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVenda_SelectedIndexChanged);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idprodutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprodutoDataGridViewTextBoxColumn.Width = 50;
            // 
            // descprodutoDataGridViewTextBoxColumn
            // 
            this.descprodutoDataGridViewTextBoxColumn.DataPropertyName = "desc_produto";
            this.descprodutoDataGridViewTextBoxColumn.HeaderText = "PRODUTO";
            this.descprodutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descprodutoDataGridViewTextBoxColumn.Name = "descprodutoDataGridViewTextBoxColumn";
            this.descprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descprodutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "PREÇO";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "ESTOQUE";
            this.estoqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn.Width = 85;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn.Visible = false;
            this.idCategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // desccategoriaDataGridViewTextBoxColumn
            // 
            this.desccategoriaDataGridViewTextBoxColumn.DataPropertyName = "desc_categoria";
            this.desccategoriaDataGridViewTextBoxColumn.HeaderText = "desc_categoria";
            this.desccategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.desccategoriaDataGridViewTextBoxColumn.Name = "desccategoriaDataGridViewTextBoxColumn";
            this.desccategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.desccategoriaDataGridViewTextBoxColumn.Visible = false;
            this.desccategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(EmpireVendas.CAMADAS.MODEL.Produtos);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbCliente.Location = new System.Drawing.Point(680, 479);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(310, 28);
            this.cmbCliente.TabIndex = 51;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(626, 479);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(49, 26);
            this.txtCliente.TabIndex = 56;
            // 
            // Vendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1035, 600);
            this.Controls.Add(this.cmbTipoVenda);
            this.Controls.Add(this.txtIdTipoVenda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnAdcCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rdbIdProduto);
            this.Controls.Add(this.rdbNomeProduto);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnCalcularDesconto);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValorUni);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.dgvItensVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcularDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdcCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtValorUni;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtSubTotal;
        private System.Windows.Forms.PictureBox btnCalcularDesconto;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton rdbNomeProduto;
        private System.Windows.Forms.RadioButton rdbIdProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desccategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnAdcCliente;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdTipoVenda;
        private System.Windows.Forms.ComboBox cmbTipoVenda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtCliente;
    }
}