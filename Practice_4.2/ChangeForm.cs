using System;
using System.Windows.Forms;

namespace Practice_4._2
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        public int GetSelectedPointRadius()
        {
            return trackBarPoint.Value;
        }
        public int GetSelectedCurveThickness()
        {
            return trackBarCurve.Value;
        }

        private void TrackBarPoint_Scroll(object sender, EventArgs e)
        {
            label3.Text = String.Format("{0}", trackBarPoint.Value);
        }

        private void TrackBarCurve_Scroll(object sender, EventArgs e)
        {
            label4.Text = String.Format("{0}", trackBarCurve.Value);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
