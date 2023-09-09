namespace WindowsFormsApp1
{
    partial class northwind_kategori
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
            this.kategoriler_lbl = new System.Windows.Forms.Label();
            this.urunler_lbl = new System.Windows.Forms.Label();
            this.kategori_cmb_box = new System.Windows.Forms.ComboBox();
            this.urunler_cmb_box = new System.Windows.Forms.ComboBox();
            this.urun_detay_grp_box = new System.Windows.Forms.GroupBox();
            this.urun_no_lbl = new System.Windows.Forms.Label();
            this.urun_ad_lbl = new System.Windows.Forms.Label();
            this.birim_fiyat_lbl = new System.Windows.Forms.Label();
            this.stok_adet_lbl = new System.Windows.Forms.Label();
            this.urun_detay_grp_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // kategoriler_lbl
            // 
            this.kategoriler_lbl.AutoSize = true;
            this.kategoriler_lbl.Location = new System.Drawing.Point(28, 37);
            this.kategoriler_lbl.Name = "kategoriler_lbl";
            this.kategoriler_lbl.Size = new System.Drawing.Size(57, 13);
            this.kategoriler_lbl.TabIndex = 0;
            this.kategoriler_lbl.Text = "Kategoriler";
            // 
            // urunler_lbl
            // 
            this.urunler_lbl.AutoSize = true;
            this.urunler_lbl.Location = new System.Drawing.Point(28, 93);
            this.urunler_lbl.Name = "urunler_lbl";
            this.urunler_lbl.Size = new System.Drawing.Size(41, 13);
            this.urunler_lbl.TabIndex = 1;
            this.urunler_lbl.Text = "Ürünler";
            // 
            // kategori_cmb_box
            // 
            this.kategori_cmb_box.FormattingEnabled = true;
            this.kategori_cmb_box.Location = new System.Drawing.Point(31, 54);
            this.kategori_cmb_box.Name = "kategori_cmb_box";
            this.kategori_cmb_box.Size = new System.Drawing.Size(121, 21);
            this.kategori_cmb_box.TabIndex = 2;
            // 
            // urunler_cmb_box
            // 
            this.urunler_cmb_box.FormattingEnabled = true;
            this.urunler_cmb_box.Location = new System.Drawing.Point(31, 110);
            this.urunler_cmb_box.Name = "urunler_cmb_box";
            this.urunler_cmb_box.Size = new System.Drawing.Size(121, 21);
            this.urunler_cmb_box.TabIndex = 3;
            // 
            // urun_detay_grp_box
            // 
            this.urun_detay_grp_box.Controls.Add(this.stok_adet_lbl);
            this.urun_detay_grp_box.Controls.Add(this.birim_fiyat_lbl);
            this.urun_detay_grp_box.Controls.Add(this.urun_ad_lbl);
            this.urun_detay_grp_box.Controls.Add(this.urun_no_lbl);
            this.urun_detay_grp_box.Location = new System.Drawing.Point(192, 26);
            this.urun_detay_grp_box.Name = "urun_detay_grp_box";
            this.urun_detay_grp_box.Size = new System.Drawing.Size(200, 126);
            this.urun_detay_grp_box.TabIndex = 4;
            this.urun_detay_grp_box.TabStop = false;
            this.urun_detay_grp_box.Text = "Ürün Detaylar";
            // 
            // urun_no_lbl
            // 
            this.urun_no_lbl.AutoSize = true;
            this.urun_no_lbl.Location = new System.Drawing.Point(15, 23);
            this.urun_no_lbl.Name = "urun_no_lbl";
            this.urun_no_lbl.Size = new System.Drawing.Size(50, 13);
            this.urun_no_lbl.TabIndex = 1;
            this.urun_no_lbl.Text = "Ürün No:";
            // 
            // urun_ad_lbl
            // 
            this.urun_ad_lbl.AutoSize = true;
            this.urun_ad_lbl.Location = new System.Drawing.Point(15, 46);
            this.urun_ad_lbl.Name = "urun_ad_lbl";
            this.urun_ad_lbl.Size = new System.Drawing.Size(49, 13);
            this.urun_ad_lbl.TabIndex = 2;
            this.urun_ad_lbl.Text = "Ürün Ad:";
            // 
            // birim_fiyat_lbl
            // 
            this.birim_fiyat_lbl.AutoSize = true;
            this.birim_fiyat_lbl.Location = new System.Drawing.Point(15, 68);
            this.birim_fiyat_lbl.Name = "birim_fiyat_lbl";
            this.birim_fiyat_lbl.Size = new System.Drawing.Size(57, 13);
            this.birim_fiyat_lbl.TabIndex = 3;
            this.birim_fiyat_lbl.Text = "Birim Fiyat:";
            // 
            // stok_adet_lbl
            // 
            this.stok_adet_lbl.AutoSize = true;
            this.stok_adet_lbl.Location = new System.Drawing.Point(15, 93);
            this.stok_adet_lbl.Name = "stok_adet_lbl";
            this.stok_adet_lbl.Size = new System.Drawing.Size(57, 13);
            this.stok_adet_lbl.TabIndex = 4;
            this.stok_adet_lbl.Text = "Stok Adet:";
            // 
            // northwind_kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 175);
            this.Controls.Add(this.urun_detay_grp_box);
            this.Controls.Add(this.urunler_cmb_box);
            this.Controls.Add(this.kategori_cmb_box);
            this.Controls.Add(this.urunler_lbl);
            this.Controls.Add(this.kategoriler_lbl);
            this.Name = "northwind_kategori";
            this.Text = "northwind_kategori";
            this.urun_detay_grp_box.ResumeLayout(false);
            this.urun_detay_grp_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kategoriler_lbl;
        private System.Windows.Forms.Label urunler_lbl;
        private System.Windows.Forms.ComboBox kategori_cmb_box;
        private System.Windows.Forms.ComboBox urunler_cmb_box;
        private System.Windows.Forms.GroupBox urun_detay_grp_box;
        private System.Windows.Forms.Label stok_adet_lbl;
        private System.Windows.Forms.Label birim_fiyat_lbl;
        private System.Windows.Forms.Label urun_ad_lbl;
        private System.Windows.Forms.Label urun_no_lbl;
    }
}