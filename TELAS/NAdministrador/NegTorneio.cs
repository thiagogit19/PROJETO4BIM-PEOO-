using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistência;

namespace NAdministrador
{
    public class NegTorneio
    {
        private List<ModTorneio> v = new List<ModTorneio>();
        private PerTorneio p;

        public void InsertTorneio(ModTorneio x)
        {
            v.Add(x);
        }

        public void UpdateTorneio(ModTorneio x)
        {
            p = new PerTorneio();
            List<ModTorneio> up = p.Open();

            for (int i = 0; i < up.Count; i++)
            {
                if (up[i].GetPais() == x.GetPais())
                {
                    up.RemoveAt(i); break;
                }
            }

            up.Add(x);
            p.Save(up);
        }
    }
}
