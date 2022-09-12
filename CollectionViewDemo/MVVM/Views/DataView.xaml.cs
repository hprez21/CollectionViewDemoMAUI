using CollectionViewDemo.MVVM.ViewModels;

namespace CollectionViewDemo.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		  BindingContext = new DataViewModel();
	}
}