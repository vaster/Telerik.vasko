/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:App"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using App.Navigation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace App.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<Navigator>();
            SimpleIoc.Default.Register<ShortDescriptionViewModel>();
            SimpleIoc.Default.Register<OnlyTextDescriptionViewModel>();
            SimpleIoc.Default.Register<SearchViewModel>();
            SimpleIoc.Default.Register<AssociatesByContinentViewModel>();
            SimpleIoc.Default.Register<AssociatesByCategoryViewModel>();
        }

        public ViewModelBase Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public ViewModelBase ShortDescription
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ShortDescriptionViewModel>();
            }
        }

        public ViewModelBase TextDescription
        {
            get
            {
                return ServiceLocator.Current.GetInstance<OnlyTextDescriptionViewModel>();
            }
        }

        public ViewModelBase Search
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SearchViewModel>();
            }
        }

        public AssociatesByContinentViewModel ByContinent
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AssociatesByContinentViewModel>();
            }
        }

        public AssociatesByCategoryViewModel ByCategory
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AssociatesByCategoryViewModel>();
            }
        }

        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}