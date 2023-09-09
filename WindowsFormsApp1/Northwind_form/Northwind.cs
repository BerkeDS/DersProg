using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Database;

namespace WindowsFormsApp1
{
    public partial class Northwind : Form
    {
        public Northwind()
        {
            InitializeComponent();
        }

        private void program_btn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        ShipperDAL shipDAL = new ShipperDAL();
        private void insert_btn_Click(object sender, EventArgs e)
        {
            string company_name = txt_sirket_ad.Text;
            string phone = txt_tel.Text;

            bool result = shipDAL.Add_ekle(company_name, phone);

            if (result)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_sirket_id.Text);
            string company_name = txt_sirket_ad.Text;
            string phone = txt_tel.Text;

            bool result = shipDAL.Update_guncelle(id, company_name, phone);

            if (result)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_sirket_id.Text);
            

            bool result = shipDAL.Delete_sil(id);

            if (result)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            northwind_datagrid abc = new northwind_datagrid();
            abc.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            northwind_kategori ab = new northwind_kategori();
            ab.Show();
            this.Close();
        }
    }
}
