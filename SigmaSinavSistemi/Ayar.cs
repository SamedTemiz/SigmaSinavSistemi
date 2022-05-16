using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SigmaSinavSistemi
{
    public class Ayar : Database
    {
        public Ayar()
        {
            Baglan();
        }
        DateTime HatirlatmaTar, GuncelTar;
        int derece;
        public bool SinavDuzey(int secim)
        {
            conn.Open();
            Sigma sigma = new Sigma();
          
            foreach (var x in sigma.SoruOzellik())
            {
                if (x.GuncelTarih < x.HatirlatmaTarihi)
                {
                    if (secim == 1)
                    {
                        switch (x.Derece)
                        {
                            case 2:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, 3, HatirlatmaTarih) WHERE SoruId = '"+x.SoruId+"' ", conn);
                                break;
                            case 3:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, 10, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                            case 4:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, 30, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                            case 5:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, 60, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                        }

                    }
                    else if (secim == 2)
                    {
                        switch (derece)
                        {
                            case 2:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, -1, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                            case 3:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, -5, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                            case 4:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, -30, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                            case 5:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, -40, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                        }
                    }
                    else if (secim == 3)
                    {
                        switch (derece)
                        {
                            case 2:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, -3, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                            case 3:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, -15, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                            case 4:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, -45, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                            case 5:
                                cmd = new SqlCommand("UPDATE Sigma SET HatirlatmaTarih=DATEADD(day, -80, HatirlatmaTarih) WHERE SoruId = '" + x.SoruId + "' ", conn);
                                break;
                        }
                    }
                }
            }
            cmd.ExecuteNonQuery();
            conn.Close();
            
            return false;
        }
    }
}
