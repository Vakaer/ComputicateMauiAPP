using ComputicateMobileAPP.Views;

namespace ComputicateMobileAPP;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Dashboard),typeof(Dashboard));
	}
}
