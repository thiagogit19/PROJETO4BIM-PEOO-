using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAdministrador
{
    public class NegEquipe
    {
        private List<Equipe> v = new List<Equipe>();
        private PEquipe p;

        public void InsertEquipe(Equipe x)
        {
            v.Add(x);
        }

        public List<Equipe> SelectEquipe()
        {
            p = new PEquipe();
            return p.Open().v.ToList();
        }

        public void UpdateEquipe(Equipe x)
        {
            p = new PEquipe();
            List<Equipe> up = p.Open();

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

        public void DeleteEquipe(Equipe x)
        {
            p = new PEquipe();
            List<Equipe> del = p.Open();
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
