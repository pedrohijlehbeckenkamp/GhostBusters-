namespace GhostBusters_Forms.View.Categoria
{
    partial class CadastrarCategoria
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
            this.btnSaveCategoria = new System.Windows.Forms.Button();
            this.lbNomeCateg = new System.Windows.Forms.Label();
            this.tbNomeCateg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveCategoria
            // 
            this.btnSaveCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveCategoria.ForeColor = System.Drawing.Color.White;
            this.btnSaveCategoria.Location = new System.Drawing.Point(400, 22);
            this.btnSaveCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCategoria.Name = "btnSaveCategoria";
            this.btnSaveCategoria.Size = new System.Drawing.Size(107, 62);
            this.btnSaveCategoria.TabIndex = 29;
            this.btnSaveCategoria.Text = "Save";
            this.btnSaveCategoria.UseVisualStyleBackColor = false;
            this.btnSaveCategoria.Click += new System.EventHandler(this.BtnSaveCategoria_Click);
            // 
            // lbNomeCateg
            // 
            this.lbNomeCateg.AutoSize = true;
            this.lbNomeCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCateg.Location = new System.Drawing.Point(37, 38);
            this.lbNomeCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeCateg.Name = "lbNomeCateg";
            this.lbNomeCateg.Size = new System.Drawing.Size(70, 25);
            this.lbNomeCateg.TabIndex = 30;
            this.lbNomeCateg.Text = "Nome:";
            // 
            // tbNomeCateg
            // 
            this.tbNomeCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCateg.Location = new System.Drawing.Point(115, 38);
            this.tbNomeCateg.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomeCateg.Name = "tbNomeCateg";
            this.tbNomeCateg.Size = new System.Drawing.Size(266, 30);
            this.tbNomeCateg.TabIndex = 28;
            // 
            // CadastrarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(545, 146);
            this.Controls.Add(this.btnSaveCategoria);
            this.Controls.Add(this.lbNomeCateg);
            this.Controls.Add(this.tbNomeCateg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarCategoria";
            this.Text = "Cadastro de categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveCategoria;
        private System.Windows.Forms.Label lbNomeCateg;
        private System.Windows.Forms.TextBox tbNomeCateg;
    }
}