using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SigmaSinavSistemi
{
    public class SifreGuncelle : Database
    {
        public SifreGuncelle()
            {
                Baglan();
            }
        public bool Sifreguncelle(string kulad,string sifre)
        {
            
            bool kontol = false;
            cmd = new SqlCommand("Update Kullanicilar" + " Set Sifre='"+sifre+"'  where KullaniciAd='" + kulad + "'", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontol = true;
            }
            conn.Close();
            return kontol;

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

        public bool KullaniciAdKontrol(string kulad) 
        {
            bool result = false;

            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd = '" + kulad + "'", conn);
            conn.Open();
            var oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                result = true;
            } 
            conn.Close();
            return result;
        }
    }
}
