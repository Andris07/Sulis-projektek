using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViragBolt_Lambda_PL
{
    internal record Virag(string Nev, int Ar)
    {
        public int KedvezmenyesAr => (int)Math.Round(Ar * 0.9, 0);

        public int Keszlet {  get; set; }

        public override string ToString()
        {
            return $"{Nev} ({Ar} Ft)";
        }
    }
}
