namespace Acc2App.Views;

public partial class WebViewPage : ContentPage
{
	public WebViewPage(WebViewViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
