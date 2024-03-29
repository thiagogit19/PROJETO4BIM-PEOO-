﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModEquipe 
    {
        public string Origem { get; set; }
        public string Nome { get; set; }
        public int NumJogador { get; set; }
        public int Id { get; set; }
        public int IdPresidente { get; set; }
        public DateTime Fundacao { get; set; }
        private int Gol = 0;

        public void SetGol(int x)
        {
            Gol += x;
        }

        public int GetGoal()
        {
            return Gol;
        }

        public override string ToString()
        {
            return $"{Nome} {Origem} {Fundacao} {Id} {Gol}";
        }
    }
}
