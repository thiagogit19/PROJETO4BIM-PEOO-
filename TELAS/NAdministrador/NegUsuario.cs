using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistência;

namespace NAdministrador
{
    public class NegUsuario
    {
        private List<ModUsuario> v = new List<ModUsuario>();
        private PerUsuario p;

        public void InsertUsuario(ModUsuario x)
        {
            p = new PerUsuario();
            List<ModUsuario> cs = p.Open();
            //int id = 1;
            //if (cs.Count > 0) id = cs.Max(c => c.Id) + 1;
            //x.IdPartida = id;
            cs.Add(x);
            p.Save(cs);
        }

        public List<ModUsuario> SelectUsuario()
        {
            p = new PerUsuario();
            return p.Open().ToList();
        }

        public ModUsuario VerificarSenha(string usuario, string senha)
        {
            p = new PerUsuario();
            v = p.Open();
            ModUsuario r = null;

            for (int i = 0; i < v.Count; i++)
            {
                if (usuario == v[i].Email && senha == v[i].Senha)
                {
                    r = v[i];
                    break;
                }
            }
            return r;
        }
    }
}
