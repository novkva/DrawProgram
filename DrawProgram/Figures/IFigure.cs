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
        Color ColorFigure { get; set; }
        Point[] GetPoints(Point[] points, bool check);
        void Draw(Graphics graphics, Pen pen, Point[] points);
    }
}
