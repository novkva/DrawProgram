using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawProgram.Figures
{
    interface IFigure
    {
        Point[] GetPoints(Point[] points);
    }
}
