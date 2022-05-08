using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SigmaSinavSistemi
{
    class Sonuclar : Sigma
    {
        public static int toplamSoru = 0;
        public static int dogru = 0;
        public static int yanlis = 0;
        public static int bos = 0;
        public static string sure = Sorumlu.Sure.ToString();
        public static string harcanan_sure;
        public string SinaviBitir(int[,] sonuc)
        {
            string msj = "not";
            string kmt = "not";
            toplamSoru = soruSayi + Dereceliler().Length;
            int s_id, s_cvp;
            for (int i = 1; i < toplamSoru + 1; i++)
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
                        dogru++;
                    }
                    else//YANLIŞ CEVAP
                    {
                        cmd = new SqlCommand("UPDATE Sigma SET Derece = 0, HatirlatmaTarih = GETDATE() WHERE SoruId = " + s_id + " ", conn);
                        yanlis++;
                    }
                    conn.Open();
                    check = cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                    bos++;
            }
            msj = "Sınav başarıyla sonlandırıldı.."; 
            return msj;
        }
    }
}
