namespace Acc2App;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HotelsDetailPage), typeof(HotelsDetailPage));
	}
}
