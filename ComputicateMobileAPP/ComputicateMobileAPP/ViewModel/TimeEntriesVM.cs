using ComputicateMobileAPP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComputicateMobileAPP.ViewModel
{
    public class TimeEntriesVM : INotifyPropertyChanged
    {
                public event PropertyChangedEventHandler PropertyChanged;
        #region Commands
        public ICommand GoToNotificationsPage => new Command(Notifications_command);
        public ICommand GoToMainPage => new Command(goToDashboard);


        async void Notifications_command()
        {
            await Shell.Current.GoToAsync(nameof(DashboardPage));
        }
       
        async void goToDashboard()
        {
            await Shell.Current.GoToAsync("deskService");
        }


        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        #endregion
    }
}
