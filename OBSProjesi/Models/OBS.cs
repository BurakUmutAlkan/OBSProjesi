using OBSProjesi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Models
{
    class OBS
    {
        DersServis dersServisi = new DersServis();
        OgrenciServis ogrenciServisi = new OgrenciServis();

        public void SecimIslemiYap(int secim)
        {
            switch (secim)
            {
                case 1:
                    ogrenciServisi.OgrenciEkle();
                    break;
                case 2:
                    dersServisi.DersEkle();
                    break;
                case 3:
                    OgrencileriListele();
                    break;
                case 4:
                    DersleriListele();
                    break;
            }
        }

        public void DersleriListele()
        {
            Console.Clear();

            foreach (Ders ders in dersServisi.DersListesi()) 
            { 
                // Derslerin içerikleri listelenecek.
            }

            Console.ReadKey();
            Console.Clear();
        }

        public void OgrencileriListele()
        {
            Console.Clear();

            foreach (Ogrenci ogrenci in ogrenciServisi.OgrenciListesi())
            {
                Console.WriteLine("Öğrenci Adı: " + ogrenci.Ad);
                Console.WriteLine("Öğrenci Soyadı: " + ogrenci.Soyad);
                Console.WriteLine("Öğrenci Numarası: " + ogrenci.OgrenciNo);
                Console.WriteLine("----------------------------------------------");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
