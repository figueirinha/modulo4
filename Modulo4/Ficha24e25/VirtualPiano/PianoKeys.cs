using Recodme.Formacao.Exercicios.Ficha24e25.EnumsKeyColor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Exercicios.Ficha24e25.Piano
{
    public struct PianoKeys
    {
        public KeyColor Color { get; }
        public char Position { get; }
        public string Note { get; }

        public PianoKeys(KeyColor color, char position, string note)
        {
            Color = color;
            Position = position;
            Note = note;
        }
    }
}
