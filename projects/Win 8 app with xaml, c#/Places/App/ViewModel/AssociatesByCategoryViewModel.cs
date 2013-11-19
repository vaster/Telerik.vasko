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
    public class AssociatesByCategoryViewModel
    {
        private Navigator navigator;
        private ICommand navigate;
        private ICommand goBack;
        private ObservableCollection<WelcomePlace> placesByCategory;

        public AssociatesByCategoryViewModel(Navigator navigator)
        {
            this.navigator = navigator;
            this.placesByCategory = new ObservableCollection<WelcomePlace>();
        }


        public ObservableCollection<WelcomePlace> PlacesByCategory
        {
            get
            {
                this.LoadPlacesByCategory();
                return this.placesByCategory;
            }
        }

        private async void LoadPlacesByCategory()
        {
            var allByCategory = await
                DataPersister.GetAssocietesByCategory(ShortDescriptionViewModel.SelectedElement.Category);
            this.placesByCategory.Clear();

            foreach (var place in allByCategory)
            {
                this.placesByCategory.Add(place);
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

        public string Category
        {
            get { return ShortDescriptionViewModel.SelectedElement.Category; }
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
