using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using XamarinFormsDemoPart4.Annotations;
using XamarinFormsDemoPart4.Models;

namespace XamarinFormsDemoPart4.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private TaskModel _taskModel;
        private string _message;

        public TaskModel TaskModel
        {
            get { return _taskModel; }
            set
            {
                _taskModel = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public Command SaveCommand
        {
            get
            {
                return new Command(() =>
                {
                    Message = "Your task : " + TaskModel.Title + " ," + TaskModel.Duration + " was successfully saved!";
                });
            }
        }

        public HomeViewModel()
        {
            TaskModel = new TaskModel
            {
                Title = "Creating UI",
                Duration = 2
            };

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}