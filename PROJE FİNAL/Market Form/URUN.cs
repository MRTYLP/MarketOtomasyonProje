using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Form
{
    public class URUN
    {
        public string Ad { get; set; }

        public double ToplamAgırlık { get; set; }

        public double Agırlık { get; set; }

        public int Adet { get; set; }

        public float ToplamAgırlıkHesapla()
        {
            ToplamAgırlık = Agırlık * Adet;
            return Convert.ToInt32(ToplamAgırlık);
        }
        public int x = 1;
        public virtual int Kdv()
        {
            return x;
        }
    }

}