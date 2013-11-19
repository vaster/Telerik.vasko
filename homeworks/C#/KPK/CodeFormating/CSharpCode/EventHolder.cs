// <copyright file="EventHolder.cs" company="Anonymous">
//      Copyright statement. All right reserved.
// <author>Me</author>
// </copyright>
namespace CSharpCode
{
    //// 1.Code Refactored.
    //// 2.Encapsulation - all fields are accessed by properties.
    //// 3.Order of declaration - field, constructor, prop, method(on this one you can have more freedom of the order).
    //// 4.Empty consturctor to initialize the fileds.
    //// 5.All other changes are done by recomendation of StyleCop tool.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    /// <summary>
    /// This class is used to add, delete and show Events.
    /// </summary>
    public class EventHolder
    {
        // fields

        /// <summary>
        /// <param name="holderByTitle">Used to store Events.</param>
        /// </summary>
        private MultiDictionary<string, Event> holderByTitle;

        /// <summary>
        /// <param name="orderByDate">Used to store Events in sorted order.</param>
        /// </summary>
        private OrderedBag<Event> orderedByDate;

        // constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHolder"/> class. 
        /// </summary>
        public EventHolder()
        {
            this.holderByTitle = new MultiDictionary<string, Event>(true);
            this.orderedByDate = new OrderedBag<Event>();
        }

        // properties

        /// <summary>
        /// Gets or sets value for holderByTitle field.
        /// </summary>
        private MultiDictionary<string, Event> HolderByTitle
        {
            get
            {
                return this.holderByTitle;
            }

            set
            {
                this.holderByTitle = value;
            }
        }

        /// <summary>
        /// Gets or sets value for orderByDate filed.
        /// </summary>
        private OrderedBag<Event> OrderedByDate
        {
            get
            {
                return this.orderedByDate;
            }

            set
            {
                this.orderedByDate = value;
            }
        }

        // methods

        /// <summary>
        /// Method for adding a new Event.
        /// </summary>
        /// <param name="date">Date of an Event</param>
        /// <param name="title">Title of an Event</param>
        /// <param name="location">Location of an Event</param>
        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.HolderByTitle.Add(title.ToLower(), newEvent);
            this.OrderedByDate.Add(newEvent);
            Messages.EventAdded();
        }

        /// <summary>
        /// Method for deleting Event by title.
        /// </summary>
        /// <param name="titleToDelete">A string value representing the title of a specific Event</param>
        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;
            foreach (var eventToRemove in this.HolderByTitle[title])
            {
                removed++;
                this.OrderedByDate.Remove(eventToRemove);
            }

            this.HolderByTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        /// <summary>
        /// Method used to show  Events form a specific date(including it) to specific range defined by <see cref="count"/>.
        /// </summary>
        /// <param name="date">Starting date.</param>
        /// <param name="count">Count of Events to be showed.</param>
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.OrderedByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}