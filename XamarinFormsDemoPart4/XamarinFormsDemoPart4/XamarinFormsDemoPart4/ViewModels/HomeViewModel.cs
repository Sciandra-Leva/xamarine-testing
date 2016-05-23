using System.ComponentModel;
using XamarinFormsDemoPart4.Models;

namespace XamarinFormsDemoPart4.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public TaskModel TaskModel { get; set; }

        public HomeViewModel()
        {
            TaskModel = new TaskModel
            {
                Title = "Creating UI",
                Duration = 2
            };

        }
    }
}