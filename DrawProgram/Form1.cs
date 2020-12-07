using DrawProgram.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawProgram
{
    public partial class Form1 : Form
    {
        Bitmap _bitmap;
        Pen _pen;
        Point _prev;
        Graphics _graphics;
        bool _mD;
        Bitmap _tmpbmp;
        bool shi;
        IFigure _crntFigure;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _tmpbmp = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_bitmap);
            _pen = new Pen(Color.Black, 1);
            _prev = new Point(0, 0);
            _mD = false;
            shi = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mD)
            {
                _tmpbmp.Dispose();
                _tmpbmp = (Bitmap)_bitmap.Clone();
                _graphics = Graphics.FromImage(_tmpbmp);
                _crntFigure.Draw(_graphics, _pen, _crntFigure.GetPoints(new Point[] { _prev, e.Location }, checkBox1.Checked));
                pictureBox1.Image = _tmpbmp;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _prev = e.Location;
            _mD = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _bitmap = (Bitmap)_tmpbmp.Clone();
            _mD = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _crntFigure = new RightTraingleFigure();
        }
    }
}
