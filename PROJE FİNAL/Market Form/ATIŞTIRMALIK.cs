using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Form
{
    public class ATIŞTIRMALIK:SİPARİŞ_DETAY
    {
        public override int Kdv()
        {
            return x * 5;
        }
    }
}
