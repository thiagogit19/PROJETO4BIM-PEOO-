using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModEquipe 
    {
        private string Nome, Origem;
        private int NumJogadores, Id, IdPresidente, IdTorneio;
        private DateTime fundacao;

        public ModEquipe(string n,string o,int num,int idc,int idp,int idt,DateTime f)
        {
            Nome = n;
            Origem = o;
            NumJogadores = num;
            Id = idc;
            IdPresidente = idp;
            IdTorneio = idt;
            fundacao = f;
        }

        public int GetID()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"{Nome} -- {Origem} -- {NumJogadores} -- {Id} -- {IdPresidente} -- {IdTorneio} -- {fundacao}";
        }
    }
}
