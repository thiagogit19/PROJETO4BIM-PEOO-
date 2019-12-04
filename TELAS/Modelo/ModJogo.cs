using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class ModJogo
    {
        public string Local { get; set; }
        public int IdEquipe1 { get; set; }
        public int IdEquipe2 { get; set; }
        public int IdPartida { get; set; }
        public int Gol1 { get; set; }
        public int Gol2 { get; set; }

        public override string ToString()
        {
            return $"{Local} - {IdEquipe1} - {Gol1} * {IdEquipe2} - {Gol2} -- {IdPartida}";
        }
    }
}
