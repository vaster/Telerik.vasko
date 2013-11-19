using App.HttpClient_ViewModel_Bridge;
using App.Navigation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PlacesToVisit.Models.AppModel;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace App.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private Navigator navigator;
        private ICommand navigateCommand;
        private ObservableCollection<WelcomePlace> shortDescriptionList;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(Navigator navigator)
        {
            this.navigator = navigator;
            this.GetShortDescriptionList();
        }

        public IEnumerable<WelcomePlace> ShortDescriptionList
        {
            get
            {
                return this.shortDescriptionList;
            }
        }


        private async void GetShortDescriptionList()
        {
            if (this.shortDescriptionList == null)
            {
                this.shortDescriptionList = new ObservableCollection<WelcomePlace>();

                var result = await DataPersister.GetWelcomePlacesEntities();
                foreach (var desc in result)
                {
                    this.shortDescriptionList.Add(desc);
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