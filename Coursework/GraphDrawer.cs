using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Coursework.RootFinder;

namespace Coursework
{
    class GraphDrawer
    {

        private readonly double drawingPrecision = 4;
        private readonly Panel panel;
        private readonly int size;

        private Graphics gr;
        public Function Function { get; set; }
        private double intervalA;
        private double intervalB;
        private double shift;
        private int scale;
        private double drawingEpsilon;
        public PointF Root { get; set; }

        public GraphDrawer(Panel panel)
        {
            this.panel = panel;
            size = panel.Width;
        }

        public void SetInterval(double a, double b)
        {
            if (a >= b) throw new Exception("A должно быть меньше B");
            intervalA = a;
            intervalB = b;
            scale = (int) (size / Math.Abs(b - a));
            shift = (b + a) / 2;
            drawingEpsilon = (Math.Abs(b - a) / size) * drawingPrecision;
        }

        public void Redraw(Graphics gr)
        {
            this.gr = gr;
            this.gr.SmoothingMode = SmoothingMode.AntiAlias;
            DrawAxes();
            try
            {
                DrawGraph();
            } catch(Exception) { }
        }

        private void DrawAxes()
        {
            Pen axisPen = new Pen(new SolidBrush(Color.Black), 2);
            gr.DrawLine(axisPen, 0, size / 2, size, size / 2);
            gr.DrawString("x", new Font("Courier New", 12), 
                new SolidBrush(Color.Black), new Point(size - 20, size / 2));

            int yAxisX = (int) (-shift * scale + size / 2);
            gr.DrawLine(axisPen, yAxisX, 0, yAxisX, size);
            gr.DrawString("y", new Font("Courier New", 12),
                new SolidBrush(Color.Black), new Point(yAxisX + 5, 0));
        }

        private void DrawGraph()
        {
            DrawGraphSegments(intervalA);
            if(Root != null)
            {
                int absRootX = (int)((Root.X - shift) * scale + size / 2);
                int absRootY = size - (int)(Root.Y * scale + size / 2);
                gr.FillEllipse(new SolidBrush(Color.Blue), 
                    new Rectangle(absRootX - 6, absRootY - 6, 12, 12));
            }
        }

        private void DrawGraphSegments(double currentX)
        {
            if (currentX >= intervalB) return;
            double nextX = currentX + drawingEpsilon;
            try
            {
                double currentY = Function(currentX);
                double nextY = Function(nextX);
                int absCurrentX = (int) ((currentX - shift) * scale + size / 2);
                int absNextX = (int)((nextX - shift) * scale + size / 2);
                int absCurrentY = size - (int)(currentY * scale + size / 2);
                int absNextY = size - (int)(nextY * scale + size / 2);
                if (!((absCurrentY > size && absNextY > size)
                    || (absCurrentY < 0 && absNextY < 0)))
                {
                    gr.DrawLine(new Pen(new SolidBrush(Color.Red), 3),
                        absCurrentX, absCurrentY, absNextX, absNextY);
                }
            } catch (Exception)
            {
            }
            DrawGraphSegments(nextX);
        }

    }
}
