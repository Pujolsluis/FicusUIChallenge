using System;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace FicusUIChallenge.ViewModels
{
    public class TimeLinePageViewModel : BaseViewModel
    {
        public DelegateCommand OnBackCommand { get; set; }
        public TimeLinePageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
            OnBackCommand = new DelegateCommand(async () =>
           {
               if (IsBusy) return;
               IsBusy = true;
               await NavigationService.GoBackAsync();
               IsBusy = false;
           });
        }
    }
}
