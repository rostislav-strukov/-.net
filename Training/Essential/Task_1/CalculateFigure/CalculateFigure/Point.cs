using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigure
{
    class Point
    {
        private int _iSide1 = 20;
        private int _iSide2 = 10;
        private string _sName = "Perimetr Figure: ";

        public int Side1 { get { return _iSide1; } set { _iSide1 = value; } }
        public int Side2 { get { return _iSide2; } set { _iSide2 = value; } }
        public string FigureName { get { return _sName; } set { _sName = value; } }
        public Point() { }
        public Point(int ArgSide1, int ArgSide2, string ArgFigureName)
        {
            Side1 = ArgSide1;
            Side2 = ArgSide2;
            FigureName = ArgFigureName;
        }
    }
}
