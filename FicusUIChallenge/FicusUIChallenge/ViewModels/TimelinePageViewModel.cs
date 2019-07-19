using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using FicusUIChallenge.Models;
using FicusUIChallenge.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace FicusUIChallenge.ViewModels
{
    public class TimeLinePageViewModel : BaseViewModel
    {
        public ObservableCollection<TimelineItem> Data { get; set; } = new ObservableCollection<TimelineItem>();
        public ICommand OnLoadMoreCommand { get; set; }
        public ICommand OnItemTappedCommand { get; set; }
        public DataService _dataService { get; set; } = new DataService();
        int _pageNumber = 0;

        public DelegateCommand OnBackCommand { get; set; }

        public ObservableCollection<TimelineItem> Items { get; set; }


        public TimeLinePageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
            OnBackCommand = new DelegateCommand(async () =>
           {
               if (IsBusy) return;
               IsBusy = true;
               await NavigationService.GoBackAsync();
               IsBusy = false;
           });


            // Command to load more data from our service
            OnLoadMoreCommand = new DelegateCommand(async () =>
            {
                IsBusy = true;

                try
                {
                    var users = await _dataService.GetUsersAsync(_pageNumber++, 10);

                    //Add the new data loaded from our service to our existing collection.
                    foreach (var user in users)
                    {
                        Data.Add(user);
                    }

                }
                catch (Exception ex)
                {
                    //Log any errors that might had occured while calling or using your service.
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    IsBusy = false;
                }

            });

            OnLoadMoreCommand.Execute(null);
        }
    }
}
