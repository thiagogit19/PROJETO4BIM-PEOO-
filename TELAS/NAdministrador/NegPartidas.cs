using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAdministrador
{
    public class NegPartidas
    {
        private List<Partida> v = new List<Partida>();
        private PPartida p;

        public void InsertPartida(Partida x)
        {
            v.Add(x);
        }

        public List<Partida> SelectPartida()
        {
            p = new PPartida();
            return p.Open().v.ToList();
        }

        public void UpdatePartida(Partida x)
        {
            p = new PPartida();
            List<Partida> up = p.Open();

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

        public void DeletePartida(Partida x)
        {
            p = new PPartida();
            List<Partida> del = p.Open();
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
