﻿namespace GhostBusters_Forms.View.Ticket
{
    partial class Observacoes
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
            this.BtSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(195, 173);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(75, 23);
            this.BtSave.TabIndex = 0;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a Observacao da troca de status:";
            // 
            // tbObservacao
            // 
            this.tbObservacao.Location = new System.Drawing.Point(61, 53);
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(340, 114);
            this.tbObservacao.TabIndex = 2;
            // 
            // Observacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 232);
            this.Controls.Add(this.tbObservacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtSave);
            this.Name = "Observacoes";
            this.Text = "Observacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObservacao;
    }
}