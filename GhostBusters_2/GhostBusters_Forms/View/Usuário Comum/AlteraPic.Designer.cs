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
            this.pictureImagem.Location = new System.Drawing.Point(141, 76);
            this.pictureImagem.Margin = new System.Windows.Forms.Padding(4);
            this.pictureImagem.Name = "pictureImagem";
            this.pictureImagem.Size = new System.Drawing.Size(246, 264);
            this.pictureImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImagem.TabIndex = 35;
            this.pictureImagem.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(362, 361);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 54);
            this.btnAlterar.TabIndex = 39;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSaveBase
            // 
            this.btnSaveBase.Location = new System.Drawing.Point(194, 361);
            this.btnSaveBase.Name = "btnSaveBase";
            this.btnSaveBase.Size = new System.Drawing.Size(133, 54);
            this.btnSaveBase.TabIndex = 38;
            this.btnSaveBase.Text = "Salvar";
            this.btnSaveBase.UseVisualStyleBackColor = true;
            this.btnSaveBase.Click += new System.EventHandler(this.BtnSaveBase_Click);
            // 
            // btnOpenBase
            // 
            this.btnOpenBase.Location = new System.Drawing.Point(29, 361);
            this.btnOpenBase.Name = "btnOpenBase";
            this.btnOpenBase.Size = new System.Drawing.Size(133, 54);
            this.btnOpenBase.TabIndex = 37;
            this.btnOpenBase.Text = "Abrir Imagem";
            this.btnOpenBase.UseVisualStyleBackColor = true;
            this.btnOpenBase.Click += new System.EventHandler(this.BtnOpenBase_Click);
            // 
            // AlteraPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSaveBase);
            this.Controls.Add(this.btnOpenBase);
            this.Controls.Add(this.pictureImagem);
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