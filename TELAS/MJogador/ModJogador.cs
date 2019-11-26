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
        private string Apelido, Posicao;
        private int NumCamisa, QuantGols, IdEquipe;

        public ModJogador(string Nome, string Email, string Fone, string Foto, int Id, DateTime Nascimento, string ap, string p, int NumC, int Qg, int id) : base(Nome, Email, Fone, Foto, Id, Nascimento)
        {
            Apelido = ap;
            Posicao = p;
            NumCamisa = NumC;
            QuantGols = Qg;
            IdEquipe = id;
        }

        public override string ToString()
        {
            return $"{base.GetNome()} -- {base.GetEmail()} -- {base.GetFone()} -- {base.GetFoto()} -- {base.GetId()} -- {base.GetNascimento()} -- {Apelido} -- {Posicao} -- {NumCamisa} -- {QuantGols} -- {IdEquipe}";
        }
    }
}
