﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Models
{
    internal class OBS
    {
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        List<Ders> dersListesi = new List<Ders>();

        public OBS() 
        {

        }

        public void SecimIslemiYap(int secim)
        {
            switch (secim)
            {
                case 1:
                    OgrenciEkle();
                    break;
                case 2:
                    DersEkle();
                    break;
                case 3:
                    OgrencileriListele();
                    break;
                case 4:
                    DersleriListele();
                    break;
            }
        }

        public void DersEkle()
        {
            Console.Clear();

            Menu menu = new Menu();
            Ders yeniDers = new Ders();

            // Dersin içeriklerini alma işlemleri buraya yazılacak.

            Console.Clear();
        }

        public void DersleriListele()
        {
            Console.Clear();

            foreach (Ders ders in dersListesi) 
            { 
                // Derslerin içerikleri listelenecek.
            }

            Console.ReadKey();
            Console.Clear();
        }

        public void OgrenciEkle()
        {
            Console.Clear();

            Menu menu = new Menu();
            Ogrenci yeniOgrenci = new Ogrenci();

            Console.Write("Öğrencinin adını giriniz: ");
            yeniOgrenci.Ad = Console.ReadLine();

            Console.Write("Öğrencinin soyadını giriniz: ");
            yeniOgrenci.Soyad = Console.ReadLine();

            ogrenciNumarasi:
            Console.Write("Öğrencinin numarasını giriniz: ");
            try
            {
                yeniOgrenci.OgrenciNo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                menu.HataMesajiGoster(0);
                goto ogrenciNumarasi;
            }

            ogrenciListesi.Add(yeniOgrenci);
            Console.Clear();
        }

        public void OgrencileriListele()
        {
            Console.Clear();

            foreach (Ogrenci ogrenci in ogrenciListesi)
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
