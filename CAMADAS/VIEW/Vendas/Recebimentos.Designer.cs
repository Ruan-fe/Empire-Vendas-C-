namespace EmpireVendas
{
    partial class Recebimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recebimentos));
            this.dgvRecebimentos = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalReceber = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPendente = new System.Windows.Forms.Label();
            this.recebimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_status_recebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descstatusrecebimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstatusrecebimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecebimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recebimentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecebimentos
            // 
            this.dgvRecebimentos.AllowUserToAddRows = false;
            this.dgvRecebimentos.AllowUserToDeleteRows = false;
            this.dgvRecebimentos.AutoGenerateColumns = false;
            this.dgvRecebimentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecebimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecebimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecebimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecebimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvendaDataGridViewTextBoxColumn,
            this.descclienteDataGridViewTextBoxColumn,
            this.datacompraDataGridViewTextBoxColumn,
            this.datavencimentoDataGridViewTextBoxColumn,
            this.valor,
            this.desc_status_recebimento,
            this.descstatusrecebimentoDataGridViewTextBoxColumn,
            this.idcontaDataGridViewTextBoxColumn,
            this.idstatusrecebimentoDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn});
            this.dgvRecebimentos.DataSource = this.recebimentosBindingSource;
            this.dgvRecebimentos.EnableHeadersVisualStyles = false;
            this.dgvRecebimentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.dgvRecebimentos.Location = new System.Drawing.Point(61, 99);
            this.dgvRecebimentos.Name = "dgvRecebimentos";
            this.dgvRecebimentos.ReadOnly = true;
            this.dgvRecebimentos.RowHeadersVisible = false;
            this.dgvRecebimentos.RowHeadersWidth = 51;
            this.dgvRecebimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecebimentos.Size = new System.Drawing.Size(919, 308);
            this.dgvRecebimentos.TabIndex = 1;
            this.dgvRecebimentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecebimentos_CellFormatting);
            this.dgvRecebimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvRecebimentos_MouseClick);
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
            this.btnFiltrar.Location = new System.Drawing.Point(446, 22);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFiltrar.Size = new System.Drawing.Size(30, 29);
            this.btnFiltrar.TabIndex = 33;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Enabled = false;
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(117, 22);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(330, 29);
            this.txtBusca.TabIndex = 32;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(485, 22);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(49, 29);
            this.txtCliente.TabIndex = 58;
            this.txtCliente.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "CLIENTE";
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
            this.btnFinalizar.Location = new System.Drawing.Point(485, 509);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFinalizar.Size = new System.Drawing.Size(495, 50);
            this.btnFinalizar.TabIndex = 60;
            this.btnFinalizar.Text = "CONFIRMAR RECEBIMENTO";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(846, 459);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 24);
            this.label11.TabIndex = 78;
            this.label11.Text = "R$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(70, 459);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 18);
            this.label12.TabIndex = 77;
            this.label12.Text = "TOTAL À RECEBER";
            // 
            // lblTotalReceber
            // 
            this.lblTotalReceber.AutoSize = true;
            this.lblTotalReceber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.lblTotalReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReceber.ForeColor = System.Drawing.Color.White;
            this.lblTotalReceber.Location = new System.Drawing.Point(885, 459);
            this.lblTotalReceber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalReceber.Name = "lblTotalReceber";
            this.lblTotalReceber.Size = new System.Drawing.Size(21, 24);
            this.lblTotalReceber.TabIndex = 76;
            this.lblTotalReceber.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 449);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(919, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 80;
            this.label1.Text = "TOTAL NA CONTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(846, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 82;
            this.label3.Text = "R$";
            // 
            // lblTotalPendente
            // 
            this.lblTotalPendente.AutoSize = true;
            this.lblTotalPendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTotalPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPendente.ForeColor = System.Drawing.Color.White;
            this.lblTotalPendente.Location = new System.Drawing.Point(885, 416);
            this.lblTotalPendente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPendente.Name = "lblTotalPendente";
            this.lblTotalPendente.Size = new System.Drawing.Size(21, 24);
            this.lblTotalPendente.TabIndex = 81;
            this.lblTotalPendente.Text = "0";
            // 
            // recebimentosBindingSource
            // 
            this.recebimentosBindingSource.DataSource = typeof(EmpireVendas.CAMADAS.MODEL.Recebimentos);
            // 
            // idvendaDataGridViewTextBoxColumn
            // 
            this.idvendaDataGridViewTextBoxColumn.DataPropertyName = "id_venda";
            this.idvendaDataGridViewTextBoxColumn.HeaderText = "ID VENDA";
            this.idvendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvendaDataGridViewTextBoxColumn.Name = "idvendaDataGridViewTextBoxColumn";
            this.idvendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idvendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // descclienteDataGridViewTextBoxColumn
            // 
            this.descclienteDataGridViewTextBoxColumn.DataPropertyName = "desc_cliente";
            this.descclienteDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.descclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descclienteDataGridViewTextBoxColumn.Name = "descclienteDataGridViewTextBoxColumn";
            this.descclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.descclienteDataGridViewTextBoxColumn.Width = 250;
            // 
            // datacompraDataGridViewTextBoxColumn
            // 
            this.datacompraDataGridViewTextBoxColumn.DataPropertyName = "data_compra";
            this.datacompraDataGridViewTextBoxColumn.HeaderText = "COMPRA";
            this.datacompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datacompraDataGridViewTextBoxColumn.Name = "datacompraDataGridViewTextBoxColumn";
            this.datacompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.datacompraDataGridViewTextBoxColumn.Width = 150;
            // 
            // datavencimentoDataGridViewTextBoxColumn
            // 
            this.datavencimentoDataGridViewTextBoxColumn.DataPropertyName = "data_vencimento";
            this.datavencimentoDataGridViewTextBoxColumn.HeaderText = "VENCIMENTO";
            this.datavencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datavencimentoDataGridViewTextBoxColumn.Name = "datavencimentoDataGridViewTextBoxColumn";
            this.datavencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datavencimentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 120;
            // 
            // desc_status_recebimento
            // 
            this.desc_status_recebimento.DataPropertyName = "desc_status_recebimento";
            this.desc_status_recebimento.HeaderText = "STATUS";
            this.desc_status_recebimento.MinimumWidth = 6;
            this.desc_status_recebimento.Name = "desc_status_recebimento";
            this.desc_status_recebimento.ReadOnly = true;
            this.desc_status_recebimento.Width = 120;
            // 
            // descstatusrecebimentoDataGridViewTextBoxColumn
            // 
            this.descstatusrecebimentoDataGridViewTextBoxColumn.DataPropertyName = "desc_status_recebimento";
            this.descstatusrecebimentoDataGridViewTextBoxColumn.HeaderText = "STATUS_ATA";
            this.descstatusrecebimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descstatusrecebimentoDataGridViewTextBoxColumn.Name = "descstatusrecebimentoDataGridViewTextBoxColumn";
            this.descstatusrecebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descstatusrecebimentoDataGridViewTextBoxColumn.Visible = false;
            this.descstatusrecebimentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // idcontaDataGridViewTextBoxColumn
            // 
            this.idcontaDataGridViewTextBoxColumn.DataPropertyName = "id_conta";
            this.idcontaDataGridViewTextBoxColumn.HeaderText = "id_conta";
            this.idcontaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcontaDataGridViewTextBoxColumn.Name = "idcontaDataGridViewTextBoxColumn";
            this.idcontaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcontaDataGridViewTextBoxColumn.Visible = false;
            this.idcontaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idstatusrecebimentoDataGridViewTextBoxColumn
            // 
            this.idstatusrecebimentoDataGridViewTextBoxColumn.DataPropertyName = "id_status_recebimento";
            this.idstatusrecebimentoDataGridViewTextBoxColumn.HeaderText = "id_status_recebimento";
            this.idstatusrecebimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstatusrecebimentoDataGridViewTextBoxColumn.Name = "idstatusrecebimentoDataGridViewTextBoxColumn";
            this.idstatusrecebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstatusrecebimentoDataGridViewTextBoxColumn.Visible = false;
            this.idstatusrecebimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Visible = false;
            this.idclienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // Recebimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1019, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPendente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalReceber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvRecebimentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recebimentos";
            this.Text = "Recebimentos";
            this.Load += new System.EventHandler(this.Recebimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecebimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recebimentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.BindingSource recebimentosBindingSource;
        public System.Windows.Forms.DataGridView dgvRecebimentos;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalReceber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_status_recebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descstatusrecebimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatusrecebimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
    }
}