namespace Acc2App.Views;

public partial class HotelsDetailPage : ContentPage
{
	public HotelsDetailPage(HotelsDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
