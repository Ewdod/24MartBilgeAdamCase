using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordro.Entities
{
    public class Yonetici : Personel
    {
        private const double SaatlikUcretMin = 500.0;
        private double Bonus { get; set; }

        public Yonetici(string ad, string soyad, int calismaSaati, double bonus)
        {
            Ad = ad;
            Soyad = soyad;
            Unvan = "Yönetici";
            CalismaSaati = calismaSaati;
            Bonus = bonus;
        }

        public override double MaasHesapla()
        {
            return SaatlikUcretMin * CalismaSaati + Bonus;
        }
    }
}
