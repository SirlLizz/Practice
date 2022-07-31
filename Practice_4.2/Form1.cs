using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practice_4._2
{
    public partial class Form1 : Form
    {
        private readonly Graphics g;
        private List<Point> points = new List<Point>();
        private Point dragPoint;
        private bool dragPointFlag;
        private int pointSpeed = 1;
        private readonly Timer moveTimer = new Timer
        {
            Interval = 30
        };
        private int randomX = new Random().Next(30);
        private int randomY = new Random().Next(30);
        private int pointRadius = 1;
        private Pen curvePen = new Pen(Color.Black, 1);
        private int buttonFlag = 0;
        //buttonflag = 1 если нажата кнопка добавления точки
        //2 если closed curve
        //3 если poligone
        //4 если fill curve
        //5 если motion

        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle);
            KeyPreview = true;
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

        private void PointButton_Click(object sender, System.EventArgs e)
        {
            if (buttonFlag != 1)
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
            moveTimer.Stop();
            points = new List<Point>();
            Clear();
        }

        private void DrawClosedCurveButton_Click(object sender, System.EventArgs e)
        {
            if (points.Count > 2)
            {
                DisablePointButton();
                Clear();
                PaintPoint();
                g.DrawClosedCurve(curvePen, points.ToArray());
                buttonFlag = 2;
            }
        }

        private void DrawPolygoneButton_Click(object sender, System.EventArgs e)
        {
            if (points.Count > 2)
            {
                DisablePointButton();
                Clear();
                PaintPoint();
                g.DrawPolygon(curvePen, points.ToArray());
                buttonFlag = 3;
            }
        }

        private void FillCurveButton_Click(object sender, System.EventArgs e)
        {
            if (points.Count > 2)
            {
                DisablePointButton();
                Clear();
                PaintPoint();
                g.FillClosedCurve(new SolidBrush(Color.Black), points.ToArray());
                buttonFlag = 4;
            }
        }

        private void BeziersButton_Click(object sender, EventArgs e)
        {
            if (points.Count == 4 || (points.Count - 4) % 3 == 0)
            {
                DisablePointButton();
                Clear();
                PaintPoint();
                g.DrawBeziers(curvePen, points.ToArray());
                buttonFlag = 5;
            }
        }

        private void MotionButton_Click(object sender, System.EventArgs e)
        {
            if (buttonFlag != 6)
            {
                buttonFlag = 6;
                motionButton.BackColor = Color.Blue;
                moveTimer.Tick += new EventHandler(TimerTickHandler);
                moveTimer.Start();
            }
            else
            {
                buttonFlag = -1;
                moveTimer.Stop();
                motionButton.BackColor = Color.White;
            }
        }

        private void TimerTickHandler(object sender, EventArgs e)
        {

            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].Y - randomY <= 0)
                {
                    randomY = 0 - randomY;
                }
                if (points[i].Y + randomY >= this.Height - 40 && randomY < 0)
                {
                    randomY = 0 - randomY;
                }
                if (points[i].X - randomX <= 0)
                {
                    randomX = 0 - randomX;
                }
                if (points[i].X + randomX >= this.Width - 15 && randomX < 0)
                {
                    randomX = 0 - randomX;
                }
                points[i] = new Point(points[i].X - randomX, points[i].Y - randomY);
            }
            Clear();
            PaintPoint();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Point point in points)
            {
                if (e.X - pointRadius < point.X &&
                    point.X < e.X + pointRadius &&
                    e.Y - pointRadius < point.Y &&
                    point.Y < e.Y + pointRadius)
                {
                    dragPointFlag = true;
                    dragPoint = point;
                    if (buttonFlag == 1)
                    {
                        DisablePointButton();
                    }
                    break;
                }
            }
            if (buttonFlag == 1)
            {
                points.Add(new Point(e.X, e.Y));
                g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(e.X - pointRadius, e.Y - pointRadius, pointRadius * 2, pointRadius * 2));
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragPointFlag)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    if (points[i] == dragPoint)
                    {
                        points[i] = new Point(e.X, e.Y);
                        break;
                    }
                }
                dragPoint = new Point(e.X, e.Y);
                Clear();
                PaintPoint();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Clear();
                    break;
                case Keys.Space:
                    MotionButton_Click(sender, e);
                    break;
                case Keys.W:
                    for (int i = 0; i < points.Count; i++)
                    {
                        if (points[i].Y - pointSpeed >= 0)
                        {
                            points[i] = new Point(points[i].X, points[i].Y - pointSpeed);
                            Clear();
                            PaintPoint();
                        }
                    }
                    break;
                case Keys.A:
                    for (int i = 0; i < points.Count; i++)
                    {
                        if (points[i].X - pointSpeed >= 0)
                        {
                            points[i] = new Point(points[i].X - pointSpeed, points[i].Y);
                            Clear();
                            PaintPoint();
                        }
                    }
                    break;
                case Keys.S:
                    for (int i = 0; i < points.Count; i++)
                    {
                        if (points[i].Y + pointSpeed <= this.Height - 40)
                        {
                            points[i] = new Point(points[i].X, points[i].Y + pointSpeed);
                            Clear();
                            PaintPoint();
                        }
                    }
                    break;
                case Keys.D:
                    for (int i = 0; i < points.Count; i++)
                    {
                        if (points[i].X + pointSpeed <= this.Width - 15)
                        {
                            points[i] = new Point(points[i].X + pointSpeed, points[i].Y);
                            Clear();
                            PaintPoint();
                        }
                    }
                    break;
                case Keys.Oemplus:
                    pointSpeed++;
                    break;
                case Keys.OemMinus:
                    if (pointSpeed > 1)
                        pointSpeed--;
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragPointFlag = false;
        }

        private void DisablePointButton()
        {
            buttonFlag = 0;
            pointButton.BackColor = settingsButton.BackColor;
        }

        private void PaintPoint()
        {
            foreach (Point point in points)
            {
                g.FillEllipse(new SolidBrush(Color.Black),
                    new Rectangle(point.X - pointRadius, point.Y - pointRadius, pointRadius * 2, pointRadius * 2));
            }
            switch (buttonFlag)
            {
                case 2:
                    g.DrawClosedCurve(curvePen, points.ToArray());
                    break;
                case 3:
                    g.DrawPolygon(curvePen, points.ToArray());
                    break;
                case 4:
                    g.FillClosedCurve(new SolidBrush(Color.Black), points.ToArray());
                    break;
                case 5:
                    g.DrawBeziers(curvePen, points.ToArray());
                    break;

            }
        }

        void Clear()
        {
            g.Clear(Color.White);
        }
    }
}
