namespace Acc2App.Views;

public partial class HotelsPage : ContentPage
{
	HotelsViewModel ViewModel;

	public HotelsPage(HotelsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
}
