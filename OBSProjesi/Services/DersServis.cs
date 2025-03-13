using OBSProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Services
{
    class DersServis
    {
        List<Ders> dersListesi = new List<Ders>();

        public void DersEkle()
        {
            Console.Clear();

            Ders yeniDers = new Ders();

            // Dersin içeriklerini alma işlemleri buraya yazılacak.

            Console.Clear();
        }

        public List<Ders> DersListesi()
        {
            return dersListesi;
        }
    }
}
