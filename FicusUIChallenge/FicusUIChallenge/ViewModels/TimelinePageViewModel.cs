using System;
using Prism.Navigation;
using Prism.Services;

namespace FicusUIChallenge.ViewModels
{
    public class TimeLinePageViewModel : BaseViewModel
    {
        public TimeLinePageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
        }
    }
}
