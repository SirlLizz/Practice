using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Practice_4._2
{
    public partial class Form1 : Form
    {
        private readonly Graphics g;
        private List<Point> points = new List<Point>();
        private int pointRadius = 1;
        private Pen curvePen = new Pen(Color.Black, 1);
        private int buttonFlag = 0;
        //buttonflag = 1 если нажата кнопка добавления точки

        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle);
        }

        private void SettingsButton_Click(object sender, System.EventArgs e)
        {
            using (ChangeForm changeForm = new ChangeForm())
            {
                changeForm.StartPosition = FormStartPosition.Manual;
                if (changeForm.ShowDialog() == DialogResult.OK)
                {
                    pointRadius = changeForm.GetSelectedPointRadius();
                    curvePen.Width = changeForm.GetSelectedCurveThickness();
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (buttonFlag)
            {
                case 1 :
                    points.Add(new Point(e.X, e.Y));
                    g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(e.X-pointRadius, e.Y-pointRadius, pointRadius*2, pointRadius*2));
                    break;
            }
        }

        private void PointButton_Click(object sender, System.EventArgs e)
        {
            if(buttonFlag != 1)
            {
                buttonFlag = 1;
                pointButton.BackColor = Color.Blue;
            }
            else
            {
                buttonFlag = 0;
                pointButton.BackColor = settingsButton.BackColor;
            }
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            g.Clear(Color.White);
        }

        private void DrawClosedCurveButton_Click(object sender, System.EventArgs e)
        {
            Clear();
            PaintPoint();
            g.DrawClosedCurve(curvePen, points.ToArray());
        }

        private void DrawPolygoneButton_Click(object sender, System.EventArgs e)
        {
            Clear();
            PaintPoint();
            g.DrawPolygon(curvePen, points.ToArray());
        }

        private void PaintPoint()
        {
            foreach (Point point in points)
            {
                g.FillEllipse(new SolidBrush(Color.Black),
                    new Rectangle(point.X - pointRadius, point.Y - pointRadius, pointRadius * 2, pointRadius * 2));
            }
        }

        private void FillCurveButton_Click(object sender, System.EventArgs e)
        {
            Clear();
            PaintPoint();
            g.FillClosedCurve(new SolidBrush(Color.Black), points.ToArray());
        }
    }
}
