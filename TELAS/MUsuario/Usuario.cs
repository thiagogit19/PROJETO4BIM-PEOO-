﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUsuario
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public DateTime Nascimento { get; set; }
        public string Foto { get; set; }
        public string Senha { get; set; }
        public int Id { get; set; }
    }
}