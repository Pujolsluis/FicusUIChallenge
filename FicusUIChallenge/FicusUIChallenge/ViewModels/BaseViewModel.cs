using System;
using System.ComponentModel;
using Prism.Navigation;
using Prism.Services;

namespace FicusUIChallenge.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected IPageDialogService PageDialogService;
        public INavigationService NavigationService;
        public bool IsBusy { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel(INavigationService navigationService, IPageDialogService pageDialogService=null)
        {
            NavigationService = navigationService;
            PageDialogService = pageDialogService;
        }
    }
}
