using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUsuario;

namespace MJogador
{
    public class ModJogador : Usuario
    {
        public string Apelido { get; set; }
        public int NumCamisa { get; set; }
        public int QuantGols { get; set; }
        public int QuantAssit { get; set; }
        public int IdEquipe { get; set; }
        public string Posicao { get; set; }
    }
}
