// <copyright file="Event.cs" company="Anonymous">
//      Copyright statement. All right reserved.
// <author>Me</author>
// </copyright>
namespace CSharpCode
{
    //// 1.Code Refactored.
    //// 2.Encapsulation - all fields are accessed properties.
    //// 3.Order of declaration - field, constructor, prop, method(on this one you can have more freedom of the order).
    //// 4.All other changes are done by recomendation of StyleCop tool.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class is used for creation of an events.
    /// </summary>
    public class Event : IComparable
    {
        // fileds

        /// <summary>
        /// <param name="date">Used to indicate the date of an event.</param>
        /// </summary>
        private DateTime date;

        /// <summary>
        /// <param name="title">Used to indicate the title of an event.</param>
        /// </summary>
        private string title;

        /// <summary>
        /// <param name="date">Used to indicate the location of an event.</param>
        /// </summary>
        private string location;
        
        // construcotr

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="date">Date of the Event.</param>
        /// <param name="title">Title of the Event.</param>
        /// <param name="location">Location of the Event.</param>
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        // properties

        /// <summary>
        /// Gets or sets value for the date filed.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        /// <summary>
        /// Gets or sets value for the title field.
        /// </summary>
        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        /// <summary>
        /// Gets or sets value for the location field.
        /// </summary>
        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.location = value;
            }
        }

        // methods

        /// <summary>
        /// Method for comparing two events by name, location and title.
        /// </summary>
        /// <param name="obj">as Event.</param>
        /// <returns>Returns 0 for even  Events properties, or negative number for the first occur of a mismatch of a properties between two Events.</returns>
        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int compareByDate = this.Date.CompareTo(other.Date);
            int compareByTitle = this.Title.CompareTo(other.Title);
            int compareByLocation = this.Location.CompareTo(other.Location);

            if (compareByDate == 0)
            {
                if (compareByTitle == 0)
                {
                    return compareByLocation;
                }
                else
                {
                    return compareByTitle;
                }
            }
            else
            {
                return compareByDate;
            }
        }

        /// <summary>
        /// Method for printing information of an Event.
        /// </summary>
        /// <returns>Returns properties of an Event as a string in a specific format.</returns>
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.Title);

            if (this.Location != null && this.Location != string.Empty)
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }
    }
}
