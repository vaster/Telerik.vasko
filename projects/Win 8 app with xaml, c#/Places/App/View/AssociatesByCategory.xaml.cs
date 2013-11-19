using App.ViewModel;
using PlacesToVisit.Models.AppModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AssociatesByCategory : Page
    {
        public AssociatesByCategory()
        {
            this.InitializeComponent();
            this.SizeChanged += (a, b) =>
            {
                ApplicationViewState views = ApplicationView.Value;
                VisualStateManager.GoToState(this, views.ToString(), false);
            };
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void NavigateToShortDescriptionPage(object sender, ItemClickEventArgs e)
        {
            ShortDescriptionViewModel.SelectedElement = (e.ClickedItem as WelcomePlace);
            (this.DataContext as AssociatesByCategoryViewModel).NavigateCommand.Execute(null);
        }
    }
}
