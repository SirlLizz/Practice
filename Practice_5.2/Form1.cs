using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practice_5._2
{
    public partial class Form1 : Form
    {
        private List<City> citys = new List<City>();

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = bindingSource.Current;
        }

        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            chart.Palette = ChartColorPalette.SeaGreen;
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add("Популяция");
            foreach (City city in bindingSource)
            {
                Series series = chart.Series.Add(city.Name);
                series.Points.Add(city.Population);
            }
        }
    }
}
