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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(85, 97);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(119, 20);
            this.lbTitulo.TabIndex = 25;
            this.lbTitulo.Text = "Nome do ticket:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(210, 94);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(219, 26);
            this.tbTitulo.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(120, 139);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(84, 20);
            this.lbDescricao.TabIndex = 28;
            this.lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(210, 136);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(219, 169);
            this.tbDescricao.TabIndex = 1;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(12, 9);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(116, 20);
            this.lbData.TabIndex = 30;
            this.lbData.Text = "Aqui vai a Data";
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(528, 52);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(60, 30);
            this.btnAnexo.TabIndex = 2;
            this.btnAnexo.Text = "Anexo";
            this.btnAnexo.UseVisualStyleBackColor = true;
            // 
            // lsAnexos
            // 
            this.lsAnexos.HideSelection = false;
            this.lsAnexos.Location = new System.Drawing.Point(479, 107);
            this.lsAnexos.Name = "lsAnexos";
            this.lsAnexos.Size = new System.Drawing.Size(168, 198);
            this.lsAnexos.TabIndex = 3;
            this.lsAnexos.UseCompatibleStateImageBehavior = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(124, 56);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(133, 20);
            this.lbUsuario.TabIndex = 31;
            this.lbUsuario.Text = "Nome do usuário:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(263, 53);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(121, 28);
            this.cbUsuario.TabIndex = 32;
            // 
            // CadastrarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 330);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.lbUsuario);
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
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.ComboBox cbUsuario;
    }
}