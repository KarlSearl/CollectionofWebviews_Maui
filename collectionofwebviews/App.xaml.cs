namespace collectionofwebviews;

public partial class App : Application
{
	public App(HomeView homeView)
	{
		InitializeComponent();

		MainPage = homeView;
	}
}
