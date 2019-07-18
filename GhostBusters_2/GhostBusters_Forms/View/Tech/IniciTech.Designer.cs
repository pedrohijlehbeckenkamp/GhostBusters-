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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.lblTextD = new System.Windows.Forms.Label();
            this.lblEmailTec = new System.Windows.Forms.Label();
            this.lblNomeTec = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.linkLEdit = new System.Windows.Forms.LinkLabel();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnConfig.Location = new System.Drawing.Point(731, 135);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(169, 54);
            this.btnConfig.TabIndex = 12;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPerfil.Location = new System.Drawing.Point(42, 32);
            this.pbPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(171, 157);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 27;
            this.pbPerfil.TabStop = false;
            // 
            // lblTextD
            // 
            this.lblTextD.AllowDrop = true;
            this.lblTextD.AutoSize = true;
            this.lblTextD.ForeColor = System.Drawing.Color.Black;
            this.lblTextD.Location = new System.Drawing.Point(631, 23);
            this.lblTextD.Name = "lblTextD";
            this.lblTextD.Size = new System.Drawing.Size(156, 17);
            this.lblTextD.TabIndex = 48;
            this.lblTextD.Text = "Data e hora do acesso:";
            // 
            // lblEmailTec
            // 
            this.lblEmailTec.AutoSize = true;
            this.lblEmailTec.ForeColor = System.Drawing.Color.Black;
            this.lblEmailTec.Location = new System.Drawing.Point(258, 87);
            this.lblEmailTec.Name = "lblEmailTec";
            this.lblEmailTec.Size = new System.Drawing.Size(48, 17);
            this.lblEmailTec.TabIndex = 47;
            this.lblEmailTec.Text = "EMAIL";
            // 
            // lblNomeTec
            // 
            this.lblNomeTec.AutoSize = true;
            this.lblNomeTec.ForeColor = System.Drawing.Color.Black;
            this.lblNomeTec.Location = new System.Drawing.Point(257, 42);
            this.lblNomeTec.Name = "lblNomeTec";
            this.lblNomeTec.Size = new System.Drawing.Size(49, 17);
            this.lblNomeTec.TabIndex = 46;
            this.lblNomeTec.Text = "NOME";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(822, 23);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Date";
            // 
            // linkLEdit
            // 
            this.linkLEdit.AutoSize = true;
            this.linkLEdit.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLEdit.LinkColor = System.Drawing.Color.Navy;
            this.linkLEdit.Location = new System.Drawing.Point(39, 193);
            this.linkLEdit.Name = "linkLEdit";
            this.linkLEdit.Size = new System.Drawing.Size(78, 17);
            this.linkLEdit.TabIndex = 49;
            this.linkLEdit.TabStop = true;
            this.linkLEdit.Text = "Alterar foto";
            this.linkLEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLEdit_LinkClicked);
            // 
            // dgVisualizar
            // 
            this.dgVisualizar.AllowUserToDeleteRows = false;
            this.dgVisualizar.AllowUserToResizeColumns = false;
            this.dgVisualizar.AllowUserToResizeRows = false;
            this.dgVisualizar.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgVisualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisualizar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.CodTicket,
            this.Categoria,
            this.Status,
            this.Usuario,
            this.Descricao,
            this.Tecnico});
            this.dgVisualizar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVisualizar.Location = new System.Drawing.Point(42, 232);
            this.dgVisualizar.Margin = new System.Windows.Forms.Padding(4);
            this.dgVisualizar.MultiSelect = false;
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(858, 309);
            this.dgVisualizar.TabIndex = 50;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data de abertura";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 125;
            // 
            // CodTicket
            // 
            this.CodTicket.HeaderText = "Ticket";
            this.CodTicket.MinimumWidth = 6;
            this.CodTicket.Name = "CodTicket";
            this.CodTicket.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodTicket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodTicket.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 125;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 125;
            // 
            // Tecnico
            // 
            this.Tecnico.HeaderText = "Técnico";
            this.Tecnico.MinimumWidth = 6;
            this.Tecnico.Name = "Tecnico";
            this.Tecnico.Width = 125;
            // 
            // IniciTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(953, 554);
            this.Controls.Add(this.dgVisualizar);
            this.Controls.Add(this.linkLEdit);
            this.Controls.Add(this.lblTextD);
            this.Controls.Add(this.lblEmailTec);
            this.Controls.Add(this.lblNomeTec);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.btnConfig);
            this.Name = "IniciTech";
            this.Text = "Perfil Tecnico";
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
        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
    }
}