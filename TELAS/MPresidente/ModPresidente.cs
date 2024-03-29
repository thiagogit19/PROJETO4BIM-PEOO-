﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MUsuario;

namespace MPresidente
{
    public class ModPresidente : Usuario
    {
        public ModPresidente(string Nome, string Email, string Fone, string Foto, int Id, DateTime Nascimento) : base(Nome, Email, Fone, Foto, Id, Nascimento)
        { 

        }

        public override string ToString()
        {
            return $"{base.GetNome()} -- {base.GetEmail()} -- {base.GetFone()} -- {base.GetFoto()} -- {base.GetId()} -- {base.GetNascimento()}";
        }
    }
}
