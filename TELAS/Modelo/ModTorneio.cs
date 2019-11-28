using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModTorneio
    {
        private int IdAdm, NUmEquipes;
        private string Pais, Temporada;

        public ModTorneio(int ida,int nume,string p,string t)
        {
            IdAdm = ida;
            NUmEquipes = nume;
            Pais = p;
            Temporada = t;
        }

        public string GetPais()
        {
            return Pais;
        }

        public override string ToString()
        {
            return $"{IdAdm} -- {NUmEquipes} -- {Pais} -- {Temporada}";
        }
    }
}
