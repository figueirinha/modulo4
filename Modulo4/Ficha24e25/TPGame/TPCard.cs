using Recodme.Formacao.Exercicios.Ficha24e25.EnumColors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Exercicios.Ficha24e25.TPCard
{
    public struct TPCard
    {
        public Colors Color { get; }
        public string Question { get; }
        public string Answer { get; }

        public TPCard(Colors color, string question, string answer)
        {
            Color = color;
            Question = question;
            Answer = answer;
        }
    }
}
