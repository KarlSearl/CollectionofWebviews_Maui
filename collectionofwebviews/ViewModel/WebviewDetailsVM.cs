using collectionofwebviews.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace collectionofwebviews.viewmodel
{
    public class WebviewDetailsVM:BaseViewModel
    {
        public ICommand GoBackCommand { get => new Command(async () => await Application.Current.MainPage.Navigation.PopModalAsync()); }

       
        private ListDataModel _selected;
        public ListDataModel Selected
        {
            get => _selected;
            set => SetProperty(ref _selected, value);
        }

    
        public WebviewDetailsVM(ListDataModel selected)
        {
            _selected = selected;        
        }
      
    }
}
