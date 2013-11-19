using App.HttpClient_ViewModel_Bridge;
using App.Navigation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PlacesToVisit.Models.AppModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.ViewModel
{
    public class SearchViewModel : ViewModelBase
    {
        private string queryText = "";
        private Navigator navigator;
        private ObservableCollection<WelcomePlace> searchResults;
        private ICommand navigateCommand;


        public SearchViewModel(Navigator navigator)
        {
            this.navigator = navigator;
            this.searchResults = new ObservableCollection<WelcomePlace>();
        }

        public string QueryText
        {
            get
            {
                return this.queryText;
            }
            set
            {
                this.queryText = value;
                this.RaisePropertyChanged("QueryText");
                this.LoadResults();
            }
        }

        public IEnumerable<WelcomePlace> SearchResults
        {
            get
            {
                return this.searchResults;
            }
            set
            {
                this.searchResults.Clear();

                foreach (var item in value)
                {

                    this.searchResults.Add(item);
                }
            }
        }

        private async void LoadResults()
        {
            this.searchResults.Clear();
            var all = await DataPersister.GetWelcomePlacesEntities();
            var queryTextToLower = QueryText.ToLower();

            foreach (var item in all)
            {
                if (item.Title.ToLower().Contains(queryTextToLower) ||
                    item.Continent.ToLower().Contains(queryTextToLower) ||
                    item.Category.ToLower().Contains(queryTextToLower))
                {
                    this.searchResults.Add(item);
                }
            }
        }

        public ICommand NavigateCommand
        {
            get
            {
                if (this.navigateCommand == null)
                {
                    this.navigateCommand = new RelayCommand(HandleNavigate);
                }
                return this.navigateCommand;
            }
        }

        private void HandleNavigate()
        {
            this.navigator.Navigate(Views.DescriptionPage);
        }
    }
}
