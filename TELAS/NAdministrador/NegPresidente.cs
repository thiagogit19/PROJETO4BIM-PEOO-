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
            p = new PerPresidente();
            List<ModPresidente> cs = p.Open();
            int id = 1;
            if (cs.Count > 0) id = cs.Max(c => c.Id) + 1;
            x.Id = id;
            cs.Add(x);
            p.Save(cs);
        }

        public List<ModPresidente> SelectPresidente()
        {
            p = new PerPresidente();
            return p.Open().OrderBy(ModPresidente => ModPresidente.Id).ToList();
        }

        public void UpdatePresidente(ModPresidente x)
        {
            p = new PerPresidente();
            List<ModPresidente> up = p.Open();

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

        public void DeletePresidente(ModPresidente x)
        {

            ModPresidente c = new ModPresidente();
            c.Id = int.Parse(idpretxt.Text);
            NegPresidente n = new NegPresidente();
            n.DeletePresidente(c);
            listagem.ItemsSource = null;
            listagem.ItemsSource = n.SelectPresidente();
        }
    }
}
