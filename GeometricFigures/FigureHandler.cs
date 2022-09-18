using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class FigureHandler
    {
        private IFigure _figure;
        public double Square
        {
            get
            {
                return _figure.FindSquare();
            }
        }
        public FigureHandler(IFigure figure)
        {
            _figure = figure;
        }
    }
}
