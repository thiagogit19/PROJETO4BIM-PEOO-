using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAdministrador
{
    public class NegJogador
    {
        private List<Jogador> v = new List<Jogador>();
        private PJogador p;

        public void InsertJogador(Jogador x)
        {
            v.Add(x);
        }

        public List<Jogador> SelectJogador()
        {
            p = new PJogador();
            return p.Open().v.ToList();
        }

        public void UpdateJogador(Jogador x)
        {
            p = new PJogador();
            List<PJogador> up = p.Open();

            for (int i = 0; i < up.Count; i++)
            {
                if (up[i].GetID() == x.GetID())
                {
                    up.RemoveAt(i); break;
                }
            }
            up.Add(x);
            p.Save(up);
        }

        public void DeleteJogador(Jogador x)
        {
            p = new PJogador();
            List<Jogador> del = p.Open();
            for (int i = 0; i < del.Count; i++)
                if (del[i].GetID() == x.GetID())
                {
                    del.RemoveAt(i);
                    break;
                }
            p.Save(del);
        }
    }
}
