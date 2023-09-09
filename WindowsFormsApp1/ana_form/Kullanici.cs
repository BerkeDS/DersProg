using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ana_form
{
    public class Kullanici
    {
        private int _kullanici_id;
        private string _ad;
        private string _soyad;
        private string _kullanici_ad;
        private string _email;
        private string _sifre;

        public string Ad { get { return _ad; } set { _ad = value; } }
        public string Soyad { get { return _soyad; } set { _soyad = value; } }
        public string Kullanici_ad { get { return _kullanici_ad; } set { _kullanici_ad = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Sifre { get { return _sifre; } set { _sifre = value; } }
        public int Kullanici_id { get { return _kullanici_id; } set { _kullanici_id = value; } }

        public Kullanici(int kullanici_id,string ad,string soyad, string kullanici_ad, string email, string sifre)
        {
            this.Kullanici_id = kullanici_id;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Kullanici_ad = kullanici_ad;
            this.Email = email;
            this.Sifre = sifre;
        }

        public Kullanici(string kullanici_ad, string sifre)
        {
            this.Kullanici_ad = kullanici_ad;
            this.Sifre = sifre;
        }
    }
}
