using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SigmaSinavSistemi
{
    class KonuIstatistik : Database
    {
        SoruHavuzu sorular = new SoruHavuzu();
        public KonuIstatistik()
        {
            Baglan();
        }
        public int Konu_ID { get; set; }
        public int SoruSayisi { get; set; }
        public int Dereceli { get; set; }
        public int Dogru { get; set; }
        public int Yanlis { get; set; }
        public int KonuPuan { get; set; }
        public int AlinanPuan { get; set; }

        public List<KonuIstatistik> Istatistik()
        {
            SqlQuery s = new SqlQuery();
            s.Komutlar();

            List<KonuIstatistik> stats = new List<KonuIstatistik>();
            cmd = new SqlCommand("SELECT * FROM KonuIstatistik", conn);
            conn.Open();
            var oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                KonuIstatistik konu = new KonuIstatistik();
                konu.Konu_ID = int.Parse(oku[1].ToString());
                konu.SoruSayisi = int.Parse(oku[2].ToString());
                konu.Dereceli = int.Parse(oku[3].ToString());
                konu.Dogru = int.Parse(oku[4].ToString());
                konu.Yanlis = int.Parse(oku[5].ToString());
                konu.KonuPuan = int.Parse(oku[6].ToString());
                konu.AlinanPuan = int.Parse(oku[7].ToString());
                stats.Add(konu);
            }
            conn.Close();
            return stats;
        }
    }  

    class SqlQuery : KonuIstatistik
    {
        public void DB(string query)
        {
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Komutlar()
        {
            string SoruSayisi, Dereceli, Dogru, Yanlis, KonuPuan, AlinanPuan, BasariOran;

            SoruSayisi = "UPDATE KonuIstatistik SET SoruSayisi = (SELECT Count(*) FROM SoruHavuzu  WHERE SoruHavuzu.KonuId = KonuIstatistik.Konu_ID)";
            DB(SoruSayisi);

            Dereceli = "UPDATE KonuIstatistik SET Dereceli = (SELECT Count(*) FROM Sigma INNER JOIN SoruHavuzu ON SoruHavuzu.Id = Sigma.SoruId and SoruHavuzu.KonuId = KonuIstatistik.Konu_ID WHERE Derece > 0 and SoruHavuzu.KonuId = KonuIstatistik.Konu_ID)";
            DB(Dereceli);

            Dogru = "UPDATE KonuIstatistik SET Dogru = Dereceli, Yanlis = (SoruSayisi - Dogru), KonuPuan = (SoruSayisi * 6)";
            DB(Dogru);

            Yanlis = "UPDATE KonuIstatistik SET Yanlis = (SoruSayisi - Dogru)";
            DB(Yanlis);

            KonuPuan = "UPDATE KonuIstatistik SET KonuPuan = (SoruSayisi * 6)";
            DB(KonuPuan);

            AlinanPuan = "UPDATE KonuIstatistik SET AlinanPuan = (SELECT SUM(Derece) FROM Sigma INNER JOIN SoruHavuzu ON SoruHavuzu.Id = Sigma.SoruId AND SoruHavuzu.KonuId = KonuIstatistik.Konu_ID WHERE SoruHavuzu.KonuId = KonuIstatistik.Konu_ID)";
            DB(AlinanPuan);
        }
    }
}

