using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Exercicios.Ficha24e25.CoordXY
{
    public struct PositionInMap
    {
        public int PosX { get; }
        public int PosY { get; }
        public object Value { get; }

        public PositionInMap(int posX, int posY, object value)
        {
            PosX = posX;
            PosY = posY;
            Value = value;
        }
    }
}
