using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Utilities
{
    class Hata
    {
        public static void HataMesajiGoster(int hataKodu)
        {
            switch (hataKodu)
            {
                case 0: // Sayı yerine uygun olmayan girme hatası
                    Console.Clear();
                    Console.WriteLine("Sayı yerine uygun olmayan bir giriş yaptınız. Lütfen tekrar deneyiniz.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 1: // Olmayan seçeneği seçme hatası
                    Console.Clear();
                    Console.WriteLine("Var olmayan bir seçeneği seçtiniz. Lütfen tekrar deneyiniz.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2: // Ad veya soyadın rakam içerme hatası
                    Console.Clear();
                    Console.WriteLine("Ad veya soyad rakam içeremez. Lütfen tekrar deneyiniz.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}
