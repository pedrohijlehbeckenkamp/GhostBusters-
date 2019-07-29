namespace GhostBusters_Forms.View.Tech
{
    partial class IniciTech
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.lblTextD = new System.Windows.Forms.Label();
            this.lblEmailTec = new System.Windows.Forms.Label();
            this.lblNomeTec = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.linkLEdit = new System.Windows.Forms.LinkLabel();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.Codigochamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Chamado_finalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdcTicket = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.maskedCod = new System.Windows.Forms.MaskedTextBox();
            this.tbConteudo = new System.Windows.Forms.TextBox();
            this.cbGeral = new System.Windows.Forms.ComboBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.BtAlterarStatus = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(197, 185);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(188, 32);
            this.btnConfig.TabIndex = 12;
            this.btnConfig.Text = "Finalizar atendimento";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPerfil.Location = new System.Drawing.Point(32, 19);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(129, 128);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 27;
            this.pbPerfil.TabStop = false;
            // 
            // lblTextD
            // 
            this.lblTextD.AllowDrop = true;
            this.lblTextD.AutoSize = true;
            this.lblTextD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextD.ForeColor = System.Drawing.Color.Black;
            this.lblTextD.Location = new System.Drawing.Point(427, 19);
            this.lblTextD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextD.Name = "lblTextD";
            this.lblTextD.Size = new System.Drawing.Size(133, 15);
            this.lblTextD.TabIndex = 48;
            this.lblTextD.Text = "Data e hora do acesso:";
            // 
            // lblEmailTec
            // 
            this.lblEmailTec.AutoSize = true;
            this.lblEmailTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTec.ForeColor = System.Drawing.Color.Black;
            this.lblEmailTec.Location = new System.Drawing.Point(272, 70);
            this.lblEmailTec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailTec.Name = "lblEmailTec";
            this.lblEmailTec.Size = new System.Drawing.Size(58, 20);
            this.lblEmailTec.TabIndex = 47;
            this.lblEmailTec.Text = "EMAIL";
            // 
            // lblNomeTec
            // 
            this.lblNomeTec.AutoSize = true;
            this.lblNomeTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTec.ForeColor = System.Drawing.Color.Black;
            this.lblNomeTec.Location = new System.Drawing.Point(272, 30);
            this.lblNomeTec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeTec.Name = "lblNomeTec";
            this.lblNomeTec.Size = new System.Drawing.Size(56, 20);
            this.lblNomeTec.TabIndex = 46;
            this.lblNomeTec.Text = "NOME";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(572, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Date";
            // 
            // linkLEdit
            // 
            this.linkLEdit.AutoSize = true;
            this.linkLEdit.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLEdit.LinkColor = System.Drawing.Color.Navy;
            this.linkLEdit.Location = new System.Drawing.Point(38, 157);
            this.linkLEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLEdit.Name = "linkLEdit";
            this.linkLEdit.Size = new System.Drawing.Size(58, 13);
            this.linkLEdit.TabIndex = 49;
            this.linkLEdit.TabStop = true;
            this.linkLEdit.Text = "Alterar foto";
            this.linkLEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLEdit_LinkClicked);
            // 
            // linkPerfil
            // 
            this.linkPerfil.AutoSize = true;
            this.linkPerfil.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkPerfil.LinkColor = System.Drawing.Color.Navy;
            this.linkPerfil.Location = new System.Drawing.Point(38, 179);
            this.linkPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(76, 13);
            this.linkPerfil.TabIndex = 51;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Visualizar perfil";
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPerfil_LinkClicked);
            // 
            // dgVisualizar
            // 
            this.dgVisualizar.AllowUserToDeleteRows = false;
            this.dgVisualizar.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgVisualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisualizar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigochamado,
            this.NomeUsuario,
            this.NomePerfil,
            this.Titulo,
            this.NomeTech,
            this.nomeCategoria,
            this.Nomestatus,
            this.Data_Chamado,
            this.Data_Chamado_finalizado});
            this.dgVisualizar.EnableHeadersVisualStyles = false;
            this.dgVisualizar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgVisualizar.Location = new System.Drawing.Point(12, 230);
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.ReadOnly = true;
            this.dgVisualizar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisualizar.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgVisualizar.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(593, 173);
            this.dgVisualizar.TabIndex = 52;
            // 
            // Codigochamado
            // 
            this.Codigochamado.DataPropertyName = "Codigo_chamado";
            this.Codigochamado.HeaderText = "Codigo chamado";
            this.Codigochamado.MinimumWidth = 6;
            this.Codigochamado.Name = "Codigochamado";
            this.Codigochamado.ReadOnly = true;
            this.Codigochamado.Width = 125;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.DataPropertyName = "NomeUsuario2";
            this.NomeUsuario.HeaderText = "Usuario";
            this.NomeUsuario.MinimumWidth = 6;
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.ReadOnly = true;
            this.NomeUsuario.Width = 125;
            // 
            // NomePerfil
            // 
            this.NomePerfil.DataPropertyName = "NomePerfil";
            this.NomePerfil.HeaderText = "Nome Perfil";
            this.NomePerfil.MinimumWidth = 6;
            this.NomePerfil.Name = "NomePerfil";
            this.NomePerfil.ReadOnly = true;
            this.NomePerfil.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 125;
            // 
            // NomeTech
            // 
            this.NomeTech.DataPropertyName = "NomeTech";
            this.NomeTech.HeaderText = "Tecnico";
            this.NomeTech.MinimumWidth = 6;
            this.NomeTech.Name = "NomeTech";
            this.NomeTech.ReadOnly = true;
            this.NomeTech.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NomeTech.Width = 125;
            // 
            // nomeCategoria
            // 
            this.nomeCategoria.DataPropertyName = "nomeCategoria";
            this.nomeCategoria.HeaderText = "Categoria";
            this.nomeCategoria.MinimumWidth = 6;
            this.nomeCategoria.Name = "nomeCategoria";
            this.nomeCategoria.ReadOnly = true;
            this.nomeCategoria.Width = 125;
            // 
            // Nomestatus
            // 
            this.Nomestatus.DataPropertyName = "Nomestatus";
            this.Nomestatus.HeaderText = "Status";
            this.Nomestatus.MinimumWidth = 6;
            this.Nomestatus.Name = "Nomestatus";
            this.Nomestatus.ReadOnly = true;
            this.Nomestatus.Width = 125;
            // 
            // Data_Chamado
            // 
            this.Data_Chamado.DataPropertyName = "Data_Chamado";
            this.Data_Chamado.HeaderText = "Data Chamado";
            this.Data_Chamado.MinimumWidth = 6;
            this.Data_Chamado.Name = "Data_Chamado";
            this.Data_Chamado.ReadOnly = true;
            this.Data_Chamado.Width = 125;
            // 
            // Data_Chamado_finalizado
            // 
            this.Data_Chamado_finalizado.DataPropertyName = "Data_Chamado_finalizado";
            this.Data_Chamado_finalizado.HeaderText = "Finalizado ";
            this.Data_Chamado_finalizado.MinimumWidth = 6;
            this.Data_Chamado_finalizado.Name = "Data_Chamado_finalizado";
            this.Data_Chamado_finalizado.ReadOnly = true;
            this.Data_Chamado_finalizado.Width = 125;
            // 
            // btnAdcTicket
            // 
            this.btnAdcTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdcTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdcTicket.ForeColor = System.Drawing.Color.White;
            this.btnAdcTicket.Location = new System.Drawing.Point(197, 130);
            this.btnAdcTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdcTicket.Name = "btnAdcTicket";
            this.btnAdcTicket.Size = new System.Drawing.Size(106, 32);
            this.btnAdcTicket.TabIndex = 53;
            this.btnAdcTicket.Text = "Editar Ticket";
            this.btnAdcTicket.UseVisualStyleBackColor = false;
            this.btnAdcTicket.Click += new System.EventHandler(this.BtnAdcTicket_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(647, 185);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(102, 32);
            this.btnOrder.TabIndex = 58;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Items.AddRange(new object[] {
            "Todos",
            "Código ticket",
            "Conteúdo",
            "Data",
            "Status",
            "Usuário",
            "Categoria"});
            this.cbOrderBy.Location = new System.Drawing.Point(628, 230);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(142, 21);
            this.cbOrderBy.TabIndex = 59;
            this.cbOrderBy.SelectedIndexChanged += new System.EventHandler(this.CbOrderBy_SelectedIndexChanged);
            // 
            // maskedCod
            // 
            this.maskedCod.Location = new System.Drawing.Point(685, 280);
            this.maskedCod.Mask = "00000";
            this.maskedCod.Name = "maskedCod";
            this.maskedCod.Size = new System.Drawing.Size(36, 20);
            this.maskedCod.TabIndex = 60;
            this.maskedCod.ValidatingType = typeof(int);
            // 
            // tbConteudo
            // 
            this.tbConteudo.Location = new System.Drawing.Point(628, 281);
            this.tbConteudo.Multiline = true;
            this.tbConteudo.Name = "tbConteudo";
            this.tbConteudo.Size = new System.Drawing.Size(142, 84);
            this.tbConteudo.TabIndex = 61;
            // 
            // cbGeral
            // 
            this.cbGeral.FormattingEnabled = true;
            this.cbGeral.Location = new System.Drawing.Point(628, 280);
            this.cbGeral.Name = "cbGeral";
            this.cbGeral.Size = new System.Drawing.Size(142, 21);
            this.cbGeral.TabIndex = 62;
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "yyyy - MM -dd";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(628, 281);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(142, 20);
            this.dtData.TabIndex = 68;
            this.dtData.Value = new System.DateTime(2019, 7, 25, 19, 11, 18, 0);
            // 
            // BtAlterarStatus
            // 
            this.BtAlterarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtAlterarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAlterarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtAlterarStatus.ForeColor = System.Drawing.Color.White;
            this.BtAlterarStatus.Location = new System.Drawing.Point(400, 185);
            this.BtAlterarStatus.Margin = new System.Windows.Forms.Padding(2);
            this.BtAlterarStatus.Name = "BtAlterarStatus";
            this.BtAlterarStatus.Size = new System.Drawing.Size(186, 32);
            this.BtAlterarStatus.TabIndex = 71;
            this.BtAlterarStatus.Text = "Alterar Status";
            this.BtAlterarStatus.UseVisualStyleBackColor = false;
            this.BtAlterarStatus.Click += new System.EventHandler(this.BtAlterarStatus_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Black;
            this.lbNome.Location = new System.Drawing.Point(213, 30);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 72;
            this.lbNome.Text = "Nome:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(213, 70);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 73;
            this.lbEmail.Text = "Email:";
            // 
            // IniciTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(795, 414);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.BtAlterarStatus);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.cbGeral);
            this.Controls.Add(this.tbConteudo);
            this.Controls.Add(this.maskedCod);
            this.Controls.Add(this.cbOrderBy);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAdcTicket);
            this.Controls.Add(this.dgVisualizar);
            this.Controls.Add(this.linkPerfil);
            this.Controls.Add(this.linkLEdit);
            this.Controls.Add(this.lblTextD);
            this.Controls.Add(this.lblEmailTec);
            this.Controls.Add(this.lblNomeTec);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.btnConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IniciTech";
            this.Text = "Perfil do técnico";
            this.Load += new System.EventHandler(this.InciTechcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblTextD;
        private System.Windows.Forms.Label lblEmailTec;
        private System.Windows.Forms.Label lblNomeTec;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.LinkLabel linkLEdit;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigochamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Chamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Chamado_finalizado;
        private System.Windows.Forms.Button btnAdcTicket;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.MaskedTextBox maskedCod;
        private System.Windows.Forms.TextBox tbConteudo;
        private System.Windows.Forms.ComboBox cbGeral;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button BtAlterarStatus;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEmail;
    }
}