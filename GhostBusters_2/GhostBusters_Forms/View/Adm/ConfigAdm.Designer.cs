namespace GhostBusters_Forms.View.Adm
{
    partial class ConfigAdm
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
            this.btnVisualizarStatus = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.btnVisualizarCategoria = new System.Windows.Forms.Button();
            this.btnVisualizarPerfil = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizarStatus
            // 
            this.btnVisualizarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVisualizarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarStatus.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarStatus.Location = new System.Drawing.Point(32, 27);
            this.btnVisualizarStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizarStatus.Name = "btnVisualizarStatus";
            this.btnVisualizarStatus.Size = new System.Drawing.Size(116, 39);
            this.btnVisualizarStatus.TabIndex = 37;
            this.btnVisualizarStatus.Text = "Visualizar status";
            this.btnVisualizarStatus.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(475, 86);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 39);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Location = new System.Drawing.Point(475, 151);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(116, 39);
            this.btnPerfil.TabIndex = 39;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(475, 26);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(116, 39);
            this.btnCadastrar.TabIndex = 40;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // dgVisualizar
            // 
            this.dgVisualizar.AllowUserToDeleteRows = false;
            this.dgVisualizar.AllowUserToResizeColumns = false;
            this.dgVisualizar.AllowUserToResizeRows = false;
            this.dgVisualizar.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgVisualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.Nome,
            this.Codigo});
            this.dgVisualizar.EnableHeadersVisualStyles = false;
            this.dgVisualizar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVisualizar.Location = new System.Drawing.Point(191, 52);
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.ReadOnly = true;
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(242, 110);
            this.dgVisualizar.TabIndex = 41;
            // 
            // btnVisualizarCategoria
            // 
            this.btnVisualizarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVisualizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarCategoria.Location = new System.Drawing.Point(32, 86);
            this.btnVisualizarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizarCategoria.Name = "btnVisualizarCategoria";
            this.btnVisualizarCategoria.Size = new System.Drawing.Size(116, 39);
            this.btnVisualizarCategoria.TabIndex = 42;
            this.btnVisualizarCategoria.Text = "Visualizar categoria";
            this.btnVisualizarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnVisualizarPerfil
            // 
            this.btnVisualizarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVisualizarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarPerfil.Location = new System.Drawing.Point(32, 151);
            this.btnVisualizarPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizarPerfil.Name = "btnVisualizarPerfil";
            this.btnVisualizarPerfil.Size = new System.Drawing.Size(116, 39);
            this.btnVisualizarPerfil.TabIndex = 43;
            this.btnVisualizarPerfil.Text = "Visualizar Perfil";
            this.btnVisualizarPerfil.UseVisualStyleBackColor = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 120;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.Width = 120;
            // 
            // ConfigAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(656, 224);
            this.Controls.Add(this.btnVisualizarPerfil);
            this.Controls.Add(this.btnVisualizarCategoria);
            this.Controls.Add(this.dgVisualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVisualizarStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigAdm";
            this.Text = "Configuração do administrador";
            this.Load += new System.EventHandler(this.ConfigAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarStatus;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.Button btnVisualizarCategoria;
        private System.Windows.Forms.Button btnVisualizarPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
    }
}