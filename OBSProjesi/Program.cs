using OBSProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OBS obs = new OBS();
            Menu menu = new Menu();

            int secim = 0;
            bool hataVerdi;

            while (secim != 9)
            {
                menu.MenuyuGoster();
                secim = menu.SecimiAl(out hataVerdi);

                if (secim >= 1 && secim <= 4)
                {
                    obs.SecimIslemiYap(secim);
                }
                else if ((secim <= 0 || (secim > 4 && secim != 9)) && !hataVerdi)
                {
                    menu.HataMesajiGoster(1);
                }
            }

            menu.ProgramiKapat();
        }
    }
}
