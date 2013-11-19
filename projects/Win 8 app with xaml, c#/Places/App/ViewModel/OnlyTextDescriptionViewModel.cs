using App.HttpClient_ViewModel_Bridge;
using App.Navigation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.ViewModel
{
    public class OnlyTextDescriptionViewModel : ViewModelBase
    {
        private string contents;
        private ICommand goBack;
        private Navigator navigator;

        public OnlyTextDescriptionViewModel(Navigator navigator)
        {
            this.navigator = navigator;
        }

        public string Contents
        {
            get
            {
                this.GetDescriptionList();
                return this.contents;
            }
            set
            {
                this.contents = value;
                this.RaisePropertyChanged("Contents");
            }
        }


        public string Title
        {
            get { return ShortDescriptionViewModel.SelectedElement.Title; }
        }

        private async void GetDescriptionList()
        {
            var result = await DataPersister.GetDescriptionForSepcificPlace(ShortDescriptionViewModel.SelectedElement.Title);

            this.Contents = result;
        }

        public ICommand GoBack
        {
            get
            {
                if (this.goBack == null)
                {
                    this.goBack = new RelayCommand(HandleNavigateToDescriptionPage);
                }
                return this.goBack;
            }
        }

        private void HandleNavigateToDescriptionPage()
        {
            this.navigator.GoBack();
        }
    }
}
