namespace PokeSon
{
    partial class Frm_Detalhe
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
            this.picImagemDetalhe = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barTeste = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagemDetalhe
            // 
            this.picImagemDetalhe.Location = new System.Drawing.Point(24, 93);
            this.picImagemDetalhe.Name = "picImagemDetalhe";
            this.picImagemDetalhe.Size = new System.Drawing.Size(250, 262);
            this.picImagemDetalhe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagemDetalhe.TabIndex = 0;
            this.picImagemDetalhe.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(291, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(413, 166);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 15);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // barTeste
            // 
            this.barTeste.Location = new System.Drawing.Point(457, 115);
            this.barTeste.Maximum = 500;
            this.barTeste.Name = "barTeste";
            this.barTeste.Size = new System.Drawing.Size(100, 23);
            this.barTeste.TabIndex = 8;
            // 
            // Frm_Detalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 383);
            this.Controls.Add(this.barTeste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.picImagemDetalhe);
            this.Name = "Frm_Detalhe";
            this.Text = "Frm_Detalhe";
            ((System.ComponentModel.ISupportInitialize)(this.picImagemDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picImagemDetalhe;
        private Label lblNome;
        private Label label2;
        private Label lblTipo;
        private Label label4;
        private Label label5;
        private Label label6;
        private ProgressBar barTeste;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}