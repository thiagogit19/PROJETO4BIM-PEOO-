using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModAdm : ModUsuario
    {
        public ModAdm(string Nome, string Email, string Fone, string Foto, int Id, DateTime Nascimento) : base(Nome, Email, Fone, Foto, Id, Nascimento)
        {
          
        }

        public override int GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"{base.GetNome()} -- {base.GetEmail()} -- {base.GetFone()} -- {base.GetFoto()} -- {base.GetId()} -- {base.GetNascimento()}";
        }
    }
}
