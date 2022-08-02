using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practice_4._4
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        public Color GetSelectedPointColor()
        {
            return PointColorButton.BackColor;
        }
        public Color GetSelectedCurveColor()
        {
            return CurveColorButton.BackColor;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pointColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            PointColorButton.BackColor = colorDialog.Color;
        }

        private void CurveColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            CurveColorButton.BackColor = colorDialog.Color;
        }
    }
}
