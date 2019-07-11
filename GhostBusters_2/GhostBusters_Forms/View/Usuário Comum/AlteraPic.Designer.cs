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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveBase = new System.Windows.Forms.Button();
            this.btnOpenBase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureImagem
            // 
            this.pictureImagem.Location = new System.Drawing.Point(60, 56);
            this.pictureImagem.Margin = new System.Windows.Forms.Padding(4);
            this.pictureImagem.Name = "pictureImagem";
            this.pictureImagem.Size = new System.Drawing.Size(246, 264);
            this.pictureImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImagem.TabIndex = 35;
            this.pictureImagem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(452, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(485, 361);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(133, 54);
            this.btnLoad.TabIndex = 39;
            this.btnLoad.Text = "Carregar";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSaveBase
            // 
            this.btnSaveBase.Location = new System.Drawing.Point(329, 361);
            this.btnSaveBase.Name = "btnSaveBase";
            this.btnSaveBase.Size = new System.Drawing.Size(133, 54);
            this.btnSaveBase.TabIndex = 38;
            this.btnSaveBase.Text = "Salvar";
            this.btnSaveBase.UseVisualStyleBackColor = true;
            // 
            // btnOpenBase
            // 
            this.btnOpenBase.Location = new System.Drawing.Point(173, 361);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSaveBase);
            this.Controls.Add(this.btnOpenBase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureImagem);
            this.Name = "AlteraPic";
            this.Text = "AlteraPic";
            this.Load += new System.EventHandler(this.AlteraPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureImagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveBase;
        private System.Windows.Forms.Button btnOpenBase;
    }
}