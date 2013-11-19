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
    public class ShortDescriptionViewModel : ViewModelBase
    {
        private ShortDescriptionPlace currentSelection;
        private ICommand navigateCommand;
        private ICommand showNextPicture;
        private ICommand showPrevPicture;
        private ICommand navigateToTextPage;
        private ICommand goBack;
        private ICommand navigateToByContinentPage;
        private ICommand navigateToByCategoryPage;
        private string currImagePathToShow;
        private Navigator navigator;
        private int currImageIndex;
        private bool toLoadCurrentSelection;

        public static WelcomePlace SelectedElement { get; set; }

        public ShortDescriptionViewModel(Navigator navigator)
        {
            this.navigator = navigator;
            this.currImageIndex = 0;
            this.toLoadCurrentSelection = true;
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
            this.LoadInitState();
            this.navigator.Navigate(Views.DescriptionPage);
        }


        public ShortDescriptionPlace CurrentSelection
        {
            get
            {
                if (this.toLoadCurrentSelection)
                {
                    this.SetCurrentSelection();
                }
                return this.currentSelection;
            }
            set
            {
                this.currentSelection = value;
                this.RaisePropertyChanged("CurrentSelection");
                this.toLoadCurrentSelection = true;
            }
        }

        public string CurrImageUrlToShow
        {
            get { return this.currImagePathToShow; }
            set
            {
                this.currImagePathToShow = value;
                this.RaisePropertyChanged("CurrImageUrlToShow");
            }
        }

        private async void SetCurrentSelection()
        {
            this.toLoadCurrentSelection = false;
            this.CurrentSelection = await
                DataPersister.GetFullDescriptionForPlace(ShortDescriptionViewModel.SelectedElement.Title);
            this.CurrImageUrlToShow = this.currentSelection.ImageUrl[this.currImageIndex];

        }

        public ICommand ShowNextPicture
        {
            get
            {
                if (this.showNextPicture == null)
                {
                    this.showNextPicture = new RelayCommand(HandeShowNextPicture);
                }
                return this.showNextPicture;
            }
        }

        public ICommand ShowPrevPicture
        {
            get
            {
                if (this.showPrevPicture == null)
                {
                    this.showPrevPicture = new RelayCommand(HandleShowPrevPicture);
                }
                return this.showPrevPicture;
            }
        }

        public ICommand NavigateToTextPage
        {
            get
            {
                if (this.navigateToTextPage == null)
                {
                    this.navigateToTextPage = new RelayCommand(HandleNavigateToTexPage);
                }
                return this.navigateToTextPage;
            }
        }

        public ICommand NavigateToByCategoryPage
        {
            get
            {
                if (this.navigateToByCategoryPage == null)
                {
                    this.navigateToByCategoryPage = new RelayCommand(HandleNavigateToCategoryPage);
                }
                return this.navigateToByCategoryPage;
            }
        }

        private void HandleNavigateToCategoryPage()
        {
            this.navigator.Navigate(Views.ByCategory);
        }

        public ICommand NavigateToByContinentPage
        {
            get
            {
                if (this.navigateToByContinentPage == null)
                {
                    this.navigateToByContinentPage = new RelayCommand(HandleNavigateToByContinentPage);
                }
                return this.navigateToByContinentPage;
            }
        }

        private void HandleNavigateToByContinentPage()
        {
            this.navigator.Navigate(Views.ByContinent);
        }

        public ICommand GoBack
        {
            get
            {
                if (this.goBack == null)
                {
                    this.goBack = new RelayCommand(HandleNavigateToMain);
                }
                return this.goBack;
            }
        }

        private void HandleNavigateToMain()
        {
            this.LoadInitState();
            this.navigator.GoBack();
        }

        private void HandleNavigateToTexPage()
        {
            this.LoadInitState();
            this.navigator.Navigate(Views.TextDescriptionPage);
        }

        private void HandleShowPrevPicture()
        {
            this.currImageIndex--;
            if (this.currImageIndex < 0)
            {
                this.currImageIndex = this.currentSelection.ImageUrl.Count - 1;
            }
            this.CurrImageUrlToShow = this.currentSelection.ImageUrl[this.currImageIndex];
        }

        private void HandeShowNextPicture()
        {
            this.currImageIndex++;
            if (this.currImageIndex >= this.currentSelection.ImageUrl.Count)
            {
                this.currImageIndex = 0;
            }
            this.CurrImageUrlToShow = this.currentSelection.ImageUrl[this.currImageIndex];
        }

        private void LoadInitState()
        {
            this.toLoadCurrentSelection = false;
            this.CurrentSelection = null;
            this.CurrImageUrlToShow = null;
        }
    }
}
