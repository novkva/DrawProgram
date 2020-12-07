using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DrawProgram.Figures
{
    public class RightTraingleFigure : IFigure
    {
        Keys abc;

        public Color ColorFigure { get; set; }

        public Point[] GetPoints(Point[] points, bool check)
        {
            if (check)
            {
                return MathSolve.SolveDownRightTriangle(points[0], points[1]);
            }
            else
            {
                return MathSolve.SolveUpRightTriangle(points[0], points[1]);
            }

        }
        public void Draw(Graphics graphics, Pen pen, Point[] points)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
