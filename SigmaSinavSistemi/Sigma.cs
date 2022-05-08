using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Collections;
using System.IO;

namespace SigmaSinavSistemi
{
    class Sigma : SoruHavuzu
    {
        public Sigma()
        {
            Baglan();
        }
        public int SoruId { get; set; }
        public DateTime GuncelTarih { get; set; }
        public DateTime HatirlatmaTarihi { get; set; }
        public int Basari { get; set; }

        public List<Sigma> SoruOzellik()
        {
            List<Sigma> sistem = new List<Sigma>();
            cmd = new SqlCommand("SELECT * FROM Sigma", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                Sigma sigma = new Sigma();
                sigma.SoruId = int.Parse(oku[1].ToString());//SoruHavuzu Id ile aynı
                sigma.GuncelTarih = Convert.ToDateTime(oku[2].ToString());
                sigma.HatirlatmaTarihi = Convert.ToDateTime(oku[3].ToString());
                sigma.Derece = int.Parse(oku[4].ToString());
                sigma.Basari = int.Parse(oku[5].ToString());
                sistem.Add(sigma);
            }
            conn.Close();
            return sistem;
        }
        public void TarihGuncelle()
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE Sigma SET GuncelTarih = GETDATE()", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int[] Dereceliler()//doğru bildikleri
        {
            int adet = 0;
            conn.Open();
            SqlCommand sayi = new SqlCommand("SELECT COUNT(*) FROM Sigma WHERE Derece > 0 AND GuncelTarih >= HatirlatmaTarih", conn);
            adet = (int)sayi.ExecuteScalar();
            int[] dereceli = new int[adet];
            //Dereceli ve hatirlatma tarihi uygun olan soruları çekiyoruz
            cmd = new SqlCommand("SELECT SoruId FROM Sigma WHERE Derece > 0 AND GuncelTarih >= HatirlatmaTarih", conn);
            SqlDataReader oku = cmd.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
                dereceli[i] = int.Parse(oku[0].ToString());
                i++;
            }
            conn.Close();
            return dereceli;
        }   
    }
}

