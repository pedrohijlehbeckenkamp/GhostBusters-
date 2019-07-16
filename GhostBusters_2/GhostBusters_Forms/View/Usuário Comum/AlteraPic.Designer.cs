namespace GhostBusters_Forms.View.Usuário_Comum
{
    partial class AlteraPic
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
            this.pictureImagem = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSaveBase = new System.Windows.Forms.Button();
            this.btnOpenBase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureImagem
            // 
            this.pictureImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureImagem.Location = new System.Drawing.Point(106, 62);
            this.pictureImagem.Name = "pictureImagem";
            this.pictureImagem.Size = new System.Drawing.Size(184, 214);
            this.pictureImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImagem.TabIndex = 35;
            this.pictureImagem.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(272, 293);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 44);
            this.btnAlterar.TabIndex = 39;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSaveBase
            // 
            this.btnSaveBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBase.ForeColor = System.Drawing.Color.White;
            this.btnSaveBase.Location = new System.Drawing.Point(146, 293);
            this.btnSaveBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveBase.Name = "btnSaveBase";
            this.btnSaveBase.Size = new System.Drawing.Size(100, 44);
            this.btnSaveBase.TabIndex = 38;
            this.btnSaveBase.Text = "Salvar";
            this.btnSaveBase.UseVisualStyleBackColor = false;
            this.btnSaveBase.Click += new System.EventHandler(this.BtnSaveBase_Click);
            // 
            // btnOpenBase
            // 
            this.btnOpenBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBase.ForeColor = System.Drawing.Color.White;
            this.btnOpenBase.Location = new System.Drawing.Point(22, 293);
            this.btnOpenBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenBase.Name = "btnOpenBase";
            this.btnOpenBase.Size = new System.Drawing.Size(100, 44);
            this.btnOpenBase.TabIndex = 37;
            this.btnOpenBase.Text = "Abrir Imagem";
            this.btnOpenBase.UseVisualStyleBackColor = false;
            this.btnOpenBase.Click += new System.EventHandler(this.BtnOpenBase_Click);
            // 
            // AlteraPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(400, 366);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSaveBase);
            this.Controls.Add(this.btnOpenBase);
            this.Controls.Add(this.pictureImagem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlteraPic";
            this.Text = "AlteraPic";
            this.Load += new System.EventHandler(this.AlteraPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureImagem;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSaveBase;
        private System.Windows.Forms.Button btnOpenBase;
    }
}