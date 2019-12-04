using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModAdm : ModUsuario
    {
       public new string Nome { get => "Victor Albert Xavier"; }
       public new string Email { get => "mavmtx@emiail.com"; }
       public new string Fone { get => "86321435"; }
       public new DateTime Nascimento { get => DateTime.Parse("16/11/2002"); }
       public new string Senha { get => "12345"; }
    }
}
