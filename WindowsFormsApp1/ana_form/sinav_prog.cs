using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1.ana_form
{
    class sinav_prog
    {
        private string gun_ad;
        private int ders_no;
        private int derslik_no;
        private DateTime tarih;
        private string saat;
        private int gozetmen_no;

        public string Gun_ad
        {
            get
            {
                return gun_ad;
            }

            set
            {
                gun_ad = value;
            }
        }

        public int Ders_no
        {
            get
            {
                return ders_no;
            }

            set
            {
                ders_no = value;
            }
        }

        public int Derslik_no
        {
            get
            {
                return derslik_no;
            }

            set
            {
                derslik_no = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return tarih;
            }

            set
            {
                tarih = value;
            }
        }

        public string Saat
        {
            get
            {
                return saat;
            }

            set
            {
                saat = value;
            }
        }

        public int Gozetmen_no
        {
            get
            {
                return gozetmen_no;
            }

            set
            {
                gozetmen_no = value;
            }
        }

        public sinav_prog()
        {

        }
        public sinav_prog(string gun_adi, int ders_numara, int derslik_numara, DateTime tarihi, string saati, int gozetmen_numara)
        {
            Gun_ad = gun_adi;
            Ders_no = ders_numara;
            Derslik_no = derslik_numara;
            Tarih = tarihi;
            Saat = saati;
            Gozetmen_no = gozetmen_numara;
        }
    }
}

