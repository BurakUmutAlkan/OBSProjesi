using OBSProjesi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProjesi.Services
{
    class Yazi
    {
        public static bool YaziMi(string yazi)
        {
            yazi = yazi.ToUpper();

            for (int i = 0; i < yazi.Length; i++)
            {
                if (yazi[i] < 'A' || yazi[i] > 'Z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
