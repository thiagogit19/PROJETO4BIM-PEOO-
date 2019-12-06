using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModJogador : ModUsuario
    {
        //public string Apelido { get; set; }
        public string Posicao { get; set; }
        public int NumCamisa { get; set; }
        public int IdEquipe { get; set; }
    }
}
