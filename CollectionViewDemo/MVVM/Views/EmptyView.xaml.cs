namespace CollectionViewDemo.MVVM.Views;

public partial class EmptyView : ContentPage
{
	public EmptyView()
	{
		InitializeComponent();
	}

	private void Switch_Toggled(object sender, ToggledEventArgs e)
	{
		  var isToggled = e.Value;
		  collectionView.EmptyView = isToggled ? Resources["NoResultsView"] :
			   Resources["ConnectivityIssue"];
	}
}