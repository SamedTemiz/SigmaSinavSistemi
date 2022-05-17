using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SigmaSinavSistemi
{
    public class Kullanici : Database
    {
        public Kullanici()
        {
            Baglan();
        }

        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public int KullaniciTipID { get; set; }

        private bool kontrolKullanici(Kullanici kul)
        {
            bool result = false;

            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd = '" + kul.KullaniciAd + "'", conn);
            conn.Open();
            var oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                result = true;
            }
            conn.Close();

            return result;
        }
        public Kullanici girisKullanici(string kulad, string sifre)
        {
            Kullanici kul = null;
            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd= '" + kulad + "' AND Sifre= '" + sifre + "'", conn);
            conn.Open();
            var oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                kul = new Kullanici();
                kul.Id = int.Parse(oku[0].ToString());
                kul.KullaniciAd = oku[1].ToString();
                kul.Sifre = oku[5].ToString();
                kul.KullaniciTipID = int.Parse(oku[6].ToString());
            }
            return kul;
        }
        public bool ekleKullanici(Kullanici kul)
        {
            bool result = false;
            if (!kontrolKullanici(kul))
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Kullanicilar(KullaniciAd, Ad, Soyad, Mail, Sifre) VALUES ('" + kul.KullaniciAd + "', '" + kul.Ad + "', '" + kul.Soyad + "', '" + kul.Mail + "', '"+kul.Sifre+"')", conn);
                
                if (cmd.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                conn.Close();
            }
            return result;
        }
        public bool MailKontrol(string mail)
        {
            bool result = false;

            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE Mail = '" + mail + "'", conn);
            conn.Open();
            var oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                result = true;
            }
            conn.Close();

            return result;
        }
        public List<Kullanici> KulListele(string kullaniciadi)
        {
            List<Kullanici> kullanicilist = new List<Kullanici>();
            conn.Open();
            cmd = new SqlCommand("SELECT * From Kullanicilar where KullaniciAd='"+kullaniciadi+"'", conn);

            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciAd = oku[1].ToString();
                kullanici.Ad = oku[2].ToString();
                kullanici.Soyad = oku[3].ToString();
                kullanici.Mail = oku[4].ToString();
                kullanici.Sifre = oku[5].ToString();

                kullanicilist.Add(kullanici);
            }
            conn.Close();
            return kullanicilist;
        }
        public bool KullaniciBilgiGuncelle(string kullaniciadi,string ad,string soyad,string mail) 
        {
            bool kontol = false;
            cmd = new SqlCommand("Update Kullanicilar" + " Set KullaniciAd='" + kullaniciadi + "',Ad='" + ad + "',Soyad='" + soyad + "', Mail='"+mail+"' where KullaniciAd='" + kullaniciadi+ "'", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontol = true;
            }
            conn.Close();
            return kontol;
        }
        public bool KullaniciGuncelle(int id, string kulad, string ad, string soyad, string mail, string sifre, int kul_tip)
        {
            bool kontrol = false;
            cmd = new SqlCommand("UPDATE Kullanicilar SET KullaniciAd='" + kulad + "',Ad='" + ad + "',Soyad='" + soyad + "',Mail='" + mail + "',Sifre='" + sifre + "',KullaniciTipID='" + kul_tip + "' WHERE Id='" + id + "'", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontrol = true;
            }
            conn.Close();
            return kontrol;
        }
        public bool KullaniciSil(int Id)
        {
            bool kontrol = false;
            cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE Id = '" + Id + "'", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontrol = true;
            }
            conn.Close();
            return kontrol;
        }
        public List<Kullanici> KulListeleA()
        {
            List<Kullanici> kullanicilist = new List<Kullanici>();
            conn.Open();
            cmd = new SqlCommand("SELECT * From Kullanicilar", conn);

            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                Kullanici kullanici = new Kullanici();
                kullanici.Id = int.Parse(oku[0].ToString());
                kullanici.KullaniciAd = oku[1].ToString();
                kullanici.Ad = oku[2].ToString();
                kullanici.Soyad = oku[3].ToString();
                kullanici.Mail = oku[4].ToString();
                kullanici.Sifre = oku[5].ToString();
                kullanici.KullaniciTipID = int.Parse(oku[6].ToString());

                kullanicilist.Add(kullanici);
            }
            conn.Close();
            return kullanicilist;
        }
    }
}
