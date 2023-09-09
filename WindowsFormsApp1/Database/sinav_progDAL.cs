using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.ana_form;


namespace WindowsFormsApp1.Database
{
    sealed class sinav_progDAL
    {
        SqlConnection con = new SqlConnection(database.prog_baglanti);
        SqlCommand sql_command;
        string sorgu = string.Empty;

        //Sinav insert denenmedi
        public void sinav_insert(string gun_ad, int ders_no, int derslik_no, DateTime tarih, string saat, int gozetmen_no)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                sorgu = "INSERT INTO sinav_prog (gun_ad, ders_no, derslik_kay_no, tarih, saat, gozetmen_no)" +
                "VALUES(@gunad,@dersno,@derslikno,@tarih,@saat,@gozetmenno)";
                sql_command = new SqlCommand(sorgu, con);

                sql_command.Parameters.AddWithValue("@gunad", gun_ad);
                sql_command.Parameters.AddWithValue("@dersno", ders_no);
                sql_command.Parameters.AddWithValue("@derslikno", derslik_no);
                sql_command.Parameters.AddWithValue("@tarih", tarih);
                sql_command.Parameters.AddWithValue("@saat", saat);
                sql_command.Parameters.AddWithValue("@gozetmenno", gozetmen_no);

                int a = sql_command.ExecuteNonQuery();

                if (a > 0)
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
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        //Sinav truncate denenmedi
        public void sinav_trucate()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                sorgu = "TRUNCATE TABLE sinav_prog";
                sql_command = new SqlCommand(sorgu, con);

                int a = sql_command.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Tablo Silindi");
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
        }

        //Sinav prog göster denenmedi
        public List<sinav_prog> sinav_prog_goster()
        {
            List<sinav_prog> prog = new List<sinav_prog>();
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                sorgu = "Select tarih AS [Tarih],gun_ad AS [Gün],saat AS [Saat],ders_ad AS [Ders],derslik_ad AS [Derslik],ad_soyad AS [Gözetmen]" +
                   " from sinav_prog join dersler on sinav_prog.ders_no = dersler.ders_no join derslikler on sinav_prog.derslik_kay_no = derslikler.derslik_kay_no join ogretim_görevli on sinav_prog.gozetmen_no=ogretim_görevli.ogr_grv_kay_No ORDER BY tarih,saat";
                sql_command = new SqlCommand(sorgu, con);

                SqlDataReader dr = sql_command.ExecuteReader();

                while (dr.Read())
                {
                    prog.Add(new sinav_prog(dr["gun_ad"].ToString(), (int)dr["ders_no"], (int)dr["derslik_no"], Convert.ToDateTime(dr["tarih"]), dr["saat"].ToString(), (int)dr["gozetmen_no"]));
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
            return prog;
        }

        //guncelle Tamamlanmadi
        //UPDATE [tablo adı] SET [yeni bilgiler] WHERE [şartlar]
        public List<sinav_prog> sinav_prog_guncelle_bilgi_getir(int ders_no)
        {
            List<sinav_prog> prog = new List<sinav_prog>();
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                sorgu = "Select tarih AS[Tarih],gun_ad AS[Gün], saat AS[Saat],ders_ad AS[Ders], derslik_ad AS[Derslik],ad_soyad AS[Gözetmen]" +
                   " from sinav_prog join dersler on sinav_prog.ders_no = dersler.ders_no join derslikler on sinav_prog.derslik_kay_no = derslikler.derslik_kay_no join ogretim_görevli on sinav_prog.gozetmen_no=ogretim_görevli.ogr_grv_kay_No WHERE ders_no=@dersno";
                sql_command = new SqlCommand(sorgu, con);
                sql_command.Parameters.AddWithValue("@dersno", ders_no);

                SqlDataReader dr = sql_command.ExecuteReader();

                while (dr.Read())
                {
                    prog.Add(new sinav_prog(dr["gun_ad"].ToString(), (int)dr["ders_no"], (int)dr["derslik_no"], Convert.ToDateTime(dr["tarih"]), dr["saat"].ToString(), (int)dr["gozetmen_no"]));
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
            return prog;
        }

        public void sinav_prog_guncelle(string gun_ad, int ders_no, int derslik_no, DateTime tarih, string saat, int gozetmen_no)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                sorgu = "UPDATE sinav_prog SET gun_ad = @gunad, ders_no= @dersno, derslik_kay_no=@derslik, tarih=@tarihh, saat=@saatt, gozetmen_no=@gozetmenno WHERE ders_no=@dersno";
                sql_command = new SqlCommand(sorgu, con);                
                sql_command.Parameters.AddWithValue("@gunad", gun_ad);
                sql_command.Parameters.AddWithValue("@dersno", ders_no);
                sql_command.Parameters.AddWithValue("@derslik", derslik_no);
                sql_command.Parameters.AddWithValue("@tarihh", tarih);
                sql_command.Parameters.AddWithValue("@saatt", saat);
                sql_command.Parameters.AddWithValue("@gozetmenno", gozetmen_no);

                int a = sql_command.ExecuteNonQuery();

                if (a > 0)
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
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
    }
}
