using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SigmaSinavSistemi
{
    class Sonuclar : Sigma
    {
        public int Sinav_No { get; set; }
        public int Kul_ID { get; set; }
        public int ToplamSoru { get; set; }
        public int Dogru { get; set; }
        public int Bos { get; set; }
        public string Sure { get; set; }
        public string HarcananSure { get; set; }
        public DataTable SonucListele()
        {
            cmd = new SqlCommand("SELECT * FROM Sonuclar  WHERE Kul_ID = "+Giris.kulid+ " ORDER BY Sinav_No DESC", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string SinaviBitir(int[,] sonuc)
        {
            string msj = "not";
            string kmt = "not";
            ToplamSoru = soruSayi + Dereceliler().Length;
            int s_id, s_cvp;
            for (int i = 1; i < ToplamSoru + 1; i++)
            {
                s_id = sonuc[i, 1];
                s_cvp = sonuc[i, 2];
                var soru = Listele(0).Find(x => x.Id == s_id);
                int check = 0;
                if (s_cvp != 0)//CEVAP BOŞ İŞARETLİ DEĞİLSE
                {
                    if (soru.DogruCevap == s_cvp)//DOĞRU CEVAP
                    {
                        var sigma = SoruOzellik().Find(x => x.SoruId == s_id);
                        if(sigma.Derece != 6)
                        {
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
                            cmd = new SqlCommand("UPDATE Sigma SET Derece += 1, HatirlatmaTarih = " + kmt + " WHERE SoruId = " + s_id + " ", conn);
                        }
                        else
                        {
                            cmd = new SqlCommand("UPDATE Sigma SET Basari = 1 WHERE SoruId = "+ s_id +" ", conn);
                        }
                        Dogru++;
                    }
                    else//YANLIŞ CEVAP
                    {
                        cmd = new SqlCommand("UPDATE Sigma SET Derece = 0, HatirlatmaTarih = GETDATE() WHERE SoruId = " + s_id + " ", conn);
                    }
                    conn.Open();
                    check = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                    Bos++;
            }
            SonucIsle();
            msj = "Sınav başarıyla sonlandırıldı.."; 
            return msj;
        }
        public void SonucIsle()
        {
            int CozulenSoru = ToplamSoru - Bos;
            int SigmaSorulari = Dereceliler().Length;
            float BasariOrani = BasariOran(CozulenSoru, Dogru);
            Sure = string.Format("{0} dakika", 10);//BURAYA SORUMLUNUN BELİRLEDİĞİ SINAV SÜRESİ GELECEK!

            cmd = new SqlCommand("INSERT INTO Sonuclar (Kul_ID, ToplamSoru, Dogru, Bos, Sure, HarcananSure, BasariOrani) VALUES ('"+Giris.kulid+"', '"+ToplamSoru+"', '"+Dogru+ "', '" + Bos + "', '" + Sure +"', '"+HarcananSure+"', '"+BasariOrani+"')", conn);
            conn.Open();
                cmd.ExecuteNonQuery();
            conn.Close();
        }
        public float BasariOran(int cozulen, int dogru)
        {
            float basari;
            if (dogru != 0)
                basari = (dogru * 100) / cozulen;
            else
                basari = 0;
            return basari;
        }
    }
}
