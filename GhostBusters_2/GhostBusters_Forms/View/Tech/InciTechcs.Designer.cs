namespace GhostBusters_Forms.View.Tech
{
    partial class InciTechcs
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
            this.btnStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(385, 70);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(169, 54);
            this.btnStatus.TabIndex = 12;
            this.btnStatus.Text = "Visualizar seus status";
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // InciTechcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStatus);
            this.Name = "InciTechcs";
            this.Text = "InciTechcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStatus;
    }
}