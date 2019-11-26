using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUsuario
{
    public class Usuario
    {
        private string Nome, Email, Fone, Foto;
        private int Id;
        private DateTime Nascimento;

        public Usuario(string n, string e, string f, string foto, int i, DateTime d)
        {
            Nome = n;
            Email = e;
            Fone = f;
            Foto = foto;
            Id = i;
            Nascimento = d;
        }

        public string GetNome()
        {
            return Nome;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetFone()
        {
            return Fone;
        }
        public DateTime GetNascimento()
        {
            return Nascimento;
        }
        public string GetFoto()
        {
            return Foto;
        }
        public int GetId()
        {
            return Id;
        }
    }
}
