

using ComputicateMobileAPP.ViewModel;
using Mopups.Pages;
using Mopups.Services;

namespace ComputicateMobileAPP.Views;

public partial class TimeEntriesPage : ContentPage
{
    public TimeEntriesPage()
    {
        InitializeComponent();
    }
  

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TimeEntriesNotificationPage));
    }
    private async void ToolbarItemFilters_Clicked(object sender, EventArgs e)
    {
       await MopupService.Instance.PushAsync(new TimeEntriesFiltersMopupPage());
    }

    private async void NavigateAddTimeRegistration(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddTimeRegistrationPage));
    }
    
}