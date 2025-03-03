using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Models
{
    internal class Menu
    {
        public void MenuyuGoster()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Öğrenci Ekle");
            Console.WriteLine("2. Ders Ekle");
            Console.WriteLine("3. Öğrencileri Listele");
            Console.WriteLine("4. Dersleri Listele");
            Console.WriteLine("9. Programı Sonlandır\n");
            Console.Write("Seçim: ");
        }

        public void ProgramiKapat()
        {
            Console.Clear();
            Console.WriteLine("İyi günler...");
            Console.ReadKey();
        }

        public int SecimiAl(out bool hataVerdi)
        {
            hataVerdi = false;
            int secim = 0;

            try
            {
                secim = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                HataMesajiGoster(0);
                hataVerdi = true;
            }

            return secim;
        }

        public void HataMesajiGoster(int hataKodu)
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
