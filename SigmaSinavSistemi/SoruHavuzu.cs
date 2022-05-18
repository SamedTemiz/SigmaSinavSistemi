using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace SigmaSinavSistemi
{
    public class SoruHavuzu : Database
    {
        public SoruHavuzu()
        {
            Baglan();
        }
        public int Id { get; set; }
        public int KonuId { get; set; }
        public string KonuAdi { get; set; }
        public string GorselAd { get; set; }
        public string Seviye { get; set; }
        public int DogruCevap { get; set; }
        public int Derece { get; set; }
        public bool Onay { get; set; }
        public int Basari { get; set; }
        public int[,] sinav_soru { get; set; }
        public int soruSayi;
        public List<SoruHavuzu> Listele(int konuID)
        {
            List<SoruHavuzu> havuz = new List<SoruHavuzu>();
            conn.Open();
            string kosul = "WHERE SoruHavuzu.KonuId='" + konuID + "'";
            if (konuID == 0)
            {
                kosul = "";
            }
            cmd = new SqlCommand("SELECT SoruHavuzu.Id, SoruHavuzu.KonuId, Konular.KonuAdi, SoruHavuzu.GorselAd, SoruHavuzu.Seviye, SoruHavuzu.DogruCevap, Sigma.Derece, SoruHavuzu.Onay, Sigma.Basari FROM SoruHavuzu INNER JOIN Konular ON SoruHavuzu.KonuId = Konular.KonuId INNER JOIN Sigma ON SoruHavuzu.Id = Sigma.SoruId " + kosul, conn);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                SoruHavuzu soru = new SoruHavuzu();
                soru.Id = int.Parse(oku[0].ToString());
                soru.KonuId = int.Parse(oku[1].ToString());
                soru.KonuAdi = oku[2].ToString();//Konular tablosundan
                soru.GorselAd = oku[3].ToString();
                soru.Seviye = oku[4].ToString();
                soru.DogruCevap = int.Parse(oku[5].ToString());
                soru.Derece = int.Parse(oku[6].ToString());//Sigma tablosundan
                soru.Onay = bool.Parse(oku[7].ToString());
                soru.Basari = int.Parse(oku[8].ToString());//Sigma tablosundan
                havuz.Add(soru);
            }
            conn.Close();
            return havuz;
        }
        private static Random rnd = new Random();
        //Rastgele 10 soru + var ise dereceli sorular
        public List<SoruHavuzu> SinavSorulari()
        {
            Sorumlu sorum = new Sorumlu();
            sorum.SinavAyar();
            soruSayi = Sorumlu.SoruAdet;
            List<SoruHavuzu> sinav = new List<SoruHavuzu>();
            SoruHavuzu soru = new SoruHavuzu();
            Sigma sigma = new Sigma();
            int[] dereceli_sorular = new int[sigma.Dereceliler().Length];
            if (sigma.Dereceliler().Length > 0)//Dereceli soru var ise
            {
                soruSayi += sigma.Dereceliler().Length;//soruSayi(10) + dereceli soru adedi yapıyoruz
                dereceli_sorular = sigma.Dereceliler();//dizi içeriğine erişmek için yeni diziye atıyoruz
            }
            sinav_soru = new int[soruSayi + 1, 3]; //matris oluşturuyoruz

            int miktar = Listele(0).FindAll(x => (x.Derece == 0) && (x.Basari == 0) && (x.Onay == true)).Count;//Derecesi 0 olanların miktarı
            int[] soruID = new int[miktar];//soru havuzundan soru id leri için dizi
            int a = 0;
            foreach (var x in Listele(0).FindAll(x => (x.Derece == 0) && (x.Onay == true)))
            {
                soruID[a] = x.Id;//Derecesi 0 olanların id si
                a++;
            }
            int i = 0, b = 1;
            while (b < soruSayi + 1)//istenilen soru sayısı kadar rastgele sınav hazırlanıyor
            {
                if (soruSayi >= Sorumlu.SoruAdet && b < Sorumlu.SoruAdet + 1)//soru sayısı 10 dan fazla ise dereceli var demektir
                {
                tekrar:
                    int rastgele = rnd.Next(0, soruID.Length);//id lerden rastgele belirliyoruz
                    soru = Listele(0).Find(x => x.Id == soruID[rastgele]);
                    var tekrar = sinav.Find(x => x.Id == soruID[rastgele]);//soru kontrolü yapıyoruz
                    if (tekrar == null)//aynı soru yoksa ekliyoruz
                    {
                        sinav.Add(soru);
                        sinav_soru[b, 1] = soru.Id;
                    }
                    else
                    {
                        goto tekrar;
                    }
                }
                else if (dereceli_sorular != null)
                {
                    soru = Listele(0).Find(x => x.Id == dereceli_sorular[i]);
                    sinav.Add(soru);
                    sinav_soru[b, 1] = dereceli_sorular[i];
                    i++;
                }
                b++;
            }
            return sinav;
        }

        //SORUMLU SAYFASI
        public string SoruEkle()
        {
            int kontrol = 0;
            string durum = "Hata";
            conn.Open();
            cmd = new SqlCommand("INSERT INTO SoruHavuzu(KonuID, GorselAd, Seviye, DogruCevap)" + "VALUES('" + KonuId + "','" + GorselAd + "','" + Seviye + "','" + DogruCevap + "')", conn);
            kontrol = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Sigma(SoruId) VALUES ((Select Id from SoruHavuzu WHERE Id = (SELECT MAX(Id) FROM SoruHavuzu)))", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return durum = "Ekleme işlemi başarılı!";
        }
        public bool Guncelle(int id, int konuid, string seviye, int dogru)
        {
            bool kontol = false;
            cmd = new SqlCommand("Update SoruHavuzu" + " Set KonuId='" + konuid + "',Seviye='" + seviye + "',DogruCevap='" + dogru + "' where Id='" + id + "'", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontol = true;
            }
            conn.Close();
            return kontol;
        }
        public bool Sil(int id)
        {
            bool kontrol = false;
            cmd = new SqlCommand("DELETE FROM SoruHavuzu WHERE Id = '" + id + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            cmd = new SqlCommand("DELETE FROM Sigma WHERE SoruId = '" + id + "' ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            kontrol = true;
            return kontrol;
        }
        public bool GuncelleOnay(int id, int konuid, string seviye, int dogru, int onay)
        {
            bool kontol = false;
            cmd = new SqlCommand("Update SoruHavuzu" + " Set KonuId='" + konuid + "',Seviye='" + seviye + "',DogruCevap='" + dogru + "',Onay='" + onay + "' where Id='" + id + "'", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontol = true;
            }
            conn.Close();
            return kontol;
        }
            List<SoruHavuzu> havuz = new List<SoruHavuzu>();
        public List<SoruHavuzu> SoruListele1()
        {
            
            conn.Open();
            cmd = new SqlCommand("SELECT SoruHavuzu.Id, SoruHavuzu.KonuId, Konular.KonuAdi, SoruHavuzu.GorselAd, SoruHavuzu.Seviye, SoruHavuzu.DogruCevap, SoruHavuzu.Onay From SoruHavuzu INNER JOIN Konular ON SoruHavuzu.KonuId = Konular.KonuId ORDER BY SoruHavuzu.Id ASC", conn);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                SoruHavuzu soru = new SoruHavuzu();
                soru.Id = int.Parse(oku[0].ToString());
                soru.KonuId = int.Parse(oku[1].ToString());
                soru.KonuAdi = oku[2].ToString();
                soru.GorselAd = oku[3].ToString();
                soru.Seviye = oku[4].ToString();
                soru.DogruCevap = int.Parse(oku[5].ToString());
                soru.Onay = bool.Parse(oku[6].ToString()); 
                havuz.Add(soru);
            }
            conn.Close();
            return havuz;
        }
        public int SoruAdet() 
        {
            int soruadet = 0;
            conn.Open();
            cmd = new SqlCommand("Select count(Id) From SoruHavuzu",conn);
            soruadet = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return soruadet;
        
        }
    }
}
