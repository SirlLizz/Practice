using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Practice_4._2
{
    public partial class Form1 : Form
    {
        private readonly Graphics g;
        private int pointRadius = 1;
        private Pen curvePen;
        private int buttonFlag = 0;
        //buttonflag = 1 если нажата кнопка добавления точки

        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle);
            Paint += Form1_Paint;
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen greenPen = new Pen(Color.Green, 2f);
            Point[] pm =
            {
                new Point(0, 0),
                new Point(100, 100),
                new Point(0, 100),
            };
            g.DrawClosedCurve(greenPen, pm, 0f, FillMode.Winding);
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            g.Clear(Color.White);
        }

        private void SettingsButton_Click(object sender, System.EventArgs e)
        {
            using (ChangeForm changeForm = new ChangeForm())
            {
                changeForm.StartPosition = FormStartPosition.Manual;
                if (changeForm.ShowDialog() == DialogResult.OK)
                {
                    pointRadius = changeForm.GetSelectedPointRadius();
                    curvePen = new Pen(Color.Blue, changeForm.GetSelectedCurveThickness());
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (buttonFlag)
            {
                case 1 :
                    g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(e.X-pointRadius, e.Y-pointRadius, pointRadius*2, pointRadius*2));
                    break;
            }
        }

        private void pointButton_Click(object sender, System.EventArgs e)
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
    }
}
