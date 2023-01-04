

using ComputicateMobileAPP.ViewModel;

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
        await DisplayAlert("Filters", "tapped", "ok");
    }

    private async void NavigateAddTimeRegistration(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddTimeRegistrationPage));
    }
}