using OBSProjesi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Utilities
{
    class Giris
    {
        public static string StringGirdisiAl(string secim)
        {
            switch (secim)
            {
                case "ad":
                    Console.Write("Öğrencinin adını giriniz: ");
                    break;
                case "soyad":
                    Console.Write("Öğrencinin soyadını giriniz: ");
                    break;
            }

            string str = Console.ReadLine();

            if (!Yazi.YaziMi(str))
            {
                Hata.HataMesajiGoster(2);
                str = StringGirdisiAl(secim);
            }

            return str;
        }

        public static int IntGirdisiAl()
        {
            int sayi = 0;

            Console.Write("Öğrencinin numarasını giriniz: ");

            try
            {
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Hata.HataMesajiGoster(0);
                sayi = IntGirdisiAl();
            }

            return sayi;
        }
    }
}
