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
            this.txtNomeDetalhe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagemDetalhe
            // 
            this.picImagemDetalhe.Location = new System.Drawing.Point(21, 17);
            this.picImagemDetalhe.Name = "picImagemDetalhe";
            this.picImagemDetalhe.Size = new System.Drawing.Size(250, 262);
            this.picImagemDetalhe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagemDetalhe.TabIndex = 0;
            this.picImagemDetalhe.TabStop = false;
            // 
            // txtNomeDetalhe
            // 
            this.txtNomeDetalhe.Location = new System.Drawing.Point(340, 31);
            this.txtNomeDetalhe.Name = "txtNomeDetalhe";
            this.txtNomeDetalhe.Size = new System.Drawing.Size(291, 23);
            this.txtNomeDetalhe.TabIndex = 1;
            // 
            // Frm_Detalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeDetalhe);
            this.Controls.Add(this.picImagemDetalhe);
            this.Name = "Frm_Detalhe";
            this.Text = "Frm_Detalhe";
            ((System.ComponentModel.ISupportInitialize)(this.picImagemDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picImagemDetalhe;
        private TextBox txtNomeDetalhe;
    }
}