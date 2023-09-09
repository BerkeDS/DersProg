using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class kullanici_ekle_form : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.ProgramConnectionString"].ConnectionString);

        public kullanici_ekle_form()
        {
            InitializeComponent();
            sifre_tekrar_textBox.TextChanged += Sifre_tekrar_textBox_TextChanged;
            kul_ad_textBox.Leave += Kul_ad_textBox_Leave;
        }

        bool kul_kontroll = false;

        private void Kul_ad_textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                var gelen_deger = kul_ad_textBox.Text;

                
                string sorgu_ = "SELECT kullanici_ad FROM kullanici WHERE kullanici_ad = @k_adi";
                SqlCommand sql_command = new SqlCommand(sorgu_, conn);

                sql_command.Parameters.AddWithValue("@k_adi", kul_ad_textBox.Text);

                string deger = string.Empty;

                if (sql_command.ExecuteScalar()==null)
                {
                    deger = string.Empty;
                }
                else
                {
                    deger = sql_command.ExecuteScalar().ToString();
                }
                

                if (!string.IsNullOrEmpty(deger))
                {
                    kul_kontroll = false;
                    kul_kontrol_lbl.Text = "Kullanıcı Adı Mevcut";
                }
                else
                {
                    kul_kontroll = true;
                    kul_kontrol_lbl.Text = "Kullanıcı Adı Kullanılabilir";
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            

        }

        bool kont = false;

        private void Sifre_tekrar_textBox_TextChanged(object sender, EventArgs e)
        {
            if (sifre_tekrar_textBox.Text.Equals(sifre_textBox.Text))
            {
                kont = true;
                checkBox1.Checked = true;
                checkBox6.Checked = true;
            }
            else
            {
                kont = false;
                checkBox1.Checked = false;
                checkBox6.Checked = false;
            }
        }

        


        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            var ad = ad_textBox.Text;
            var soyad = soyad_textBox.Text;
            var kullanici_ad = kul_ad_textBox.Text;
            var email = email_textBox.Text;
            var sifre = sifre_textBox.Text;

            if (kont && kul_kontroll)
            {
                kullanici_ekle
                (
                    ad: ad,
                    soyad: soyad,
                    kullanici_ad: kullanici_ad,
                    email: email,
                    sifre: sifre
                );
            }
            else
            {
                MessageBox.Show("Hata");
            }                    

        }

        void kullanici_ekle(string ad, string soyad, string kullanici_ad, string email, string sifre)
        {
            try
            {
                SqlCommand sql_command = new SqlCommand();
                sql_command.Connection = conn;
                sql_command.CommandType = CommandType.StoredProcedure;
                sql_command.CommandText = "pr_kullanici_ekle";

                // Veri Tabanında pr_kullanici_ekle adında proc oluştur.

                #region PROC

                //                create PROC pr_kullanici_ekle
                //@AD NVARCHAR(50),
                //	@SOYAD NVARCHAR(50),
                //	@KULLANICI_AD NVARCHAR(50),
                //	@EMAIL NVARCHAR(50),
                //	@SIFRE NVARCHAR(50)
                //AS
                //BEGIN

                //    INSERT INTO kullanici
                //    (

                //        [ad]
                //       ,[soyad]
                //       ,[kullanici_ad]
                //       ,[email]
                //       ,[sifre]
                //	) 

                //    VALUES
                //    (
                //        @AD,
                //        @SOYAD,
                //        @KULLANICI_AD,
                //        @EMAIL,
                //        @SIFRE

                //    );
                //        END
#endregion

                SqlParameter[] parameters =
                {
                    new SqlParameter("@AD",ad),
                    new SqlParameter("@SOYAD",soyad),
                    new SqlParameter("@KULLANICI_AD",kullanici_ad),
                    new SqlParameter("@EMAIL",email),
                    new SqlParameter("@SIFRE",sifre)
                };

                conn.Open();
                sql_command.Parameters.AddRange(parameters);
                int x = sql_command.ExecuteNonQuery();
                MessageBox.Show("Etkilenen Kayıt Sayısı" + x);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
                this.Close();
            }
        }

        

        private void kul_ad_textBox_TextChanged(object sender, EventArgs e)
        {
            #region kontrol deneme 1
            //try
            //{
            //    conn.Open();
            //    k_ad = kul_ad_textBox.Text;
            //    string sorgu = "SELECT COUNT(kullanici_id) FROM kullanici WHERE kullanici_ad=" + k_ad;
            //    SqlCommand cmd = new SqlCommand(sorgu, conn);
            //    kul_kontroll = Convert.ToInt32(cmd.ExecuteScalar()) > 0 ? false : true ;
            //    if (!kul_kontroll)
            //    {
            //        kul_kontrol.Text = "Kullanici Adi mevcut";
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion
            #region kontrol deneme
            //try
            //{
            //    conn.Open();
            //    k_ad = kul_ad_textBox.Text;
            //    string sorgu = "SELECT kullanici_ad FROM kullanici WHERE kullanici_ad=" + k_ad;

            //    List<string> aaa = new List<string>();

            //    SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    DataTableReader dr = new DataTableReader(dt);
            //    if (dr.Read())
            //    {
            //        aaa.Add(dr["kullanici_ad"].ToString());
            //    }

            //    foreach (string item in aaa)
            //    {
            //        if (item.Equals(k_ad))
            //        {
            //            kul_kontroll = false;
            //            kul_kontrol.Text = "Kullanıcı adı alınmış";
            //        }
            //        else
            //        {
            //            kul_kontroll = true;
            //            kul_kontrol.Text = "Uygun";
            //        }
            //    }
            //}
            //catch (SqlException ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion

        }
    }
}
