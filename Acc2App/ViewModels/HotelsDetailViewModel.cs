namespace Acc2App.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class HotelsDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
