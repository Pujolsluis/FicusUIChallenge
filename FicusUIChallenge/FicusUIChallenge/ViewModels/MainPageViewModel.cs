using System;
using System.ComponentModel;
using FicusUIChallenge.Helpers;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace FicusUIChallenge.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public DelegateCommand OnGrowingPlanCommand { get; set; }
        public DelegateCommand OnTakeActionCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
            OnGrowingPlanCommand = new DelegateCommand(async () =>
            {
                if (IsBusy) return;
                IsBusy = true;
                await NavigationService.NavigateAsync(NavigationConstants.TimelinePage);
                IsBusy = false;
            });

            OnTakeActionCommand = new DelegateCommand(async () =>
            {
                if (IsBusy) return;
                IsBusy = true;
                await NavigationService.NavigateAsync(NavigationConstants.ActionsPage);
                IsBusy = false;
            });
        }
    }
}
