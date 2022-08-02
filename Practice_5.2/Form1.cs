using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

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

        private void bindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "bin files (*.bin)|*.bin|xml files (*.xml)|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:

                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(fileStream, bindingSource.List);
                        break;
                    case 2:
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<City>));
                        xmlSerializer.Serialize(fileStream, bindingSource.List);
                        break;
                }
                fileStream.Close();
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "bin files (*.bin)|*.bin|xml files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                switch (openFileDialog.FilterIndex)
                {
                    case 1:
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        bindingSource.DataSource = binaryFormatter.Deserialize(fileStream);
                        break;
                    case 2:
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<City>));
                        bindingSource.DataSource = xmlSerializer.Deserialize(fileStream);
                        break;
                }
                fileStream.Close();
            }
        }
    }
}
