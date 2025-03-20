using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Models
{
    abstract class Kullanici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int YasHesapla()
        {
            return Convert.ToInt32(DateTime.Now.Year - DogumTarihi.Year);
        }

        public string TamIsimDondur()
        {
            return Ad + " " + Soyad;
        }
    }
}
