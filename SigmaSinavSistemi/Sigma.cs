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
        public string SinaviBitir(int[,] sonuc)
        {
            string msj = "not";
            string kmt = "not";
            //int dogru, yanlis, bos;
            //float basari;
            //string konu;
            int s_id, s_cvp;
            for (int i = 1; i < soruSayi + Dereceliler().Length + 1; i++)
            {
                s_id = sonuc[i, 1];
                s_cvp = sonuc[i, 2];
                var soru = Listele(0).Find(x => x.Id == s_id);
                int check = 0;
                if (soru.DogruCevap == s_cvp)
                {
                    var sigma = SoruOzellik().Find(x => x.SoruId == s_id);
                    switch (sigma.Derece)
                    {
                        case 0:
                            kmt = "DATEADD(day, 1, GuncelTarih)";//Bir gün sonra tekrar sorulacak
                            break;
                        case 1:
                            kmt = "DATEADD(week, 1, GuncelTarih)";//Bir hafta sonra tekrar sorulacak
                            break;
                        case 2:
                            kmt = "DATEADD(month, 1, GuncelTarih)";//Bir ay sonra tekrar sorulacak
                            break;
                        case 3:
                            kmt = "DATEADD(month, 3, GuncelTarih)";//Üç ay sonra tekrar sorulacak
                            break;
                        case 4:
                            kmt = "DATEADD(month, 6, GuncelTarih)";//Altı ay sonra tekrar sorulacak
                            break;
                        case 5:
                            kmt = "DATEADD(year, 1, GuncelTarih)";//Bir gün sonra tekrar sorulacak
                            break;
                    }
                    cmd = new SqlCommand("UPDATE Sigma SET Derece += 1, HatirlatmaTarih = "+kmt+" WHERE SoruId = "+ s_id +" ", conn);
                    conn.Open();
                    check = cmd.ExecuteNonQuery();
                }
                if (check > 0)
                    msj = "Test başarılı bir şekilde sonlandı.";
                else
                    msj = "HATA!";
                conn.Close();
            }
            return msj;
        }
    }
}

