using Microsoft.Maui.Controls;

namespace ComputicateMobileAPP.Views;

public partial class CreateTicketPage : ContentPage
{
	public CreateTicketPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_GeneralBtn(object sender, TappedEventArgs e)
    {
        GeneralLabel.TextColor = Colors.White;
        GeneralBtn.BackgroundColor = Color.FromArgb("#408BEA");
        BillableLabel.TextColor = Colors.Black;
        BillableBtn.BackgroundColor = Colors.Transparent;
        DetailsLabel.TextColor = Colors.Black;
        DetailsBtn.BackgroundColor = Colors.Transparent;
    }
    private void TapGestureRecognizer_DetailsBtn(object sender, TappedEventArgs e)
    {
        GeneralLabel.TextColor = Colors.Black;
        GeneralBtn.BackgroundColor = Colors.Transparent;
        BillableLabel.TextColor = Colors.Black;
        BillableBtn.BackgroundColor = Colors.Transparent;
        DetailsLabel.TextColor = Colors.White;
        DetailsBtn.BackgroundColor = Color.FromArgb("#408BEA");
    }
    private void TapGestureRecognizer_BillableBtn(object sender, TappedEventArgs e)
    {
        GeneralLabel.TextColor = Colors.Black;
        GeneralBtn.BackgroundColor = Colors.Transparent;
        DetailsLabel.TextColor = Colors.Black;
        DetailsBtn.BackgroundColor = Colors.Transparent;
        BillableLabel.TextColor = Colors.White;
        BillableBtn.BackgroundColor = Color.FromArgb("#408BEA"); 
    }
}