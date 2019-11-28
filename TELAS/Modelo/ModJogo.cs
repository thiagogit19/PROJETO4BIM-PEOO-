using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class ModJogo
    {
        private int IdEquipe1, IdEquipe2,IdTorneio;
        private int Gol1, Gol2;
        private string Local;

        public ModJogo(int ide1, int ide2, int ID, int gol1, int gol2, string local)
        {
            IdEquipe1 = ide1;
            IdEquipe2 = ide2;
            Gol1 = gol1;
            Gol2 = gol2;
            IdTorneio = ID;
            Local = local;
        }

        public int GetGolsTotal()
        {
            return Gol1 + Gol2;
        }

        public override string ToString()
        {
            return $"{IdEquipe1} -- {IdEquipe2} -- {Gol1} -- {Gol2} -- {Local}";
        }

    }

}
