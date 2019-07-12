namespace GhostBusters_Forms
{
    partial class CadastroUsuario
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
            this.label3 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConfirmeSenha = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfirmaEmail = new System.Windows.Forms.TextBox();
            this.lbConfirmaEmail = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureImagem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CbListarPerfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearImagem = new System.Windows.Forms.Button();
            this.BtVisConfirmeSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cadastro de usuario:";
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(369, 335);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(108, 44);
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Confirme sua Senha:";
            // 
            // tbConfirmeSenha
            // 
            this.tbConfirmeSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmeSenha.Location = new System.Drawing.Point(309, 303);
            this.tbConfirmeSenha.Name = "tbConfirmeSenha";
            this.tbConfirmeSenha.PasswordChar = '*';
            this.tbConfirmeSenha.Size = new System.Drawing.Size(219, 26);
            this.tbConfirmeSenha.TabIndex = 4;
            this.tbConfirmeSenha.TextChanged += new System.EventHandler(this.TbConfirmeSenha_TextChanged);
            this.tbConfirmeSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbConfirmeSenha_KeyUp);
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(309, 271);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(219, 26);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.TextChanged += new System.EventHandler(this.TbSenha_TextChanged);
            // 
            // tbConfirmaEmail
            // 
            this.tbConfirmaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmaEmail.Location = new System.Drawing.Point(309, 239);
            this.tbConfirmaEmail.Name = "tbConfirmaEmail";
            this.tbConfirmaEmail.Size = new System.Drawing.Size(219, 26);
            this.tbConfirmaEmail.TabIndex = 2;
            // 
            // lbConfirmaEmail
            // 
            this.lbConfirmaEmail.AutoSize = true;
            this.lbConfirmaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmaEmail.Location = new System.Drawing.Point(155, 245);
            this.lbConfirmaEmail.Name = "lbConfirmaEmail";
            this.lbConfirmaEmail.Size = new System.Drawing.Size(148, 20);
            this.lbConfirmaEmail.TabIndex = 26;
            this.lbConfirmaEmail.Text = "Confirme seu email:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(251, 207);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 25;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(309, 207);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 26);
            this.tbEmail.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(250, 148);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 23;
            this.lbNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(308, 145);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(219, 26);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(534, 271);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(141, 26);
            this.btnNew.TabIndex = 30;
            this.btnNew.Text = "Visualizar Senha ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            this.btnNew.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNew_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Escolha uma imagem";
            // 
            // pictureImagem
            // 
            this.pictureImagem.Location = new System.Drawing.Point(605, 69);
            this.pictureImagem.Name = "pictureImagem";
            this.pictureImagem.Size = new System.Drawing.Size(161, 129);
            this.pictureImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImagem.TabIndex = 33;
            this.pictureImagem.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abrir imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CbListarPerfil
            // 
            this.CbListarPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbListarPerfil.FormattingEnabled = true;
            this.CbListarPerfil.Location = new System.Drawing.Point(309, 177);
            this.CbListarPerfil.Name = "CbListarPerfil";
            this.CbListarPerfil.Size = new System.Drawing.Size(218, 21);
            this.CbListarPerfil.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Perfil:";
            // 
            // ClearImagem
            // 
            this.ClearImagem.Location = new System.Drawing.Point(682, 204);
            this.ClearImagem.Name = "ClearImagem";
            this.ClearImagem.Size = new System.Drawing.Size(84, 26);
            this.ClearImagem.TabIndex = 37;
            this.ClearImagem.Text = "Clear imagem";
            this.ClearImagem.UseVisualStyleBackColor = true;
            this.ClearImagem.Click += new System.EventHandler(this.ClearImagem_Click);
            // 
            // BtVisConfirmeSenha
            // 
            this.BtVisConfirmeSenha.Location = new System.Drawing.Point(534, 304);
            this.BtVisConfirmeSenha.Name = "BtVisConfirmeSenha";
            this.BtVisConfirmeSenha.Size = new System.Drawing.Size(141, 26);
            this.BtVisConfirmeSenha.TabIndex = 38;
            this.BtVisConfirmeSenha.Text = "Visualizar Senha ";
            this.BtVisConfirmeSenha.UseVisualStyleBackColor = true;
            this.BtVisConfirmeSenha.Click += new System.EventHandler(this.BtVisConfirmeSenha_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtVisConfirmeSenha);
            this.Controls.Add(this.ClearImagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbListarPerfil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureImagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbConfirmeSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbConfirmaEmail);
            this.Controls.Add(this.lbConfirmaEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNome);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConfirmeSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfirmaEmail;
        private System.Windows.Forms.Label lbConfirmaEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureImagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CbListarPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearImagem;
        private System.Windows.Forms.Button BtVisConfirmeSenha;
    }
}