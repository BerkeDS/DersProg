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
using WindowsFormsApp1.ana_form;

namespace WindowsFormsApp1.Sinav_prog_form
{
    public partial class sinav_prog_guncelle : Form
    {
        List<sinav_prog> bilgiler = new List<sinav_prog>();
        public sinav_prog_guncelle()
        {
            InitializeComponent();
            
        }

        private void sinav_prog_guncelle_Load(object sender, EventArgs e)
        {
            sinav_progDAL nesne = new sinav_progDAL();
            
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            int ders_no = 1;            

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

            bilgiler = nesne.sinav_prog_guncelle_bilgi_getir( ders_no );

        }

       
    }
}
