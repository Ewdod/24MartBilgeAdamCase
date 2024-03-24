using Bordro.Entities;
using Bordro.Extensions;

namespace ProgramCalistir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personel> personelListesi = DosyaOku.PersoneliJsonDosyasindanOku("personel.json");

            MaasBordro bordro = new MaasBordro(personelListesi);

            bordro.BordroyuEkranaYazdır();

            bordro.BordroyuDosyayaKaydet("bordro.csv");
        }
    }
}
