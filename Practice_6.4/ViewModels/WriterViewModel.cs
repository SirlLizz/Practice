using Microsoft.Win32;
using Newtonsoft.Json;
using Practice_6._4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice_6._4.ViewModels
{
    public class WriterViewModel : INotifyPropertyChanged
    {
        private Writer selectedWriter { get; set; } = new Writer();
        public ObservableCollection<Writer> Writers { get; set; }

        public Writer SelectedWriter
        {
            get => selectedWriter;
            set
            {
                selectedWriter = value;
                OnPropertyChanged("SelectedWriter");
            }
        }

        private BaseCommand addCommand;
        private BaseCommand removeCommand;
        private BaseCommand saveCommand;
        private BaseCommand openCommand;

        public BaseCommand AddCommand
        {
            get
            {
                return addCommand ??= new BaseCommand(obj =>
                {
                    Writer Writer = new();
                    Writers.Add(Writer);
                    SelectedWriter = Writer;
                });
            }
        }

        public BaseCommand RemoveCommand
        {
            get
            {
                if (removeCommand != null)
                    return removeCommand;
                else
                {
                    Action<object> Execute = o =>
                    {
                        Writers.Remove(SelectedWriter);
                    };
                    Func<object, bool> CanExecute = o => Writers.Count > 0;
                    removeCommand = new BaseCommand(Execute, CanExecute);
                    return removeCommand;
                }
            }
        }

        public BaseCommand SaveCommand
        {
            get
            {
                if (saveCommand != null)
                    return saveCommand;
                else
                {
                    Action<object> Execute = o =>
                    {
                        SaveFileDialog saveFileDialog = new();
                        saveFileDialog.Filter = "json files (*.json)|*.json|xml files (*.xml)|*.xml";

                        if (saveFileDialog.ShowDialog() == true)
                        {
                            switch (saveFileDialog.FilterIndex)
                            {
                                case 1:
                                    string jsonString = JsonConvert.SerializeObject(Writers, Formatting.Indented);
                                    File.WriteAllText(saveFileDialog.FileName, jsonString);
                                    break;
                                case 2:
                                    XElement x = new XElement("Writers",
                                                    from Writer in Writers
                                                    select new XElement("Writer",
                                                        new XAttribute("Name", Writer.Name),
                                                        new XElement("Year", Writer.Year),
                                                        new XElement("Country", Writer.Country),
                                                        new XElement("MostFamousBook", Writer.MostFamousBook)));
                                    File.WriteAllText(saveFileDialog.FileName, x.ToString());
                                    break;
                            }
                        }
                    };
                    Func<object, bool> CanExecute = o => Writers.Count > 0;
                    saveCommand = new BaseCommand(Execute, CanExecute);
                    return saveCommand;
                }
            }
        }

        public BaseCommand OpenCommand
        {
            get
            {
                return openCommand ??= new BaseCommand(obj =>
                {
                    OpenFileDialog openFileDialog = new();
                    openFileDialog.Filter = "json files (*.json)|*.json|xml files (*.xml)|*.xml";

                    if (openFileDialog.ShowDialog() == true)
                    {
                        switch (openFileDialog.FilterIndex)
                        {
                            case 1:
                                var j = JsonConvert.DeserializeObject<List<Writer>>(File.ReadAllText(openFileDialog.FileName));
                                Writers.Clear();
                                foreach (Writer Writer in j)
                                {
                                    Writers.Add(Writer);
                                }
                                break;
                            case 2:
                                var x = XElement.Parse(File.ReadAllText(openFileDialog.FileName));
                                var q = from e in x.Elements()
                                        select new Writer()
                                        {
                                            Name = e.Attribute("Name").Value,
                                            Year = int.Parse(e.Element("Year").Value),
                                            Country = e.Element("Country").Value,
                                            MostFamousBook = e.Element("MostFamousBook").Value
                                        };
                                Writers.Clear();
                                foreach (Writer Writer in q)
                                {
                                    Writers.Add(Writer);
                                }
                                break;
                        }
                    }
                });
            }
        }

        public WriterViewModel()
        {
            Writers = new ObservableCollection<Writer>()
            {
                new Writer(){Name = "Пушкин", Country = "Россия", Year = 1799, MostFamousBook = "Евгений Онегин"},
                new Writer(){Name = "Толстой", Country = "Россия", Year = 1828, MostFamousBook = "Война и мир"},
                new Writer(){Name = "Достоевский", Country = "Россия", Year = 1821, MostFamousBook = "Преступление и наказание" }
            };
            SelectedWriter = Writers[0];
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
