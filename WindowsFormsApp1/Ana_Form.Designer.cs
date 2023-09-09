namespace WindowsFormsApp1
{
    partial class Ana_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.northwind_btn = new System.Windows.Forms.Button();
            this.sinav_groupBox = new System.Windows.Forms.GroupBox();
            this.sinav_prog_sil = new System.Windows.Forms.Button();
            this.sinav_prog_guncelle_btn = new System.Windows.Forms.Button();
            this.ders_groupBox = new System.Windows.Forms.GroupBox();
            this.ders_prog_sil = new System.Windows.Forms.Button();
            this.ders_prog_guncelle = new System.Windows.Forms.Button();
            this.ders_prog_goster_button = new System.Windows.Forms.Button();
            this.ders_prog_ekle_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.giris_btn = new System.Windows.Forms.Button();
            this.kayit_btn = new System.Windows.Forms.Button();
            this.hesap_ayar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sinav_groupBox.SuspendLayout();
            this.ders_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sınav Programını Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sınav Programı Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // northwind_btn
            // 
            this.northwind_btn.Location = new System.Drawing.Point(521, 205);
            this.northwind_btn.Name = "northwind_btn";
            this.northwind_btn.Size = new System.Drawing.Size(179, 25);
            this.northwind_btn.TabIndex = 3;
            this.northwind_btn.Text = "Northwind Database İşlemleri";
            this.northwind_btn.UseVisualStyleBackColor = true;
            this.northwind_btn.Click += new System.EventHandler(this.northwind_btn_Click);
            // 
            // sinav_groupBox
            // 
            this.sinav_groupBox.Controls.Add(this.sinav_prog_sil);
            this.sinav_groupBox.Controls.Add(this.sinav_prog_guncelle_btn);
            this.sinav_groupBox.Controls.Add(this.button2);
            this.sinav_groupBox.Controls.Add(this.button1);
            this.sinav_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinav_groupBox.Location = new System.Drawing.Point(13, 12);
            this.sinav_groupBox.Name = "sinav_groupBox";
            this.sinav_groupBox.Size = new System.Drawing.Size(208, 218);
            this.sinav_groupBox.TabIndex = 4;
            this.sinav_groupBox.TabStop = false;
            this.sinav_groupBox.Text = "Sınav Programı";
            // 
            // sinav_prog_sil
            // 
            this.sinav_prog_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinav_prog_sil.Location = new System.Drawing.Point(6, 117);
            this.sinav_prog_sil.Name = "sinav_prog_sil";
            this.sinav_prog_sil.Size = new System.Drawing.Size(196, 29);
            this.sinav_prog_sil.TabIndex = 4;
            this.sinav_prog_sil.Text = "Sınav Programını Sil";
            this.sinav_prog_sil.UseVisualStyleBackColor = true;
            // 
            // sinav_prog_guncelle_btn
            // 
            this.sinav_prog_guncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinav_prog_guncelle_btn.Location = new System.Drawing.Point(6, 82);
            this.sinav_prog_guncelle_btn.Name = "sinav_prog_guncelle_btn";
            this.sinav_prog_guncelle_btn.Size = new System.Drawing.Size(196, 29);
            this.sinav_prog_guncelle_btn.TabIndex = 3;
            this.sinav_prog_guncelle_btn.Text = "Sınav Programını Güncelle";
            this.sinav_prog_guncelle_btn.UseVisualStyleBackColor = true;
            // 
            // ders_groupBox
            // 
            this.ders_groupBox.Controls.Add(this.ders_prog_sil);
            this.ders_groupBox.Controls.Add(this.ders_prog_guncelle);
            this.ders_groupBox.Controls.Add(this.ders_prog_goster_button);
            this.ders_groupBox.Controls.Add(this.ders_prog_ekle_button);
            this.ders_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders_groupBox.Location = new System.Drawing.Point(227, 12);
            this.ders_groupBox.Name = "ders_groupBox";
            this.ders_groupBox.Size = new System.Drawing.Size(200, 218);
            this.ders_groupBox.TabIndex = 5;
            this.ders_groupBox.TabStop = false;
            this.ders_groupBox.Text = "Ders Programı";
            // 
            // ders_prog_sil
            // 
            this.ders_prog_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders_prog_sil.Location = new System.Drawing.Point(6, 117);
            this.ders_prog_sil.Name = "ders_prog_sil";
            this.ders_prog_sil.Size = new System.Drawing.Size(180, 29);
            this.ders_prog_sil.TabIndex = 6;
            this.ders_prog_sil.Text = "Ders Programını Sil";
            this.ders_prog_sil.UseVisualStyleBackColor = true;
            // 
            // ders_prog_guncelle
            // 
            this.ders_prog_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders_prog_guncelle.Location = new System.Drawing.Point(6, 82);
            this.ders_prog_guncelle.Name = "ders_prog_guncelle";
            this.ders_prog_guncelle.Size = new System.Drawing.Size(180, 29);
            this.ders_prog_guncelle.TabIndex = 5;
            this.ders_prog_guncelle.Text = "Ders Programını Güncelle";
            this.ders_prog_guncelle.UseVisualStyleBackColor = true;
            // 
            // ders_prog_goster_button
            // 
            this.ders_prog_goster_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders_prog_goster_button.Location = new System.Drawing.Point(6, 169);
            this.ders_prog_goster_button.Name = "ders_prog_goster_button";
            this.ders_prog_goster_button.Size = new System.Drawing.Size(180, 29);
            this.ders_prog_goster_button.TabIndex = 4;
            this.ders_prog_goster_button.Text = "Ders Programını Göster";
            this.ders_prog_goster_button.UseVisualStyleBackColor = true;
            // 
            // ders_prog_ekle_button
            // 
            this.ders_prog_ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders_prog_ekle_button.Location = new System.Drawing.Point(6, 47);
            this.ders_prog_ekle_button.Name = "ders_prog_ekle_button";
            this.ders_prog_ekle_button.Size = new System.Drawing.Size(180, 29);
            this.ders_prog_ekle_button.TabIndex = 3;
            this.ders_prog_ekle_button.Text = "Ders Programı Ekle";
            this.ders_prog_ekle_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Not: Ders, Derslik, Gözetmen ve Bölüm\r\n         Alanları üzerinde değişiklik yapm" +
    "ak\r\n         İçin Giriş Yapınız";
            // 
            // giris_btn
            // 
            this.giris_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_btn.Location = new System.Drawing.Point(543, 59);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(141, 30);
            this.giris_btn.TabIndex = 7;
            this.giris_btn.Text = "Giriş Yap";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // kayit_btn
            // 
            this.kayit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_btn.Location = new System.Drawing.Point(543, 97);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(141, 30);
            this.kayit_btn.TabIndex = 8;
            this.kayit_btn.Text = "Kayıt Ol";
            this.kayit_btn.UseVisualStyleBackColor = true;
            this.kayit_btn.Click += new System.EventHandler(this.kayit_btn_Click);
            // 
            // hesap_ayar
            // 
            this.hesap_ayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesap_ayar.Location = new System.Drawing.Point(543, 138);
            this.hesap_ayar.Name = "hesap_ayar";
            this.hesap_ayar.Size = new System.Drawing.Size(141, 30);
            this.hesap_ayar.TabIndex = 9;
            this.hesap_ayar.Text = "Hesap Ayarları";
            this.hesap_ayar.UseVisualStyleBackColor = true;
            this.hesap_ayar.Click += new System.EventHandler(this.hesap_ayar_Click);
            // 
            // Ana_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 512);
            this.Controls.Add(this.hesap_ayar);
            this.Controls.Add(this.kayit_btn);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ders_groupBox);
            this.Controls.Add(this.sinav_groupBox);
            this.Controls.Add(this.northwind_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ana_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sinav_groupBox.ResumeLayout(false);
            this.ders_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button northwind_btn;
        private System.Windows.Forms.GroupBox sinav_groupBox;
        private System.Windows.Forms.Button sinav_prog_sil;
        private System.Windows.Forms.Button sinav_prog_guncelle_btn;
        private System.Windows.Forms.GroupBox ders_groupBox;
        private System.Windows.Forms.Button ders_prog_sil;
        private System.Windows.Forms.Button ders_prog_guncelle;
        private System.Windows.Forms.Button ders_prog_goster_button;
        private System.Windows.Forms.Button ders_prog_ekle_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Button kayit_btn;
        private System.Windows.Forms.Button hesap_ayar;
    }
}

