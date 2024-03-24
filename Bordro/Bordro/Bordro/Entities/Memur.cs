using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordro.Entities
{
    public class Memur : Personel
    {
        private const double SaatlikUcretVarsayilan = 500.0;
        private double MaasKatsayisi { get; set; }

        public Memur(string ad, string soyad, int calismaSaati, double maasKatsayisi)
        {
            Ad = ad;
            Soyad = soyad;
            Unvan = "Memur";
            CalismaSaati = calismaSaati;
            MaasKatsayisi = maasKatsayisi;
        }

        public override double MaasHesapla()
        {
            double normalMaas = SaatlikUcretVarsayilan * MaasKatsayisi * Math.Min(CalismaSaati, 180);
            double ekMesaiMaasi = 0;

            if (CalismaSaati > 180)
            {
                ekMesaiMaasi = (CalismaSaati - 180) * SaatlikUcretVarsayilan * MaasKatsayisi * 1.5;
            }

            return normalMaas + ekMesaiMaasi;
        }
    }
}
