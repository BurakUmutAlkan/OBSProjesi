using OBSProjesi.Utilities;
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
                Hata.HataMesajiGoster(0);
                hataVerdi = true;
            }

            return secim;
        }
    }
}
