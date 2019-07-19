using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using FicusUIChallenge.Models;

namespace FicusUIChallenge.Services
{
    public class DataService
    {
        public ObservableCollection<TimelineItem> _usersDataSource { get; set; } = new ObservableCollection<TimelineItem>()
        {
            new TimelineItem()
            {
                ID = 1,
                Title = "Water your plant",
                DateOfAction = DateTime.Now.AddDays(-1)
            },
            new TimelineItem()
            {
                ID = 2,
                Title = "Add fertilizer",
                DateOfAction = DateTime.Now.AddDays(-2)
            },
            new TimelineItem()
            {
                ID = 3,
                Title = "Water your plant",
                DateOfAction = DateTime.Now.AddDays(-3)
            },
            new TimelineItem()
            {
                ID = 4,
                Title = "Add some light",
                DateOfAction = DateTime.Now.AddDays(-4)
            },
            new TimelineItem()
            {
                ID = 5,
                Title = "Water your plant",
                DateOfAction = DateTime.Now.AddDays(-5)
            },
            new TimelineItem()
            {
                ID = 6,
                Title = "Add some light",
                DateOfAction = DateTime.Now.AddDays(-6)
            },
            new TimelineItem()
            {
                ID = 7,
                Title = "Water your plant",
                DateOfAction = DateTime.Now.AddDays(-7)
            },
            new TimelineItem()
            {
                ID = 8,
                Title = "Add fertilizer",
                DateOfAction = DateTime.Now.AddDays(-8)
            },
            new TimelineItem()
            {
                ID = 9,
                Title = "Add some light",
                DateOfAction = DateTime.Now.AddDays(-9)
            },
        };

        public DataService()
        {
        }

        public async Task<IList<TimelineItem>> GetUsersAsync(int pageIndex, int pageSize)
        {
            await Task.Delay(1500);

            return _usersDataSource.Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }
    }
}
