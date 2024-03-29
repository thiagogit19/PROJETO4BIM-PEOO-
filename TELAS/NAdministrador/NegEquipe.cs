﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistência;

namespace NAdministrador
{
    public class NegEquipe
    {
        private List<ModEquipe> v = new List<ModEquipe>();
        private PerEquipe p;

        public void InsertEquipe(ModEquipe x)
        {
            p = new PerEquipe();
            List<ModEquipe> cs = p.Open();
            int id = 1;
            if (cs.Count > 0) id = cs.Max(c => c.Id) + 1;
            x.Id = id;
            cs.Add(x);
            p.Save(cs);
        }

        public int RetMax()
        {
            return v.Count;
        }

        public List<ModEquipe> SelectEquipe()
        {
            p = new PerEquipe();
            return p.Open().OrderBy(ModEquipe => ModEquipe.Id).ToList();
        }

        public void UpdateEquipe(ModEquipe x)
        {
            p = new PerEquipe();
            List<ModEquipe> up = p.Open();

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

        public void DeleteEquipe(ModEquipe x)
        {
            p = new PerEquipe();
            List<ModEquipe> del = p.Open();
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
