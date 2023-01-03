

using ComputicateMobileAPP.ViewModel;

namespace ComputicateMobileAPP.Views;

public partial class TimeEntriesPage : ContentPage
{
    public TimeEntriesPage(TimeEntriesVM vM)
    {
        InitializeComponent();
        BindingContext = vM;
        


    }
  

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TimeEntriesNotificationPage));
    }
}