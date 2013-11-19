using PlacesToVisit.Models.AppModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlacesToVisit.WikiClient
{
    public class Client
    {
        // Adventure - 1
        // Great Natural Vistas - 2
        // In the Presence Of Gods - 3
        // Portals into the Past - 4
        // Scale New Heights - 5
        // Sites And Cities - 6
        // Wildlife Watching - 7
        
        //http://placesyouneedtovisit.apphb.com/
        public const string GET_WELCOME_ENTITIES_APH_ULR = "http://placesyouneedtovisit.apphb.com/api/places/welcome";
        public const string GET_DESCRIPTION_FOR_ENTITY_BY_TITLE = "http://placesyouneedtovisit.apphb.com/api/places/short?title=";
        public const string GET_FULL_DESCRIPTION_FOR_ENTITY = "http://placesyouneedtovisit.apphb.com/api/places/full?title=";
        public const string GET_ASSOCITIES_BY_CATEGORY = "http://placesyouneedtovisit.apphb.com/api/places/bycategory?category=";
        public const string GET_ASSOCITIES_BY_CONTINENT = "http://placesyouneedtovisit.apphb.com/api/places/bycontinent?continent=";

        private HttpClient wikiClient;

        private IList<string> wikiPlacesUrls;

        public Client()
        {
            this.wikiClient = new HttpClient();
            this.wikiPlacesUrls = new List<string>();
        }

        public async Task<ObservableCollection<WelcomePlace>> GetWelcomePlacesEntites()
        {
            var response = await
                this.wikiClient.GetAsync(Client.GET_WELCOME_ENTITIES_APH_ULR);

            var result = await response.Content.ReadAsStringAsync();

            ObservableCollection<WelcomePlace> welcomePlaces =
            JsonConvert.DeserializeObject<ObservableCollection<WelcomePlace>>(result);

            return welcomePlaces;
        }

        public async Task<ObservableCollection<WelcomePlace>> GetAssocietedByCategory(string category)
        {
            var response = await
                this.wikiClient.GetAsync(Client.GET_ASSOCITIES_BY_CATEGORY + category);

            var result = await response.Content.ReadAsStringAsync();

            ObservableCollection<WelcomePlace> associeties =
            JsonConvert.DeserializeObject<ObservableCollection<WelcomePlace>>(result);

            return associeties;
        }

        public async Task<ObservableCollection<WelcomePlace>> GetAssocietedByContinent(string continent)
        {
            var response = await
                this.wikiClient.GetAsync(Client.GET_ASSOCITIES_BY_CONTINENT + continent);

            var result = await response.Content.ReadAsStringAsync();

            ObservableCollection<WelcomePlace> associeties =
            JsonConvert.DeserializeObject<ObservableCollection<WelcomePlace>>(result);

            return associeties;
        }

        public async Task<ShortDescriptionPlace> GetShortDescriptionPlaceEntity(string title)
        {
             var response = await
                this.wikiClient.GetAsync(Client.GET_DESCRIPTION_FOR_ENTITY_BY_TITLE + title);

             var result = await response.Content.ReadAsStringAsync();

             ShortDescriptionPlace shortDescriptions =
            JsonConvert.DeserializeObject<ShortDescriptionPlace>(result);

             return shortDescriptions;
        }

        public async Task<string> GetDescriptionForSepcificPlace(string title)
        {
            var response = await
                this.wikiClient.GetAsync(Client.GET_FULL_DESCRIPTION_FOR_ENTITY + title);

            var result = await response.Content.ReadAsStringAsync();

            string textDescription =
             JsonConvert.DeserializeObject<string>(result);

            return textDescription;
        }
    }
}
