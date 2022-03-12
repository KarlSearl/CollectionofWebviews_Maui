using collectionofwebviews.model;
using collectionofwebviews.viewmodel;

namespace collectionofwebviews;

public partial class WebviewDetails : ContentPage
{
	public WebviewDetails( ListDataModel selected)
	{
		InitializeComponent();
		
		this.BindingContext = new WebviewDetailsVM(selected);
		
	}
}