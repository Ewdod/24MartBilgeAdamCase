using Bordro.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordro.Extensions
{
    public static class DosyaOku
    {
        public static List<Personel> PersoneliJsonDosyasindanOku(string dosyaYolu)
        {
            List<Personel> personelListesi = new List<Personel>();

            using (StreamReader reader = new StreamReader(dosyaYolu))
            {
                string json = reader.ReadToEnd();
                dynamic jsonData = JsonConvert.DeserializeObject(json);

                foreach (dynamic personel in jsonData)
                {
                    string ad = personel.name;
                    string soyad = ""; 
                    string unvan = personel.title;
                    int calismaSaati = 0; 

                    if (unvan == "Yonetici")
                    {
                        double bonus = 0; 
                        personelListesi.Add(new Yonetici(ad, soyad, calismaSaati, bonus));
                    }
                    else if (unvan == "Memur")
                    {
                        double maasKatsayisi = 1.0; 
                        personelListesi.Add(new Memur(ad, soyad, calismaSaati, maasKatsayisi));
                    }
                }
            }

            return personelListesi;
        }
    }
}
