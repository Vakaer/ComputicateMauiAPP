namespace ComputicateMobileAPP.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Weekly(object sender, TappedEventArgs e)
    {
        WeeklyBtn.BackgroundColor = Color.FromArgb("#2668C5");
        WeeklyLable.TextColor = Colors.White;
        YearlyBtn.BackgroundColor = Colors.Transparent;
        YearlyLable.TextColor = Colors.Black;
    }
    private void TapGestureRecognizer_Yearly(object sender, TappedEventArgs e)
    {
        YearlyBtn.BackgroundColor = Color.FromArgb("#2668C5");
        YearlyLable.TextColor = Colors.White;
        WeeklyBtn.BackgroundColor = Colors.Transparent;
        WeeklyLable.TextColor = Colors.Black;
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TimeEntriesNotificationPage));
    }
}