using Bordro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordro.Extensions
{
    public class MaasBordro
    {
        private List<Personel> _personelListesi;
        public MaasBordro(List<Personel> personelListesi)
        {
            _personelListesi = personelListesi;
        }

        public void BordroyuEkranaYazdır()
        {
            Console.WriteLine("Adı Soyadı\t\tÜnvanı\t\tÇalışma Saati\t\tMaaş (TL)");
            Console.WriteLine("------------------------------------------------------------------");
            foreach (Personel personel in _personelListesi)
            {
                Console.WriteLine(personel);
            }
        }

        public void BordroyuDosyayaKaydet(string dosyaYolu)
        {
            using (StreamWriter writer = new StreamWriter(dosyaYolu))
            {
                writer.WriteLine("Adı Soyadı,Ünvanı,Çalışma Saati,Maaş (TL)");
                foreach (Personel personel in _personelListesi)
                {
                    writer.WriteLine($"{personel.Ad} {personel.Soyad},{personel.Unvan},{personel.CalismaSaati},{personel.MaasHesapla():C2}");
                }
            }
        }
    }
}
