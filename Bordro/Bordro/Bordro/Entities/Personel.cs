using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordro.Entities
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public int CalismaSaati { get; set; }

        public abstract double MaasHesapla();

        public override string ToString()
        {
            return $"{Ad} {Soyad} - {Unvan} - {CalismaSaati} saat - {MaasHesapla():C2} TL";
        }
    }
}
