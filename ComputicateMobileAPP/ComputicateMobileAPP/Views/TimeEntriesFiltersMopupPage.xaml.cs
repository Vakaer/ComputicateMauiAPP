using Mopups.Services;

namespace ComputicateMobileAPP.Views;

public partial class TimeEntriesFiltersMopupPage 
{
	public TimeEntriesFiltersMopupPage()
	{
		InitializeComponent();
	}
    private void CloseButton_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}