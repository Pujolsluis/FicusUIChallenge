using System;
using System.ComponentModel;

namespace FicusUIChallenge.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public string Text { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            Text = "Test";
        }

    }
}
