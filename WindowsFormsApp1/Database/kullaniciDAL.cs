using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ana_form;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Database
{
    class kullaniciDAL
    {
        string sql = string.Empty;
        SqlCommand sql_command;
        SqlConnection con = new SqlConnection(database.prog_baglanti);

        // Sifre Dönen Denenmedi
        public string sifre_donen(string k_ad)
        {
            string deger = string.Empty;
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string gelen_deger = k_ad;


                string sorgu_ ="SELECT sifre FROM kullanici WHERE kullanici_ad = @ad "; ;
                SqlCommand sql_command = new SqlCommand(sorgu_, con);

                sql_command.Parameters.AddWithValue("@ad", gelen_deger);

                

                if (sql_command.ExecuteScalar() == null)
                {
                    deger = string.Empty;
                }
                else
                {
                    deger = sql_command.ExecuteScalar().ToString();
                }

                

                //if (!string.IsNullOrEmpty(deger))
                //{
                //    kul_kontroll = false;
                //    kul_kontrol_lbl.Text = "Kullanıcı Adı Mevcut";
                //}
                //else
                //{
                //    kul_kontroll = true;
                //    kul_kontrol_lbl.Text = "Kullanıcı Adı Kullanılabilir";
                //}
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                
            }

            return deger;
            
        }
        public List<Kullanici> Get_kullanici_kayitlar(string kullanici_adi)
        {
            sql = "SELECT kullanici_ad,sifre FROM kullanici WHERE kullanici_ad = @ad ";
            sql_command = new SqlCommand(sql, con);
            sql_command.Parameters.AddWithValue("@ad", kullanici_adi);
            List<Kullanici> kullanicii = new List<Kullanici>();
            

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader dr = sql_command.ExecuteReader();
                while (dr.Read())
                {
                    kullanicii.Add(new Kullanici(dr["kullanici_ad"].ToString(), dr["sifre"].ToString()));
                }

            }
            
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return kullanicii;
        }
        public List<Kullanici> Get_kullanici_kayit_bilgi(string kul_ad)
        {
            sql = "SELECT kullanici_id,ad,soyad,kullanici_ad,email,sifre FROM kullanici WHERE kullanici_ad = @ad ";
            sql_command = new SqlCommand(sql, con);
            sql_command.Parameters.AddWithValue("@ad", kul_ad);
            List<Kullanici> kullanicii = new List<Kullanici>();


            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader dr = sql_command.ExecuteReader();
                while (dr.Read())
                {
                    kullanicii.Add(new Kullanici((int)dr["kullanici_id"], dr["ad"].ToString(), dr["soyad"].ToString(), dr["kullanici_ad"].ToString(), dr["email"].ToString(), dr["sifre"].ToString()));
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return kullanicii;
        }
        public void kullanici_guncelle(int kullanici_id, string ad, string soyad, string kullanici_ad, string email, string sifre)
        {            
            try
            {
                sql = "UPDATE kullanici SET ad = @ad , soyad = @soyad ,kullanici_ad = @k_ad ,email = @email ,sifre = @sifre WHERE kullanici_id = @id ";
                sql_command = new SqlCommand(sql, con);
                sql_command.Parameters.AddWithValue("@ad", ad);
                sql_command.Parameters.AddWithValue("@soyad", soyad);
                sql_command.Parameters.AddWithValue("@k_ad", kullanici_ad);
                sql_command.Parameters.AddWithValue("@email", email);
                sql_command.Parameters.AddWithValue("@sifre", sifre);
                sql_command.Parameters.AddWithValue("@id", kullanici_id);
                if (sql_command.Connection.State != ConnectionState.Open)
                {
                    sql_command.Connection.Open();
                }

                int a = (int)sql_command.ExecuteNonQuery();

                if (a>0)
                {
                    MessageBox.Show("İşlem Başarılı");
                }
                else
                {
                    MessageBox.Show("Hata Oluştu");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void kullanici_sil(int id)
        {
            try
            {
                sql = "DELETE FROM kullanici WHERE kullanici_id = @id";
                sql_command = new SqlCommand(sql, con);
                sql_command.Parameters.AddWithValue("@id", id);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                int a = sql_command.ExecuteNonQuery();

                if (a>0)
                {
                    MessageBox.Show("Hesap Silindi");
                }
                else
                {
                    MessageBox.Show("Hata Oluştu");
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
