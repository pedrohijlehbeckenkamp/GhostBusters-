namespace GhostBusters_Forms.Adm
{
    partial class TelaPrincipalAdm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.NomeAdimin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVisualizar
            // 
            this.dgVisualizar.AllowUserToDeleteRows = false;
            this.dgVisualizar.AllowUserToResizeColumns = false;
            this.dgVisualizar.AllowUserToResizeRows = false;
            this.dgVisualizar.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgVisualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisualizar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgVisualizar.Location = new System.Drawing.Point(49, 139);
            this.dgVisualizar.MultiSelect = false;
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(702, 267);
            this.dgVisualizar.TabIndex = 3;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data de abertura";
            this.Data.Name = "Data";
            // 
            // CodTicket
            // 
            this.CodTicket.HeaderText = "Ticket";
            this.CodTicket.Name = "CodTicket";
            this.CodTicket.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodTicket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Tecnico
            // 
            this.Tecnico.HeaderText = "Técnico";
            this.Tecnico.Name = "Tecnico";
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTicket.Location = new System.Drawing.Point(49, 49);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(108, 44);
            this.btnNewTicket.TabIndex = 0;
            this.btnNewTicket.Text = "Abrir ticket";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.BtnNewTicket_Click);
            // 
            // pbPerfil
            // 
            this.pbPerfil.Location = new System.Drawing.Point(598, 21);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(108, 92);
            this.pbPerfil.TabIndex = 26;
            this.pbPerfil.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(190, 49);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 44);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir ticket";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(471, 49);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(121, 44);
            this.btnConfig.TabIndex = 27;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // NomeAdimin
            // 
            this.NomeAdimin.AutoSize = true;
            this.NomeAdimin.Location = new System.Drawing.Point(25, 9);
            this.NomeAdimin.Name = "NomeAdimin";
            this.NomeAdimin.Size = new System.Drawing.Size(35, 13);
            this.NomeAdimin.TabIndex = 28;
            this.NomeAdimin.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 29;
            this.button1.Text = "Cadastro Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TelaPrincipalAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NomeAdimin);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.btnNewTicket);
            this.Controls.Add(this.dgVisualizar);
            this.Name = "TelaPrincipalAdm";
            this.Text = "Tela principal do Adm";
            this.Load += new System.EventHandler(this.TelaPrincipalAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
        private System.Windows.Forms.Label NomeAdimin;
        private System.Windows.Forms.Button button1;
    }
}