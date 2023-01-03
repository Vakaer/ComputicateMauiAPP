using ComputicateMobileAPP.Views;

namespace ComputicateMobileAPP;

public partial class App : Application
{
	public App(AppShell shell)
	{
		InitializeComponent();

        MainPage = shell;
        //MainPage = new NavigationPage(new Dashboard());
    }
}
