using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModPresidente : ModUsuario
    {
        public override string ToString()
        {
            return $"{Nome} {Email} {Fone} {Nascimento} {Id}";
        }
    }
}
