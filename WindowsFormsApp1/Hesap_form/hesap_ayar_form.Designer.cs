namespace WindowsFormsApp1
{
    partial class hesap_ayar_form
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
            this.giris_btn = new System.Windows.Forms.Button();
            this.k_ad_lbl = new System.Windows.Forms.Label();
            this.k_ad_textBox = new System.Windows.Forms.TextBox();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.sifre_textBox = new System.Windows.Forms.TextBox();
            this.k_bilgi_grpbox = new System.Windows.Forms.GroupBox();
            this.kul_ad_lbl = new System.Windows.Forms.Label();
            this.sifre_bilgi_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.soyad_textBox = new System.Windows.Forms.TextBox();
            this.ad_textBox = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.k_bilgi_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // giris_btn
            // 
            this.giris_btn.Location = new System.Drawing.Point(120, 111);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(75, 23);
            this.giris_btn.TabIndex = 0;
            this.giris_btn.Text = "Giris";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // k_ad_lbl
            // 
            this.k_ad_lbl.AutoSize = true;
            this.k_ad_lbl.Location = new System.Drawing.Point(29, 39);
            this.k_ad_lbl.Name = "k_ad_lbl";
            this.k_ad_lbl.Size = new System.Drawing.Size(64, 13);
            this.k_ad_lbl.TabIndex = 1;
            this.k_ad_lbl.Text = "Kullanıcı Adı";
            // 
            // k_ad_textBox
            // 
            this.k_ad_textBox.Location = new System.Drawing.Point(108, 36);
            this.k_ad_textBox.Name = "k_ad_textBox";
            this.k_ad_textBox.Size = new System.Drawing.Size(100, 20);
            this.k_ad_textBox.TabIndex = 2;
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.Location = new System.Drawing.Point(29, 77);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(28, 13);
            this.sifre_lbl.TabIndex = 3;
            this.sifre_lbl.Text = "Şifre";
            // 
            // sifre_textBox
            // 
            this.sifre_textBox.Location = new System.Drawing.Point(108, 74);
            this.sifre_textBox.Name = "sifre_textBox";
            this.sifre_textBox.Size = new System.Drawing.Size(100, 20);
            this.sifre_textBox.TabIndex = 4;
            this.sifre_textBox.UseSystemPasswordChar = true;
            // 
            // k_bilgi_grpbox
            // 
            this.k_bilgi_grpbox.Controls.Add(this.update_btn);
            this.k_bilgi_grpbox.Controls.Add(this.kul_ad_lbl);
            this.k_bilgi_grpbox.Controls.Add(this.sifre_bilgi_textBox);
            this.k_bilgi_grpbox.Controls.Add(this.email_textBox);
            this.k_bilgi_grpbox.Controls.Add(this.soyad_textBox);
            this.k_bilgi_grpbox.Controls.Add(this.ad_textBox);
            this.k_bilgi_grpbox.Controls.Add(this.delete_btn);
            this.k_bilgi_grpbox.Controls.Add(this.label5);
            this.k_bilgi_grpbox.Controls.Add(this.label4);
            this.k_bilgi_grpbox.Controls.Add(this.label3);
            this.k_bilgi_grpbox.Controls.Add(this.label2);
            this.k_bilgi_grpbox.Controls.Add(this.label1);
            this.k_bilgi_grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.k_bilgi_grpbox.Location = new System.Drawing.Point(12, 149);
            this.k_bilgi_grpbox.Name = "k_bilgi_grpbox";
            this.k_bilgi_grpbox.Size = new System.Drawing.Size(273, 286);
            this.k_bilgi_grpbox.TabIndex = 5;
            this.k_bilgi_grpbox.TabStop = false;
            this.k_bilgi_grpbox.Text = "Kullanıcı Bilgileri";
            // 
            // kul_ad_lbl
            // 
            this.kul_ad_lbl.AutoSize = true;
            this.kul_ad_lbl.Location = new System.Drawing.Point(99, 93);
            this.kul_ad_lbl.Name = "kul_ad_lbl";
            this.kul_ad_lbl.Size = new System.Drawing.Size(84, 17);
            this.kul_ad_lbl.TabIndex = 12;
            this.kul_ad_lbl.Text = "Kullanıcı Adı";
            // 
            // sifre_bilgi_textBox
            // 
            this.sifre_bilgi_textBox.Location = new System.Drawing.Point(95, 148);
            this.sifre_bilgi_textBox.Name = "sifre_bilgi_textBox";
            this.sifre_bilgi_textBox.Size = new System.Drawing.Size(147, 23);
            this.sifre_bilgi_textBox.TabIndex = 11;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(95, 119);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(147, 23);
            this.email_textBox.TabIndex = 10;
            // 
            // soyad_textBox
            // 
            this.soyad_textBox.Location = new System.Drawing.Point(95, 58);
            this.soyad_textBox.Name = "soyad_textBox";
            this.soyad_textBox.Size = new System.Drawing.Size(147, 23);
            this.soyad_textBox.TabIndex = 8;
            // 
            // ad_textBox
            // 
            this.ad_textBox.Location = new System.Drawing.Point(95, 26);
            this.ad_textBox.Name = "ad_textBox";
            this.ad_textBox.Size = new System.Drawing.Size(147, 23);
            this.ad_textBox.TabIndex = 7;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(96, 250);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(147, 30);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Hesabı Sil";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(96, 198);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(146, 33);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Güncelle";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // hesap_ayar_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 440);
            this.Controls.Add(this.k_bilgi_grpbox);
            this.Controls.Add(this.sifre_textBox);
            this.Controls.Add(this.sifre_lbl);
            this.Controls.Add(this.k_ad_textBox);
            this.Controls.Add(this.k_ad_lbl);
            this.Controls.Add(this.giris_btn);
            this.Name = "hesap_ayar_form";
            this.Text = "hesap_ayar_form";
            this.Load += new System.EventHandler(this.hesap_ayar_form_Load);
            this.k_bilgi_grpbox.ResumeLayout(false);
            this.k_bilgi_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Label k_ad_lbl;
        private System.Windows.Forms.TextBox k_ad_textBox;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.TextBox sifre_textBox;
        private System.Windows.Forms.GroupBox k_bilgi_grpbox;
        private System.Windows.Forms.TextBox sifre_bilgi_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox soyad_textBox;
        private System.Windows.Forms.TextBox ad_textBox;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kul_ad_lbl;
        private System.Windows.Forms.Button update_btn;
    }
}