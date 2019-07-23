namespace GhostBusters_Forms.View.Ticket
{
    partial class CadastrarTicket
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.butAddAnexo = new System.Windows.Forms.Button();
            this.butClearAnexo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.dgAddAnexo = new System.Windows.Forms.DataGridView();
            this.nomeAnexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbResultado = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbNomeCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddAnexo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(103, 167);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(147, 25);
            this.lbTitulo.TabIndex = 25;
            this.lbTitulo.Text = "Nome do ticket:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Enabled = false;
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(269, 167);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(300, 30);
            this.tbTitulo.TabIndex = 0;
            this.tbTitulo.TextChanged += new System.EventHandler(this.TbTitulo_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(348, 404);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 62);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(103, 274);
            this.lbDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(105, 25);
            this.lbDescricao.TabIndex = 28;
            this.lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(229, 274);
            this.tbDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescricao.MaxLength = 300;
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(340, 121);
            this.tbDescricao.TabIndex = 2;
            this.tbDescricao.TextChanged += new System.EventHandler(this.TbDescricao_TextChanged);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(16, 476);
            this.lbData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(144, 25);
            this.lbData.TabIndex = 30;
            this.lbData.Text = "Aqui vai a Data";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(269, 218);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(300, 33);
            this.cbCategoria.TabIndex = 1;
            // 
            // butAddAnexo
            // 
            this.butAddAnexo.Location = new System.Drawing.Point(767, 145);
            this.butAddAnexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAddAnexo.Name = "butAddAnexo";
            this.butAddAnexo.Size = new System.Drawing.Size(109, 32);
            this.butAddAnexo.TabIndex = 3;
            this.butAddAnexo.Text = "Add Anexo ";
            this.butAddAnexo.UseVisualStyleBackColor = true;
            this.butAddAnexo.Click += new System.EventHandler(this.ButAddAnexo_Click);
            // 
            // butClearAnexo
            // 
            this.butClearAnexo.Location = new System.Drawing.Point(916, 145);
            this.butClearAnexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butClearAnexo.Name = "butClearAnexo";
            this.butClearAnexo.Size = new System.Drawing.Size(117, 32);
            this.butClearAnexo.TabIndex = 4;
            this.butClearAnexo.Text = "Deleta Anexo";
            this.butClearAnexo.UseVisualStyleBackColor = true;
            this.butClearAnexo.Click += new System.EventHandler(this.ButExcluirAnexo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Categoria: ";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(16, 11);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(79, 25);
            this.lbUsuario.TabIndex = 31;
            this.lbUsuario.Text = "Usuario";
            // 
            // dgAddAnexo
            // 
            this.dgAddAnexo.AllowUserToDeleteRows = false;
            this.dgAddAnexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddAnexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeAnexo,
            this.Extensao});
            this.dgAddAnexo.Location = new System.Drawing.Point(728, 185);
            this.dgAddAnexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgAddAnexo.Name = "dgAddAnexo";
            this.dgAddAnexo.ReadOnly = true;
            this.dgAddAnexo.RowHeadersWidth = 51;
            this.dgAddAnexo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAddAnexo.Size = new System.Drawing.Size(325, 212);
            this.dgAddAnexo.TabIndex = 5;
            this.dgAddAnexo.DoubleClick += new System.EventHandler(this.DgAddAnexo_DoubleClick);
            // 
            // nomeAnexo
            // 
            this.nomeAnexo.DataPropertyName = "nomeAnexo";
            this.nomeAnexo.HeaderText = "Nome Anexo";
            this.nomeAnexo.MinimumWidth = 6;
            this.nomeAnexo.Name = "nomeAnexo";
            this.nomeAnexo.ReadOnly = true;
            this.nomeAnexo.Width = 125;
            // 
            // Extensao
            // 
            this.Extensao.DataPropertyName = "Extensao";
            this.Extensao.HeaderText = "Extensao";
            this.Extensao.MinimumWidth = 6;
            this.Extensao.Name = "Extensao";
            this.Extensao.ReadOnly = true;
            this.Extensao.Width = 125;
            // 
            // tbResultado
            // 
            this.tbResultado.AutoSize = true;
            this.tbResultado.Location = new System.Drawing.Point(553, 400);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(16, 17);
            this.tbResultado.TabIndex = 39;
            this.tbResultado.Text = "0";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(103, 129);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(68, 25);
            this.lbStatus.TabIndex = 41;
            this.lbStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(269, 126);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(300, 33);
            this.cbStatus.TabIndex = 40;
            // 
            // tbNomeCategoria
            // 
            this.tbNomeCategoria.Enabled = false;
            this.tbNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCategoria.Location = new System.Drawing.Point(269, 220);
            this.tbNomeCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNomeCategoria.Name = "tbNomeCategoria";
            this.tbNomeCategoria.Size = new System.Drawing.Size(300, 30);
            this.tbNomeCategoria.TabIndex = 42;
            // 
            // CadastrarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 528);
            this.Controls.Add(this.tbNomeCategoria);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.dgAddAnexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butClearAnexo);
            this.Controls.Add(this.butAddAnexo);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tbTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastrarTicket";
            this.Text = "Cadastrar ticket";
            this.Load += new System.EventHandler(this.CadastrarTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAddAnexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button butAddAnexo;
        private System.Windows.Forms.Button butClearAnexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.DataGridView dgAddAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensao;
        private System.Windows.Forms.Label tbResultado;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbNomeCategoria;
    }
}