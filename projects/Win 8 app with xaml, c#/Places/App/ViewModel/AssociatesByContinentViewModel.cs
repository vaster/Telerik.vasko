using App.HttpClient_ViewModel_Bridge;
using App.Navigation;
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
    public class AssociatesByContinentViewModel
    {
        private Navigator navigator;
        private ICommand navigate;
        private ICommand goBack;
        private ObservableCollection<WelcomePlace> placesByContinent;

        public AssociatesByContinentViewModel(Navigator navigator)
        {
            this.navigator = navigator;
            this.placesByContinent = new ObservableCollection<WelcomePlace>();
        }


        public ObservableCollection<WelcomePlace> PlacesByContinent
        {
            get
            {
                this.LoadPlacesByContinent();
                return this.placesByContinent;
            }
        }

        public string Continent
        {
            get { return ShortDescriptionViewModel.SelectedElement.Continent; }
        }


        private async void LoadPlacesByContinent()
        {
            var allByContinent = await
                DataPersister.GetAssocietesByContinent(ShortDescriptionViewModel.SelectedElement.Continent);
            this.placesByContinent.Clear();

            foreach (var place in allByContinent)
            {
                this.placesByContinent.Add(place);
            }
        }

        public ICommand NavigateCommand
        {
            get
            {
                if (this.navigate == null)
                {
                    this.navigate = new RelayCommand(HandleNavigate);
                }
                return this.navigate;
            }
        }

        private void HandleNavigate()
        {
            this.navigator.Navigate(Views.DescriptionPage);
        }

        public ICommand GoBack
        {
            get
            {
                if (this.goBack == null)
                {
                    this.goBack = new RelayCommand(HandleGoBack);
                }
                return this.goBack;
            }
        }

        private void HandleGoBack()
        {
            this.navigator.GoBack();
        }
    }
}
