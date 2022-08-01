using System;
using System.ComponentModel;

namespace Practice_6._4.Models
{
    [Serializable]
    public class Writer : INotifyPropertyChanged
    {
        private string name = string.Empty;
        private int year = 0;
        private string country = string.Empty;
        private string mostFamousBook = string.Empty;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Year
        {
            get => year; 
            set
            {
                year = value;
                OnPropertyChanged("Year");
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
        public string MostFamousBook
        {
            get => mostFamousBook;
            set
            {
                mostFamousBook = value;
                OnPropertyChanged("MostFamousBook");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
