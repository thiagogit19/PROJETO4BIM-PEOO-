using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistência;


namespace NAdministrador
{
    public class NegPresidente
    {
        private List<ModPresidente> v = new List<ModPresidente>();
        private PerPresidente p;

        public void InsertPresidente(ModPresidente x)
        {
            v.Add(x);
        }

        public List<ModPresidente> SelectPresidente()
        {
            p = new PerPresidente();
            return p.Open().OrderBy(ModPresidente => ModPresidente.GetID()).ToList();
        }

        public void UpdatePresidente(ModPresidente x)
        {
            p = new PerPresidente();
            List<ModPresidente> up = p.Open();

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

        public void DeletePresidente(ModPresidente x)
        {
            p = new PerPresidente();
            List<ModPresidente> del = p.Open();
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
