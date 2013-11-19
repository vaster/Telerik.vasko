using App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App.Navigation
{
    public class Navigator
    {
        private Type GetViewType(Views view)
        {
            switch (view)
            {
                case Views.MainPage:
                    return typeof(MainPage);
                case Views.DescriptionPage:
                    return typeof(ShortDescriptionPage);
                case Views.TextDescriptionPage:
                    return typeof(OnlyTextDescriptionPage);
                case Views.MainPageSearch:
                    return typeof(MainPageSearch);
                case Views.NoInternetPage:
                    return typeof(NoInternetPage);
                case Views.ByContinent:
                    return typeof(AssociatesByContinent);
                case Views.ByCategory:
                    return typeof(AssociatesByCategory);
            }

            return null;
        }

        public void Navigate(Views sourcePageType)
        {
            var pageType = this.GetViewType(sourcePageType);
            if (pageType != null)
            {
                ((Frame)Window.Current.Content).Navigate(pageType);
            }
        }

        public void Navigate(Views sourcePageType, object parameter)
        {
            var pageType = this.GetViewType(sourcePageType);

            if (pageType != null)
            {
                ((Frame)Window.Current.Content).Navigate(pageType, parameter);
            }
        }

        public void GoBack()
        {
            ((Frame)Window.Current.Content).GoBack();
        }
    }
}
