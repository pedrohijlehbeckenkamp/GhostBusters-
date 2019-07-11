namespace GhostBusters_Forms.Usuário_Comum
{
    partial class TelaPUsuarioComumcs
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
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnAcompanhamento = new System.Windows.Forms.Button();
            this.linkEditar = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPerfil
            // 
            this.pbPerfil.Location = new System.Drawing.Point(36, 54);
            this.pbPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(174, 154);
            this.pbPerfil.TabIndex = 29;
            this.pbPerfil.TabStop = false;
            this.pbPerfil.Click += new System.EventHandler(this.PbPerfil_Click);
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTicket.Location = new System.Drawing.Point(36, 303);
            this.btnNewTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(305, 46);
            this.btnNewTicket.TabIndex = 28;
            this.btnNewTicket.Text = "Abrir chamado";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.BtnNewTicket_Click);
            // 
            // btnAcompanhamento
            // 
            this.btnAcompanhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcompanhamento.Location = new System.Drawing.Point(36, 246);
            this.btnAcompanhamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcompanhamento.Name = "btnAcompanhamento";
            this.btnAcompanhamento.Size = new System.Drawing.Size(305, 49);
            this.btnAcompanhamento.TabIndex = 30;
            this.btnAcompanhamento.Text = "Acompanhamento";
            this.btnAcompanhamento.UseVisualStyleBackColor = true;
            this.btnAcompanhamento.Click += new System.EventHandler(this.BtnAcompanhamento_Click);
            // 
            // linkEditar
            // 
            this.linkEditar.AutoSize = true;
            this.linkEditar.Location = new System.Drawing.Point(422, 220);
            this.linkEditar.Name = "linkEditar";
            this.linkEditar.Size = new System.Drawing.Size(81, 17);
            this.linkEditar.TabIndex = 32;
            this.linkEditar.TabStop = true;
            this.linkEditar.Text = "Editar Perfil";
            this.linkEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEditar_LinkClicked);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(230, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 164);
            this.listBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
           
            // 
            // TelaPUsuarioComumcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkEditar);
            this.Controls.Add(this.btnAcompanhamento);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.btnNewTicket);
            this.Name = "TelaPUsuarioComumcs";
            this.Text = "TelaPUsuarioComumcs";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Button btnAcompanhamento;
        private System.Windows.Forms.LinkLabel linkEditar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}