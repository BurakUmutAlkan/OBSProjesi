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

            yeniOgrenci.Ad = Giris.StringGirdisiAl("ad");

            yeniOgrenci.Soyad = Giris.StringGirdisiAl("soyad");

            yeniOgrenci.OgrenciNo = Giris.IntGirdisiAl();

            ogrenciListesi.Add(yeniOgrenci);
            Console.Clear();
        }

        public List<Ogrenci> OgrenciListesi()
        {
            return ogrenciListesi;
        }
    }
}
