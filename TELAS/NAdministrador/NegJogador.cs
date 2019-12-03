

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
            p = new PerJogador();
            v = p.Open();
            v.Add(x);
            p.Save(v);
        }

        public List<ModJogador> SelectJogador()
        {
            p = new PerJogador();
            return p.Open().OrderBy(ModJogador => ModJogador.Id).ToList(); // artilheiro
        }

        public void UpdateJogador(ModJogador x)
        {
            p = new PerJogador();
            List<ModJogador> up = p.Open();

            for (int i = 0; i < up.Count; i++)
            {
                if (up[i].Id == x.Id)
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
                if (del[i].Id == x.Id)
                {
                    del.RemoveAt(i);
                    break;
                }
            p.Save(del);
        }
    }
}
