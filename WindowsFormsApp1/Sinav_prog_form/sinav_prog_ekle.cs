using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.Database;

namespace WindowsFormsApp1
{
    public partial class sinav_prog_ekle : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-M8NF4AB\\SQLEXPRESS; Initial Catalog=Program;Integrated Security=SSPI");
        public sinav_prog_ekle()
        {
            InitializeComponent();
        }

        private void sinav_prog_ekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'programDataSet1.ogretim_görevli' table. You can move, or remove it, as needed.
            this.ogretim_görevliTableAdapter.Fill(this.programDataSet1.ogretim_görevli);
            // TODO: This line of code loads data into the 'programDataSet.derslikler' table. You can move, or remove it, as needed.
            this.dersliklerTableAdapter.Fill(this.programDataSet.derslikler);

        }
        string g_ad;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();           
            int ders_no=1;          
            g_ad = gun_textBox.Text;
            
            switch (comboBox2.Text)
            {
                case "Veri tabanı":
                    ders_no = 1;
                    break;
                case "Eğitimde Grafik":
                    ders_no = 2;
                    break;
                case "Yabancı dil 1":
                    ders_no = 3;
                    break;
                case "Eğitim bilimleri":
                    ders_no = 4;
                    break;
                case "Öğretim ilke ve yöntemleri":
                    ders_no = 5;
                    break;

                default:
                    break;
            }


            //sinav_progDAL sinav_dal = new sinav_progDAL();
            //sinav_dal.sinav_insert
            //    (
            //    gun_ad:g_ad.ToString(),
            //    ders_no: ders_no,
            //    derslik_no: (int)comboBox3.SelectedValue,
            //    tarih: dateTimePicker1.Value,
            //    saat: textBox1.Text,
            //    gozetmen_no: (int)comboBox4.SelectedValue
            //    );

            try
            {
                SqlCommand ekle = new SqlCommand("INSERT INTO sinav_prog (gun_ad,ders_no,derslik_kay_no,tarih,saat,gozetmen_no)" +
                "VALUES(@gunad,@dersno,@derslikno,@tarih,@saat,@gozetmenno)",con);

                ekle.Parameters.AddWithValue("@gunad", g_ad.ToString());
                ekle.Parameters.AddWithValue("@dersno", ders_no);
                ekle.Parameters.AddWithValue("@derslikno", comboBox3.SelectedValue);
                ekle.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                ekle.Parameters.AddWithValue("@saat", textBox1.Text);
                ekle.Parameters.AddWithValue("@gozetmenno", comboBox4.SelectedValue);

                ekle.ExecuteNonQuery();
            }
            catch (SqlException)
            {

                MessageBox.Show("Hata Oluştu");
            }
            finally
            {
                con.Close();
                MessageBox.Show("İşlem Başarılı");
            }         
            
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gun_textBox.Text = dateTimePicker1.Value.DayOfWeek.ToString();
        }
    }
}
