namespace WindowsFormsApp1
{
    partial class kullanici_ekle_form
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
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.kul_ad_textBox = new System.Windows.Forms.TextBox();
            this.soyad_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ad_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sifre_tekrar_textBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.kul_kontrol_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifre_textBox
            // 
            this.sifre_textBox.Location = new System.Drawing.Point(116, 162);
            this.sifre_textBox.Name = "sifre_textBox";
            this.sifre_textBox.Size = new System.Drawing.Size(144, 20);
            this.sifre_textBox.TabIndex = 21;
            this.sifre_textBox.UseSystemPasswordChar = true;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(116, 134);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(144, 20);
            this.email_textBox.TabIndex = 20;
            // 
            // kul_ad_textBox
            // 
            this.kul_ad_textBox.Location = new System.Drawing.Point(116, 101);
            this.kul_ad_textBox.Name = "kul_ad_textBox";
            this.kul_ad_textBox.Size = new System.Drawing.Size(144, 20);
            this.kul_ad_textBox.TabIndex = 19;
            this.kul_ad_textBox.TextChanged += new System.EventHandler(this.kul_ad_textBox_TextChanged);
            // 
            // soyad_textBox
            // 
            this.soyad_textBox.Location = new System.Drawing.Point(116, 71);
            this.soyad_textBox.Name = "soyad_textBox";
            this.soyad_textBox.Size = new System.Drawing.Size(144, 20);
            this.soyad_textBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad";
            // 
            // ad_textBox
            // 
            this.ad_textBox.Location = new System.Drawing.Point(116, 37);
            this.ad_textBox.Name = "ad_textBox";
            this.ad_textBox.Size = new System.Drawing.Size(144, 20);
            this.ad_textBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad";
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_btn.Location = new System.Drawing.Point(169, 234);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(91, 33);
            this.kaydet_btn.TabIndex = 11;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tekrar Şifre";
            // 
            // sifre_tekrar_textBox
            // 
            this.sifre_tekrar_textBox.Location = new System.Drawing.Point(116, 195);
            this.sifre_tekrar_textBox.Name = "sifre_tekrar_textBox";
            this.sifre_tekrar_textBox.Size = new System.Drawing.Size(144, 20);
            this.sifre_tekrar_textBox.TabIndex = 23;
            this.sifre_tekrar_textBox.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(267, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(267, 165);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 29;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // kul_kontrol_lbl
            // 
            this.kul_kontrol_lbl.AutoSize = true;
            this.kul_kontrol_lbl.Location = new System.Drawing.Point(267, 107);
            this.kul_kontrol_lbl.Name = "kul_kontrol_lbl";
            this.kul_kontrol_lbl.Size = new System.Drawing.Size(10, 13);
            this.kul_kontrol_lbl.TabIndex = 30;
            this.kul_kontrol_lbl.Text = "-";
            // 
            // kullanici_ekle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 289);
            this.Controls.Add(this.kul_kontrol_lbl);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sifre_tekrar_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sifre_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.kul_ad_textBox);
            this.Controls.Add(this.soyad_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ad_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kaydet_btn);
            this.Name = "kullanici_ekle_form";
            this.Text = "kullanici_ekle_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifre_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox kul_ad_textBox;
        private System.Windows.Forms.TextBox soyad_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ad_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sifre_tekrar_textBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label kul_kontrol_lbl;
    }
}