namespace WindowsFormsApp1
{
    partial class giris_form
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
            this.sifre_textBox = new System.Windows.Forms.TextBox();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.k_ad_textBox = new System.Windows.Forms.TextBox();
            this.k_ad_lbl = new System.Windows.Forms.Label();
            this.giris_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifre_textBox
            // 
            this.sifre_textBox.Location = new System.Drawing.Point(128, 81);
            this.sifre_textBox.Name = "sifre_textBox";
            this.sifre_textBox.Size = new System.Drawing.Size(100, 20);
            this.sifre_textBox.TabIndex = 9;
            this.sifre_textBox.UseSystemPasswordChar = true;
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.Location = new System.Drawing.Point(49, 84);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(28, 13);
            this.sifre_lbl.TabIndex = 8;
            this.sifre_lbl.Text = "Şifre";
            // 
            // k_ad_textBox
            // 
            this.k_ad_textBox.Location = new System.Drawing.Point(128, 43);
            this.k_ad_textBox.Name = "k_ad_textBox";
            this.k_ad_textBox.Size = new System.Drawing.Size(100, 20);
            this.k_ad_textBox.TabIndex = 7;
            // 
            // k_ad_lbl
            // 
            this.k_ad_lbl.AutoSize = true;
            this.k_ad_lbl.Location = new System.Drawing.Point(49, 46);
            this.k_ad_lbl.Name = "k_ad_lbl";
            this.k_ad_lbl.Size = new System.Drawing.Size(64, 13);
            this.k_ad_lbl.TabIndex = 6;
            this.k_ad_lbl.Text = "Kullanıcı Adı";
            // 
            // giris_btn
            // 
            this.giris_btn.Location = new System.Drawing.Point(140, 118);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(75, 23);
            this.giris_btn.TabIndex = 5;
            this.giris_btn.Text = "Giris";
            this.giris_btn.UseVisualStyleBackColor = true;
            // 
            // giris_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.sifre_textBox);
            this.Controls.Add(this.sifre_lbl);
            this.Controls.Add(this.k_ad_textBox);
            this.Controls.Add(this.k_ad_lbl);
            this.Controls.Add(this.giris_btn);
            this.Name = "giris_form";
            this.Text = "giris_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifre_textBox;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.TextBox k_ad_textBox;
        private System.Windows.Forms.Label k_ad_lbl;
        private System.Windows.Forms.Button giris_btn;
    }
}