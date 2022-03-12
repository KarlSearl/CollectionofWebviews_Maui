using collectionofwebviews.model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace collectionofwebviews.viewmodel
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand SelectionChangedCommand { get => new Command(async () => await GoToWebsiteDetails()); }

        private ObservableCollection<ListDataModel> websiteList;
        public ObservableCollection<ListDataModel> WebsiteList
        {
            get { return websiteList; }
            set
            {
                websiteList = value;
                OnPropertyChanged();
            }
        }

        private ListDataModel _selectedWebsite;
        public ListDataModel SelectedWebsite
        {
            get => _selectedWebsite;
            set => SetProperty(ref _selectedWebsite, value);
        }


        private async Task GoToWebsiteDetails()
        {
            if (SelectedWebsite == null)
            {
                return;
            }
            await Application.Current.MainPage.Navigation.PushModalAsync(new WebviewDetails(SelectedWebsite));
            SelectedWebsite = null;
        }

        public HomeViewModel()
        {
           WebsiteList = GetDataForList();
        }

        private ObservableCollection<ListDataModel> GetDataForList()
        {
            return new ObservableCollection<ListDataModel>
            {
            new ListDataModel { Title = "LiLo.Lite", WebsiteDesc = "LiLo.Lite is a real-time cryptocurrency (crypto) price and chart tracking application. It provides a quick and easy way to watch the top crypto currency information with charting. Extremely low battery usage making crypto information available right at your fingertips.", WebsiteUR = new Uri(" https://play.google.com/store/apps/details?id=com.internetwideworld.lilo.lite&pcampaignid=twitter") },
            new ListDataModel { Title = "Ask Xammy", WebsiteDesc = "Leomaris Reyes, Microsoft MVP, Student Team Lead at Platzi, Software Engineer from the Dominican Republic with more than 6 years of experience in Software Development.", WebsiteUR = new Uri("https://askxammy.com/") },
            new ListDataModel { Title = "My Twitter", WebsiteDesc = "Mobile App Dev by day | Making websites by night Xamarin  .NET MAU | Azure, Git, C# | UX UI", WebsiteUR = new Uri("https://twitter.com/KarlSearl") },
            new ListDataModel { Title = "Xam Girl", WebsiteDesc = "Charlin Agramonte, from Dominican Republic. Co-Founder of CrossGeeks. I have 7 + years of experience in .NET, developing in Xamarin Forms since it started(in 2014).Currently Xamarin Certified Developer and Microsoft MVP.", WebsiteUR = new Uri("https://xamgirl.com/") }
          };
        }



    }
}
