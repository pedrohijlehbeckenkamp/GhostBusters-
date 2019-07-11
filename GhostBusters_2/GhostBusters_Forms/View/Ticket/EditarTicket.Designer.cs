namespace GhostBusters_Forms.View.Ticket
{
    partial class EditarTicket
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
            this.lbData = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lsAnexos = new System.Windows.Forms.ListView();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.llbUsuario = new System.Windows.Forms.LinkLabel();
            this.llbTecnico = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(12, 9);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(116, 20);
            this.lbData.TabIndex = 35;
            this.lbData.Text = "Aqui vai a Data";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(44, 169);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(84, 20);
            this.lbDescricao.TabIndex = 34;
            this.lbDescricao.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(139, 166);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(219, 170);
            this.tbDescricao.TabIndex = 1;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(14, 68);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(119, 20);
            this.lbTitulo.TabIndex = 32;
            this.lbTitulo.Text = "Nome do ticket:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(139, 68);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(219, 26);
            this.tbTitulo.TabIndex = 0;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(72, 117);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(56, 20);
            this.lbStatus.TabIndex = 36;
            this.lbStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(139, 114);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 28);
            this.cbStatus.TabIndex = 2;
            // 
            // lsAnexos
            // 
            this.lsAnexos.HideSelection = false;
            this.lsAnexos.Location = new System.Drawing.Point(408, 188);
            this.lsAnexos.Name = "lsAnexos";
            this.lsAnexos.Size = new System.Drawing.Size(177, 198);
            this.lsAnexos.TabIndex = 4;
            this.lsAnexos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(468, 143);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(60, 30);
            this.btnAnexo.TabIndex = 3;
            this.btnAnexo.Text = "Anexo";
            this.btnAnexo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(437, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 99);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(175, 368);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(134, 50);
            this.btnConcluir.TabIndex = 5;
            this.btnConcluir.Text = "Concluir edição";
            this.btnConcluir.UseVisualStyleBackColor = true;
            // 
            // llbUsuario
            // 
            this.llbUsuario.AutoSize = true;
            this.llbUsuario.Location = new System.Drawing.Point(15, 243);
            this.llbUsuario.Name = "llbUsuario";
            this.llbUsuario.Size = new System.Drawing.Size(100, 13);
            this.llbUsuario.TabIndex = 41;
            this.llbUsuario.TabStop = true;
            this.llbUsuario.Text = "Ver perfil do usuário";
            // 
            // llbTecnico
            // 
            this.llbTecnico.AutoSize = true;
            this.llbTecnico.Location = new System.Drawing.Point(15, 279);
            this.llbTecnico.Name = "llbTecnico";
            this.llbTecnico.Size = new System.Drawing.Size(101, 13);
            this.llbTecnico.TabIndex = 42;
            this.llbTecnico.TabStop = true;
            this.llbTecnico.Text = "Ver perfil do técnico";
            // 
            // EditarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 433);
            this.Controls.Add(this.llbTecnico);
            this.Controls.Add(this.llbUsuario);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lsAnexos);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tbTitulo);
            this.Name = "EditarTicket";
            this.Text = "EditarTicket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ListView lsAnexos;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.LinkLabel llbUsuario;
        private System.Windows.Forms.LinkLabel llbTecnico;
    }
}