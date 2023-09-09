using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using WindowsFormsApp1.ana_form;
using System.Data.SqlClient;
using WindowsFormsApp1.Database;



namespace WindowsFormsApp1
{
    public partial class hesap_ayar_form : Form
    {
        public hesap_ayar_form()
        {
            InitializeComponent();
        }

        //SqlConnection conn = new SqlConnection("server=DESKTOP-M8NF4AB\\SQLEXPRESS; Initial Catalog=Program; Integrated Security=SSPI");

        string k_ad;
        string sifre;

        kullaniciDAL kdal = new kullaniciDAL();

        bool kont = false;
        int id_tutucu;
        

        private void giris_btn_Click(object sender, EventArgs e)
        {

            k_ad = k_ad_textBox.Text;
            sifre = sifre_textBox.Text;
            List<Kullanici> kul_kontrol = kdal.Get_kullanici_kayitlar(k_ad);

            if (kul_kontrol == null || kul_kontrol.Count <=0 )
            {
                MessageBox.Show("Böyle Bir Kullanıcı Adı Yok");
            }
            else
            {
                var tutucu = kul_kontrol.Select(aa => aa.Sifre);
                if (tutucu.Contains(sifre))
                {
                    kont = true;
                    MessageBox.Show("Giriş Başarılı");
                    k_bilgi_grpbox.Visible = true;
                }
                else
                {
                    MessageBox.Show("Hatalı Şifre");
                    k_bilgi_grpbox.Visible = false;
                }
            }           


            if (kont)
            {
                List<Kullanici> abc = kdal.Get_kullanici_kayit_bilgi(k_ad);

                foreach (var item in abc)
                {
                    id_tutucu = item.Kullanici_id;
                    ad_textBox.Text = item.Ad;
                    soyad_textBox.Text = item.Soyad;
                    kul_ad_lbl.Text = item.Kullanici_ad;
                    email_textBox.Text = item.Email;
                    sifre_bilgi_textBox.Text = item.Sifre;
                    
                }
            }
            
        }

        private void hesap_ayar_form_Load(object sender, EventArgs e)
        {
            k_bilgi_grpbox.Visible = false;
        }
        

        private void delete_btn_Click(object sender, EventArgs e)
        {
            kdal.kullanici_sil(id: id_tutucu);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            kdal.kullanici_guncelle
                (
                kullanici_id: id_tutucu,
                ad: ad_textBox.Text,
                soyad: soyad_textBox.Text,
                kullanici_ad: kul_ad_lbl.Text,
                email: email_textBox.Text,
                sifre: sifre_bilgi_textBox.Text
                );
        }
    }
}
