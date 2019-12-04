using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistência;

namespace NAdministrador
{
    public class NegPartidas
    {
        private List<ModJogo> v = new List<ModJogo>();
        private PerJogo p;

        public void InsertPartida(ModJogo x)
        {
            p = new PerJogo();
            List<ModJogo> cs = p.Open();
            int id = 1;
            if (cs.Count > 0) id = cs.Max(c => c.IdPartida) + 1;
            x.IdPartida = id;
            cs.Add(x);
            p.Save(cs);
        }

        public List<ModJogo> SelectPartida()
        {
            p = new PerJogo();
            return p.Open().OrderBy(ModJogo => ModJogo.IdPartida).ToList();
        }

        public void UpdatePartida(ModJogo x)
        {
            p = new PerJogo();
            List<ModJogo> up = p.Open();

            for (int i = 0; i < up.Count; i++)
            {
                if (up[i].IdPartida == x.IdPartida)
                {
                    up.RemoveAt(i); break;
                }
            }

            up.Add(x);
            p.Save(up);
        }

        public void DeletePartida(ModJogo x)
        {
            p = new PerJogo();
            List<ModJogo> del = p.Open();
            for (int i = 0; i < del.Count; i++)
                if (del[i].IdPartida == x.IdPartida)
                {
                    del.RemoveAt(i);
                    break;
                }
            p.Save(del);
        }
    }
}
