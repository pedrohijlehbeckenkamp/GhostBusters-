﻿namespace GhostBusters_Forms.Usuário_Comum
{
    partial class InicUsuarioComum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picBase64 = new System.Windows.Forms.PictureBox();
            this.linkLEdit = new System.Windows.Forms.LinkLabel();
            this.btnAdcTicket = new System.Windows.Forms.Button();
            this.dgVisualizar = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNomeUC = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBase64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // picBase64
            // 
            this.picBase64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBase64.Location = new System.Drawing.Point(12, 25);
            this.picBase64.Name = "picBase64";
            this.picBase64.Size = new System.Drawing.Size(111, 98);
            this.picBase64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBase64.TabIndex = 34;
            this.picBase64.TabStop = false;
            // 
            // linkLEdit
            // 
            this.linkLEdit.AutoSize = true;
            this.linkLEdit.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLEdit.LinkColor = System.Drawing.Color.Navy;
            this.linkLEdit.Location = new System.Drawing.Point(9, 126);
            this.linkLEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLEdit.Name = "linkLEdit";
            this.linkLEdit.Size = new System.Drawing.Size(58, 13);
            this.linkLEdit.TabIndex = 35;
            this.linkLEdit.TabStop = true;
            this.linkLEdit.Text = "Alterar foto";
            this.linkLEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLEdit_LinkClicked);
            // 
            // btnAdcTicket
            // 
            this.btnAdcTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdcTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcTicket.ForeColor = System.Drawing.Color.White;
            this.btnAdcTicket.Location = new System.Drawing.Point(404, 100);
            this.btnAdcTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdcTicket.Name = "btnAdcTicket";
            this.btnAdcTicket.Size = new System.Drawing.Size(116, 39);
            this.btnAdcTicket.TabIndex = 36;
            this.btnAdcTicket.Text = "Adicionar Ticket";
            this.btnAdcTicket.UseVisualStyleBackColor = false;
            this.btnAdcTicket.Click += new System.EventHandler(this.BtnAdcTicket_Click);
            // 
            // dgVisualizar
            // 
            this.dgVisualizar.AllowUserToDeleteRows = false;
            this.dgVisualizar.AllowUserToResizeColumns = false;
            this.dgVisualizar.AllowUserToResizeRows = false;
            this.dgVisualizar.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgVisualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgVisualizar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.CodTicket,
            this.Status,
            this.Categoria,
            this.Descricao,
            this.Tecnico});
            this.dgVisualizar.EnableHeadersVisualStyles = false;
            this.dgVisualizar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVisualizar.Location = new System.Drawing.Point(12, 157);
            this.dgVisualizar.Name = "dgVisualizar";
            this.dgVisualizar.ReadOnly = true;
            this.dgVisualizar.RowHeadersVisible = false;
            this.dgVisualizar.RowHeadersWidth = 51;
            this.dgVisualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualizar.Size = new System.Drawing.Size(736, 215);
            this.dgVisualizar.TabIndex = 37;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(524, 100);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 39);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "Editar Ticket";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblNomeUC
            // 
            this.lblNomeUC.AutoSize = true;
            this.lblNomeUC.Location = new System.Drawing.Point(156, 58);
            this.lblNomeUC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeUC.Name = "lblNomeUC";
            this.lblNomeUC.Size = new System.Drawing.Size(39, 13);
            this.lblNomeUC.TabIndex = 39;
            this.lblNomeUC.Text = "NOME";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(11, 9);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "Date";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(156, 88);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "EMAIL";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data de abertura";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Width = 125;
            // 
            // CodTicket
            // 
            this.CodTicket.HeaderText = "Ticket";
            this.CodTicket.MinimumWidth = 6;
            this.CodTicket.Name = "CodTicket";
            this.CodTicket.ReadOnly = true;
            this.CodTicket.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodTicket.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Categoria.Width = 125;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descricao.Width = 125;
            // 
            // Tecnico
            // 
            this.Tecnico.HeaderText = "Técnico";
            this.Tecnico.MinimumWidth = 6;
            this.Tecnico.Name = "Tecnico";
            this.Tecnico.ReadOnly = true;
            this.Tecnico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tecnico.Width = 125;
            // 
            // InicUsuarioComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(760, 384);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNomeUC);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgVisualizar);
            this.Controls.Add(this.btnAdcTicket);
            this.Controls.Add(this.linkLEdit);
            this.Controls.Add(this.picBase64);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InicUsuarioComum";
            this.Text = "Tela de usuario";
            this.Load += new System.EventHandler(this.TelaUsuarioComum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBase64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBase64;
        private System.Windows.Forms.LinkLabel linkLEdit;
        private System.Windows.Forms.Button btnAdcTicket;
        private System.Windows.Forms.DataGridView dgVisualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblNomeUC;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
    }
}