using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Form
{
    public class SİPARİŞ_DETAY:URUN
    {
        
        
        public double Fiyat { get; set; }              
        public double KDVsizFiyat { get; set; }
        public double KDVliBirimFiyat { get; set; }

        public double ToplamFiyat { get; set; }

       
        public float ToplamFiyatHesapla()
        {
            ToplamFiyat = (Fiyat + (Fiyat * (Kdv() / 100))) * Adet;
            return Convert.ToInt32(ToplamFiyat);
        }
        public float KdvsizFiyatHesapla()
        {
            KDVsizFiyat = Fiyat - ((Kdv() * Fiyat) / 100);
            return Convert.ToInt32(KDVsizFiyat);
        }

       
    }
}
