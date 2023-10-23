namespace for_döngüsü_5_1681
{
    partial class Form1
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtBitir = new System.Windows.Forms.TextBox();
            this.txtDegisim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(183, 29);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(136, 225);
            this.lbSayilar.TabIndex = 0;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(12, 29);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 20);
            this.txtBaslangic.TabIndex = 1;
            // 
            // txtBitir
            // 
            this.txtBitir.Location = new System.Drawing.Point(12, 69);
            this.txtBitir.Name = "txtBitir";
            this.txtBitir.Size = new System.Drawing.Size(101, 20);
            this.txtBitir.TabIndex = 2;
            // 
            // txtDegisim
            // 
            this.txtDegisim.Location = new System.Drawing.Point(13, 105);
            this.txtDegisim.Name = "txtDegisim";
            this.txtDegisim.Size = new System.Drawing.Size(100, 20);
            this.txtDegisim.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(52, 131);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 30);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 308);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDegisim);
            this.Controls.Add(this.txtBitir);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtBitir;
        private System.Windows.Forms.TextBox txtDegisim;
        private System.Windows.Forms.Button btnEkle;
    }
}

