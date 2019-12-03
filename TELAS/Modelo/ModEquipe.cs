using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModEquipe 
    {
        public string Origem { get; set; }
        public string Nome { get; set; }
        public int NumJogador { get; set; }
        public int Id { get; set; }
        public int IdPresidente { get; set; }
        public int IdTorneio { get; set; }
        public DateTime Fundacao { get; set; }
    }
}
