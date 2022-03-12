using collectionofwebviews.viewmodel;

namespace collectionofwebviews;

public partial class HomeView : ContentPage
{
	public HomeView(HomeViewModel vM)
	{
		InitializeComponent();
		this.BindingContext = vM;
	}
}