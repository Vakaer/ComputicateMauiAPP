namespace ComputicateMobileAPP.Views;

public partial class DeskServicePage : ContentPage
{
	public DeskServicePage()
	{
		InitializeComponent();
	}

    private void Search_Clicked(object sender, EventArgs e)
    {
       
       
       
        if(PageTitle.IsVisible == true) {
            PageTitle.IsVisible = false;
            searchBar.IsVisible = true;
        }
        else
        {
            PageTitle.IsVisible = true;
            searchBar.IsVisible = false;
        }
    }
}