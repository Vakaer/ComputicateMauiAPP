using ComputicateMobileAPP.Views;

namespace ComputicateMobileAPP;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DashboardPage),typeof(DashboardPage));
        Routing.RegisterRoute(nameof(DeskServicePage), typeof(DeskServicePage));
        Routing.RegisterRoute(nameof(TimeEntriesPage), typeof(TimeEntriesPage));
        Routing.RegisterRoute(nameof(CreateTicketPage), typeof(CreateTicketPage));
        Routing.RegisterRoute(nameof(TimeEntriesNotificationPage), typeof(TimeEntriesNotificationPage));
    }
}
