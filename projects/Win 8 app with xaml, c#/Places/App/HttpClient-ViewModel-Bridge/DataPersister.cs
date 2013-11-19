using PlacesToVisit.Models.AppModel;
using PlacesToVisit.WikiClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.HttpClient_ViewModel_Bridge
{
    public class DataPersister
    {
        private static Client wikiClient;

        static DataPersister()
        {
            DataPersister.wikiClient = new Client();
        }

        public async static Task<ObservableCollection<WelcomePlace>> GetWelcomePlacesEntities()
        {
            var result = await DataPersister.wikiClient.GetWelcomePlacesEntites();

            return result;
        }

        public async static Task<ShortDescriptionPlace> GetFullDescriptionForPlace(string title)
        {
            var result = await DataPersister.wikiClient.GetShortDescriptionPlaceEntity(title);

            return result;
        }

        public async static Task<string> GetDescriptionForSepcificPlace(string title)
        {
            var result = await DataPersister.wikiClient.GetDescriptionForSepcificPlace(title);

            return result;
        }

        public async static Task<ObservableCollection<WelcomePlace>> GetAssocietesByCategory(string category)
        {
            var result = await DataPersister.wikiClient.GetAssocietedByCategory(category);

            return result;
        }

        public async static Task<ObservableCollection<WelcomePlace>> GetAssocietesByContinent(string continent)
        {
            var result = await DataPersister.wikiClient.GetAssocietedByContinent(continent);

            return result;
        }
    }
}
