using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class northwind_kategori : Form
    {
        public northwind_kategori()
        {
            InitializeComponent();

            this.Load += Northwind_kategori_Load;
            kategori_cmb_box.SelectedIndexChanged += Kategori_cmb_box_SelectedIndexChanged;
            urunler_cmb_box.SelectedIndexChanged += Urunler_cmb_box_SelectedIndexChanged;
        }

        private void Urunler_cmb_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secili_id;
            if (urunler_cmb_box.SelectedIndex > 0)
            {
                secili_id = (int)((ComboBox)sender).SelectedValue;
                urun_detay_getir(secili_id);
            }

        }

        private void Kategori_cmb_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secili_id = 0;

            if (kategori_cmb_box.SelectedIndex > 0)
            {
                if (((ComboBox)sender).SelectedValue != null)
                {
                    secili_id = (int)((ComboBox)sender).SelectedValue;
                    kategori_ait_urunleri_getir(secili_id);
                }
            }
        }

        private void Northwind_kategori_Load(object sender, EventArgs e)
        {
            kategori_doldur();
        }


        //İş Yapan Metotlar

        SqlConnection con = new SqlConnection(Database.database.get_con_string);
        SqlCommand sql_command;

        public void kategori_doldur()
        {
            DataTable dt = new DataTable();
            sql_command = new SqlCommand ("SELECT CategoryID,CategoryName FROM Categories",con);

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                dt.Load(sql_command.ExecuteReader());

                kategori_cmb_box.DataSource = dt;
                kategori_cmb_box.DisplayMember = "CategoryName";
                kategori_cmb_box.ValueMember = "CategoryID";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        public void kategori_ait_urunleri_getir(int kategori_id)
        {
            DataTable dt = new DataTable("Products");
            sql_command = new SqlCommand("SELECT ProductID, ProductName FROM Products WHERE CategoryID="+ kategori_id, con);

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                dt.Load(sql_command.ExecuteReader());

                urunler_cmb_box.DataSource = dt;
                urunler_cmb_box.DisplayMember = "ProductName";
                urunler_cmb_box.ValueMember = "ProductID";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        public void urun_detay_getir(int urun_id)
        {
            string sorgu = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products WHERE ProductID=@UrunID ";
            DataTable dt = new DataTable("ProductDetails");
            sql_command = new SqlCommand (sorgu, con);

            sql_command.Parameters.AddWithValue("@UrunID",urun_id);

            try
            {
                //con.Open();
                //sql_command.Connection.Open();
                if (sql_command.Connection.State != ConnectionState.Open)
                {
                    sql_command.Connection.Open();
                }
                dt.Load(sql_command.ExecuteReader());

                urun_no_lbl.Text = "Ürün No: " + dt.Rows[0][0].ToString();
                urun_ad_lbl.Text = "Ürün Ad: " + dt.Rows[0]["ProductName"].ToString();
                birim_fiyat_lbl.Text = "Birim Fiyat: " + dt.Rows[0]["UnitPrice"].ToString();
                stok_adet_lbl.Text = "Stok Adet: " + dt.Rows[0]["UnitsInStock"].ToString();
            }
            catch
            {

                throw;
            }
            finally
            {
                sql_command.Connection.Close();
            }
        }
    }
}
