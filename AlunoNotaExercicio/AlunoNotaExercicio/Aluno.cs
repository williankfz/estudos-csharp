﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoNotaExercicio
{
    internal class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double TotalNota()
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if(TotalNota() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - TotalNota(); 
            }
        }
    }
}
