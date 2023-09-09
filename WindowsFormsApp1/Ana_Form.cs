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
    public partial class Ana_Form : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-M8NF4AB\\SQLEXPRESS; Initial Catalog=Program; Integrated Security=SSPI");
        //SqlConnection con = new SqlConnection(database.okul_baglanti);

        public Ana_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql_sorgu = "Select tarih AS [Tarih],gun_ad AS [Gün],saat AS [Saat],ders_ad AS [Ders],derslik_ad AS [Derslik],ad_soyad AS [Gözetmen] from sinav_prog join dersler on sinav_prog.ders_no = dersler.ders_no join derslikler on sinav_prog.derslik_kay_no = derslikler.derslik_kay_no join ogretim_görevli on sinav_prog.gozetmen_no=ogretim_görevli.ogr_grv_kay_No ORDER BY tarih,saat";
            SqlDataAdapter da = new SqlDataAdapter(sql_sorgu, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //dataGrid.DataContext = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sinav_prog_ekle ac = new sinav_prog_ekle();
            ac.Show();
        }

        private void northwind_btn_Click(object sender, EventArgs e)
        {            
            Northwind aa = new Northwind();
            aa.Show();            
        }

        private void kayit_btn_Click(object sender, EventArgs e)
        {
            kullanici_ekle_form ac = new kullanici_ekle_form();
            ac.Show();
        }

        private void hesap_ayar_Click(object sender, EventArgs e)
        {
            hesap_ayar_form aa = new hesap_ayar_form();
            aa.Show();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
