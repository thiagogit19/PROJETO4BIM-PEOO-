using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelo
{
    [XmlInclude(typeof(ModAdm))]
    [XmlInclude(typeof(ModJogador))]
    [XmlInclude(typeof(ModPresidente))]
    public class ModUsuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public string Foto { get; set; }
        public int Id { get; set; }
        public DateTime Nascimento { get; set; }
        public string Senha { get; set; }
    }
}
