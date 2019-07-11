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
            this.btnAnexo = new System.Windows.Forms.Button();
            this.lsAnexos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(23, 92);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(119, 20);
            this.lbTitulo.TabIndex = 25;
            this.lbTitulo.Text = "Nome do ticket:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(148, 89);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(219, 26);
            this.tbTitulo.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(26, 127);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(84, 20);
            this.lbDescricao.TabIndex = 28;
            this.lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(148, 124);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(219, 26);
            this.tbDescricao.TabIndex = 27;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(26, 21);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(116, 20);
            this.lbData.TabIndex = 30;
            this.lbData.Text = "Aqui vai a Data";
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(457, 21);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(60, 30);
            this.btnAnexo.TabIndex = 31;
            this.btnAnexo.Text = "Anexo";
            this.btnAnexo.UseVisualStyleBackColor = true;
            // 
            // lsAnexos
            // 
            this.lsAnexos.HideSelection = false;
            this.lsAnexos.Location = new System.Drawing.Point(401, 70);
            this.lsAnexos.Name = "lsAnexos";
            this.lsAnexos.Size = new System.Drawing.Size(168, 195);
            this.lsAnexos.TabIndex = 32;
            this.lsAnexos.UseCompatibleStateImageBehavior = false;
            // 
            // CadastrarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 301);
            this.Controls.Add(this.lsAnexos);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tbTitulo);
            this.Name = "CadastrarTicket";
            this.Text = "Cadastrar ticket";
            this.Load += new System.EventHandler(this.CadastrarTicket_Load);
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
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.ListView lsAnexos;
    }
}