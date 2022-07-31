using Microsoft.Win32;
using Newtonsoft.Json;
using Practice_6._2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Practice_6._2.ViewModels
{
    public class CityViewModel : INotifyPropertyChanged
    {
        private City selectedCity { get; set; } = new City();
        public ObservableCollection<City> Citys { get; set; }

        public City SelectedCity
        {
            get => selectedCity;
            set
            {
                selectedCity = value;
                OnPropertyChanged("SelectedCity");
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
                    City city = new();
                    Citys.Add(city);
                    SelectedCity = city;
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
                        Citys.Remove(SelectedCity);
                    };
                    Func<object, bool> CanExecute = o => Citys.Count > 0;
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
                                    string jsonString = JsonConvert.SerializeObject(Citys, Formatting.Indented);
                                    File.WriteAllText(saveFileDialog.FileName, jsonString);
                                    break;
                                case 2:
                                    XElement x = new XElement("Citys",
                                                    from city in Citys
                                                    select new XElement("City",
                                                        new XAttribute("Name", city.Name),
                                                        new XElement("Population", city.Population),
                                                        new XElement("Country", city.Country),
                                                        new XElement("CityAge", city.CityAge)));
                                    File.WriteAllText(saveFileDialog.FileName, x.ToString());
                                    break;
                            }
                        }
                    };
                    Func<object, bool> CanExecute = o => Citys.Count > 0;
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
                                var j = JsonConvert.DeserializeObject<List<City>>(File.ReadAllText(openFileDialog.FileName));
                                Citys.Clear();
                                foreach (City city in j)
                                {
                                    Citys.Add(city);
                                }
                                break;
                            case 2:
                                var x = XElement.Parse(File.ReadAllText(openFileDialog.FileName));
                                var q = from e in x.Elements()
                                        select new City()
                                        {
                                            CityAge = int.Parse(e.Element("CityAge").Value),
                                            Name = e.Attribute("Name").Value,
                                            Country = e.Element("Country").Value,
                                            Population = int.Parse(e.Element("Population").Value)
                                        };
                                Citys.Clear();
                                foreach (City city in q)
                                {
                                    Citys.Add(city);
                                }
                                break;
                        }
                    }
                });
            }
        }

        public CityViewModel()
        {
            Citys = new ObservableCollection<City>()
            {
                new City(){Name = "Самара", Country = "Россия", Population = 1600000, CityAge = 1000 },
                new City(){Name = "Сызрань", Country = "Россия", Population = 250000, CityAge = 1000 },
                new City(){Name = "Тольятти", Country = "Россия", Population = 600000, CityAge = 1000 }
            };
            SelectedCity = Citys[0];
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
