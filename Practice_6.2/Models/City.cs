using System;
using System.ComponentModel;

namespace Practice_6._2.Models
{
    [Serializable]
    public class City : INotifyPropertyChanged
    {
        private string name = string.Empty;
        private int population = 0;
        private string country = string.Empty;
        private int cityAge = 0;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Population
        {
            get => population;
            set
            {
                population = value;
                OnPropertyChanged("Population");
            }
        }
        public string Country
        {
            get => country;
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }
        public int CityAge
        {
            get => cityAge;
            set
            {
                cityAge = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
