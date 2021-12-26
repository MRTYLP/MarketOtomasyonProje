using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Form
{
   public abstract class ODEME
    {
        private string adsoyad, adres;
        private int tarih, tutar;

        abstract public void bilgiler();
    }
}
