using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAdministrador
{
    public class NegTorneio
    {
        private List<Torneio> v = new List<Torneio>();
        private PTorneio p;

        public void InsertTorneio(Torneio x)
        {
            v.Add(x);
        }

        public void UpdateTorneio(Torneio x)
        {
            p = new PTorneio();
            List<Torneio> up = p.Open();

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

        public void DeleteTorneio(Torneio x)
        {
            p = new PTorneio();
            List<Torneio> del = p.Open();
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
