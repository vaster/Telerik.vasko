// <copyright file="Engine.cs" company="Anonymous">
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
    using System.Threading.Tasks;

    /// <summary>
    /// This class runs the functionality of the application.
    /// </summary>
    public static class Engine
    {
        // fields

        /// <summary>
        ///  <param name="holderByTitle">Used to store Events.</param>
        /// </summary>
        private static EventHolder events;

        // construcotr

        /// <summary>
        ///  Initializes static members of the <see cref="Engine"/> class.
        /// </summary>
        static Engine()
        {
            events = new EventHolder();
        }

        // properties

        /// <summary>
        /// Gets or sets value for the events field.
        /// </summary>
        private static EventHolder Events
        {
            get
            {
                return events;
            }

            set
            {
                events = value;
            }
        }

        // methods

        /// <summary>
        /// Method used to perform different actions depending on the input command.
        /// </summary>
        /// <returns>Returns True if the command is executed or False for invalid command.</returns>
        public static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command[0] == 'A')
            {
                AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// Method used to extract starting date and determine the count of Events from a command.
        ///     Execute ListEvents in <see cref="EventHolder"/> class.
        /// </summary>
        /// <param name="command">Current command.</param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);
            Events.ListEvents(date, count);
        }

        /// <summary>
        /// Method used to extract a specific title from a command.
        ///     Execute DeleteEvents in <see cref="EventHolder"/> class.
        /// </summary>
        /// <param name="command">Current command</param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            Events.DeleteEvents(title);
        }

        /// <summary>
        /// Method used to pass date, title and location to AddEvent method by instance of the EventHolder class.
        /// </summary>
        /// <param name="command">Current command</param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);
            events.AddEvent(date, title, location);
        }

        /// <summary>
        /// Method used to pass date, title and location reed from a command to Engine.AddEvent method.
        /// </summary>
        /// <param name="commandForExecution">The current command</param>
        /// <param name="commandType">Type of the command</param>
        /// <param name="dateAndTime">A date for an upcoming event reed from a command.</param>
        /// <param name="eventTitle">An event title reed from a command.</param>
        /// <param name="eventLocation">Am event location reed from a command.</param>
        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        /// <summary>
        /// Method used to extract date from a command.
        /// </summary>
        /// <param name="command">Current command.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns>Returns date reed from a command as a DateTime object.</returns>
        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));

            return date;
        }
    }
}