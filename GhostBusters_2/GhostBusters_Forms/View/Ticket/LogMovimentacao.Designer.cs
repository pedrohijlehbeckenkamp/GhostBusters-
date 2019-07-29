namespace GhostBusters_Forms.View.Ticket
{
    partial class LogMovimentacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Status_Ant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Status_New = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log De Movimentação";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Usuario,
            this.Nome_Status_Ant,
            this.Nome_Status_New,
            this.Data_log});
            this.dataGridView1.Location = new System.Drawing.Point(25, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 196);
            this.dataGridView1.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo_Log";
            this.Codigo.HeaderText = "Codigo_Log";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario Aleterou";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Nome_Status_Ant
            // 
            this.Nome_Status_Ant.DataPropertyName = "Nome_Status_Ant";
            this.Nome_Status_Ant.HeaderText = "Status Ant";
            this.Nome_Status_Ant.Name = "Nome_Status_Ant";
            this.Nome_Status_Ant.ReadOnly = true;
            // 
            // Nome_Status_New
            // 
            this.Nome_Status_New.DataPropertyName = "Nome_Status_New";
            this.Nome_Status_New.HeaderText = "Status Novo";
            this.Nome_Status_New.Name = "Nome_Status_New";
            this.Nome_Status_New.ReadOnly = true;
            // 
            // Data_log
            // 
            this.Data_log.DataPropertyName = "Data_log";
            this.Data_log.HeaderText = "Data Log";
            this.Data_log.Name = "Data_log";
            this.Data_log.ReadOnly = true;
            // 
            // LogMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(595, 297);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogMovimentacao";
            this.Text = "Log de movimentacao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Status_Ant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Status_New;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_log;
    }
}