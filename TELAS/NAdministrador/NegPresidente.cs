using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAdministrador
{
    public class NegPresidente
    {
        private List<Presidente> v = new List<Presidente>();
        private PPresidente p;

        public void InsertPresidente(Presidente x)
        {
            v.Add(x);
        }

        public List<Presidente> SelectPresidente()
        {
            p = new PPresidente();
            return p.Open().v.ToList();
        }

        public void UpdatePresidente(Presidente x)
        {
            p = new PPresidente();
            List<Presidente> up = p.Open();

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

        public void DeletePresidente(Presidente x)
        {
            p = new PPresidente();
            List<Presidente> del = p.Open();
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
