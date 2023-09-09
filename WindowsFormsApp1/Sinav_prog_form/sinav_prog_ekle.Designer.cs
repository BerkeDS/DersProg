namespace WindowsFormsApp1
{
    partial class sinav_prog_ekle
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
            this.components = new System.ComponentModel.Container();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dersliklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programDataSet = new WindowsFormsApp1.ProgramDataSet();
            this.dersliklerTableAdapter = new WindowsFormsApp1.ProgramDataSetTableAdapters.dersliklerTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.ogretimgörevliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programDataSet1 = new WindowsFormsApp1.ProgramDataSet1();
            this.programDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogretim_görevliTableAdapter = new WindowsFormsApp1.ProgramDataSet1TableAdapters.ogretim_görevliTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gun_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dersliklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretimgörevliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Veri tabanı",
            "Eğitimde Grafik",
            "Yabancı dil 1",
            "Eğitim bilimleri",
            "Öğretim ilke ve yöntemleri"});
            this.comboBox2.Location = new System.Drawing.Point(139, 130);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Ders";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.dersliklerBindingSource;
            this.comboBox3.DisplayMember = "derslik_ad";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(139, 169);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(239, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "derslik_kay_no";
            // 
            // dersliklerBindingSource
            // 
            this.dersliklerBindingSource.DataMember = "derslikler";
            this.dersliklerBindingSource.DataSource = this.programDataSet;
            // 
            // programDataSet
            // 
            this.programDataSet.DataSetName = "ProgramDataSet";
            this.programDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersliklerTableAdapter
            // 
            this.dersliklerTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 16);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Örn 15:00";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.ogretimgörevliBindingSource;
            this.comboBox4.DisplayMember = "ad_soyad";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(139, 211);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(239, 24);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "ogr_grv_kay_No";
            // 
            // ogretimgörevliBindingSource
            // 
            this.ogretimgörevliBindingSource.DataMember = "ogretim_görevli";
            this.ogretimgörevliBindingSource.DataSource = this.programDataSet1;
            // 
            // programDataSet1
            // 
            this.programDataSet1.DataSetName = "ProgramDataSet1";
            this.programDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programDataSetBindingSource
            // 
            this.programDataSetBindingSource.DataSource = this.programDataSet;
            this.programDataSetBindingSource.Position = 0;
            // 
            // ogretim_görevliTableAdapter
            // 
            this.ogretim_görevliTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(23, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ders Seçin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Derslik Seçin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tarih Seçin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saati Girin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gözetmeni Seçin";
            // 
            // gun_textBox
            // 
            this.gun_textBox.Location = new System.Drawing.Point(139, 53);
            this.gun_textBox.Name = "gun_textBox";
            this.gun_textBox.Size = new System.Drawing.Size(239, 23);
            this.gun_textBox.TabIndex = 13;
            // 
            // sinav_prog_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 308);
            this.Controls.Add(this.gun_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sinav_prog_ekle";
            this.Text = "sinav_prog_ekle";
            this.Load += new System.EventHandler(this.sinav_prog_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dersliklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretimgörevliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private ProgramDataSet programDataSet;
        private System.Windows.Forms.BindingSource dersliklerBindingSource;
        private ProgramDataSetTableAdapters.dersliklerTableAdapter dersliklerTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource programDataSetBindingSource;
        private ProgramDataSet1 programDataSet1;
        private System.Windows.Forms.BindingSource ogretimgörevliBindingSource;
        private ProgramDataSet1TableAdapters.ogretim_görevliTableAdapter ogretim_görevliTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gun_textBox;
    }
}