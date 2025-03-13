using OBSProjesi.Models;
using OBSProjesi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Services
{
    class OgrenciServis
    {
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

        public void OgrenciEkle()
        {
            Console.Clear();

            Ogrenci yeniOgrenci = new Ogrenci();

        ogrenciAd:
            Console.Write("Öğrencinin adını giriniz: ");
            yeniOgrenci.Ad = Console.ReadLine();
            if (!Yazi.YaziMi(yeniOgrenci.Ad))
            {
                Hata.HataMesajiGoster(2);
                goto ogrenciAd;
            }

        ogrenciSoyad:
            Console.Write("Öğrencinin soyadını giriniz: ");
            yeniOgrenci.Soyad = Console.ReadLine();
            if (!Yazi.YaziMi(yeniOgrenci.Soyad))
            {
                Hata.HataMesajiGoster(2);
                goto ogrenciSoyad;
            }

        ogrenciNumarasi:
            Console.Write("Öğrencinin numarasını giriniz: ");
            try
            {
                yeniOgrenci.OgrenciNo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Hata.HataMesajiGoster(0);
                goto ogrenciNumarasi;
            }

            ogrenciListesi.Add(yeniOgrenci);
            Console.Clear();
        }

        public List<Ogrenci> OgrenciListesi()
        {
            return ogrenciListesi;
        }
    }
}
