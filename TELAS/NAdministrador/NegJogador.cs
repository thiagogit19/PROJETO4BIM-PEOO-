using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistência;

namespace NAdministrador
{
    public class NegJogador
    {
        private List<ModJogador> v = new List<ModJogador>();
        private PerJogador p;

        public void InsertJogador(ModJogador x)
        {
            v.Add(x);
        }

        public List<ModJogador> SelectJogador()
        {
            p = new PerJogador();
            return p.Open().OrderBy(ModJogador => ModJogador.QuantidadeGols()).ToList(); // artilheiro
        }

        public void UpdateJogador(ModJogador x)
        {
            p = new PerJogador();
            List<ModJogador> up = p.Open();

            for (int i = 0; i < up.Count; i++)
            {
                if (up[i].GetId() == x.GetId())
                {
                    up.RemoveAt(i); break;
                }
            }
            up.Add(x);
            p.Save(up);
        }

        public void DeleteJogador(ModJogador x)
        {
            p = new PerJogador();
            List<ModJogador> del = p.Open();
            for (int i = 0; i < del.Count; i++)
                if (del[i].GetId() == x.GetId())
                {
                    del.RemoveAt(i);
                    break;
                }
            p.Save(del);
        }
    }
}
